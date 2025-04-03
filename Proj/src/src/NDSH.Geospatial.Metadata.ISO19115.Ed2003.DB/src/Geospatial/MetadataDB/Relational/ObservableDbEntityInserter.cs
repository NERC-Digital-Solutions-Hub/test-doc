
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NDSH.Database.Entities;
using System.Collections;
using System.Reflection;

namespace NDSH.Geospatial.MetadataDB.Relational {
  /// <summary>
  ///   Inserts <see cref="ObservableDbEntity" /> instances into the database. This is able to prevent duplicate
  ///   entries in the database.
  /// </summary>
  public class ObservableDbEntityInserter {
    private static readonly Dictionary<Type, HashSet<ObservableDbEntity>> LocalEntityCache = new();
    private static readonly Dictionary<Type, HashSet<ObservableDbEntity>> DatabaseEntityCache = new();
    private static readonly Dictionary<Type, PropertyInfo[]> PropertiesCache = new();

    private static readonly MethodInfo InsertMethod = typeof(ObservableDbEntityInserter)
      .GetMethod(nameof(InsertAsync), BindingFlags.Public | BindingFlags.Static)!;

    private static readonly Dictionary<Type, InsertDelegateAsync> InsertDelegateCache = new();

    /// <summary>
    ///   Inserts an <see cref="ObservableDbEntity" /> into the database.
    /// </summary>
    /// <typeparam name="TObservableDbEntity">The <see cref="ObservableDbEntity" /> <see cref="Type" />.</typeparam>
    /// <param name="entity">The <see cref="ObservableDbEntity" /> instance.</param>
    /// <param name="context">The <see cref="MetadataDatabaseContext" /> instance.</param>
    /// <returns>The inserted <see cref="ObservableDbEntity" />.</returns>
    public static async Task<TObservableDbEntity> InsertAsync<TObservableDbEntity>(TObservableDbEntity entity, MetadataDatabaseContext context)
      where TObservableDbEntity : ObservableDbEntity, new() {
      try {
        Type type = entity.GetType();
        IEntityType? entityType = context.Model.FindEntityType(type);
        if (entityType == null) {
          return entity;
        }

        TObservableDbEntity? existingEntity = GetExistingEntity(entity, context);
        if (existingEntity != null) {
          return existingEntity;
        }

        TObservableDbEntity entityCopy = (TObservableDbEntity)await CopyEntityAsync(entity, context);
        await context.AddAsync(entityCopy);

        if (LocalEntityCache.TryGetValue(type, out HashSet<ObservableDbEntity>? entities)) {
          entities.Add(entityCopy);
        }

        return entityCopy;
      }
      catch (Exception ex) {
        return entity;
      }
    }

    /// <summary>
    ///   Clears the local and database entity caches. Ideally, this should be called after
    ///   <see cref="DbContext.SaveChanges()" /> or <see cref="DbContext.SaveChangesAsync(CancellationToken)" />
    ///   to prevent intense memory usage.
    /// </summary>
    public static void ClearCache() {
      LocalEntityCache.Clear();
      DatabaseEntityCache.Clear();
    }

    /// <summary>
    ///   Attempts to get an existing <see cref="ObservableDbEntity" /> from the <see cref="MetadataDatabaseContext" />
    ///   local view or database.
    /// </summary>
    /// <typeparam name="TObservableDbEntity">The <see cref="ObservableDbEntity" /> <see cref="Type" />.</typeparam>
    /// <param name="entity">The <see cref="ObservableDbEntity" /> instance.</param>
    /// <param name="context">The <see cref="MetadataDatabaseContext" /> instance.</param>
    /// <returns>
    ///   An existing entity or <see langword="null" /> if a matching entity does not exist in either the local view
    ///   or database.
    /// </returns>
    private static TObservableDbEntity? GetExistingEntity<TObservableDbEntity>(TObservableDbEntity entity, MetadataDatabaseContext context)
      where TObservableDbEntity : ObservableDbEntity {
      TObservableDbEntity? localEntity = GetExistingLocalEntity(entity, context);
      if (localEntity != null) {
        return localEntity;
      }

      TObservableDbEntity? databaseEntity = GetExistingDatabaseEntity(entity, context);
      if (databaseEntity != null) {
        return databaseEntity;
      }

      return null;
    }

    /// <summary>
    ///   Attempts to get an existing <see cref="ObservableDbEntity" /> from the <see cref="MetadataDatabaseContext" />
    ///   local view. This will cache all the instances of the <paramref name="entity" /> <see cref="Type" /> for more
    ///   efficient future lookups.
    /// </summary>
    /// <typeparam name="TObservableDbEntity">The <see cref="ObservableDbEntity" /> <see cref="Type" />.</typeparam>
    /// <param name="entity">The <see cref="ObservableDbEntity" /> instance.</param>
    /// <param name="context">The <see cref="MetadataDatabaseContext" /> instance.</param>
    /// <returns>An existing entity or <see langword="null" /> if a matching entity does not exist in the local view.</returns>
    private static TObservableDbEntity? GetExistingLocalEntity<TObservableDbEntity>(TObservableDbEntity entity, MetadataDatabaseContext context)
      where TObservableDbEntity : ObservableDbEntity {
      Type type = entity.GetType();
      if (!LocalEntityCache.TryGetValue(type, out HashSet<ObservableDbEntity>? entities)) {
        entities = context.Set<TObservableDbEntity>().Local
          .AsEnumerable()
          .ToHashSet<ObservableDbEntity>();
        LocalEntityCache[type] = entities;
      }

      return entities.TryGetValue(entity, out ObservableDbEntity? localEntity)
        ? (TObservableDbEntity)localEntity
        : null;
    }

    /// <summary>
    ///   Attempts to get an existing <see cref="ObservableDbEntity" /> from the database. This will cache all the
    ///   instances of the <paramref name="entity" /> <see cref="Type" /> for more efficient future lookups.
    /// </summary>
    /// <typeparam name="TObservableDbEntity">The <see cref="ObservableDbEntity" /> <see cref="Type" />.</typeparam>
    /// <param name="entity">The <see cref="ObservableDbEntity" /> instance.</param>
    /// <param name="context">The <see cref="MetadataDatabaseContext" /> instance.</param>
    /// <returns>An existing entity or <see langword="null" /> if a matching entity does not exist in the database.</returns>
    private static TObservableDbEntity? GetExistingDatabaseEntity<TObservableDbEntity>(TObservableDbEntity entity, MetadataDatabaseContext context)
      where TObservableDbEntity : ObservableDbEntity {
      Type type = entity.GetType();
      if (!DatabaseEntityCache.TryGetValue(type, out HashSet<ObservableDbEntity>? entities)) {
        entities = context.Set<TObservableDbEntity>()
          .AsNoTracking()
          .AsEnumerable()
          .ToHashSet<ObservableDbEntity>();
        DatabaseEntityCache[type] = entities;
      }

      if (entities.TryGetValue(entity, out ObservableDbEntity? databaseEntity)) {
        context.Attach(databaseEntity);
        return (TObservableDbEntity)databaseEntity;
      }

      return null;
    }

    /// <summary>
    ///   Inserts an <see cref="ObservableDbEntity" /> into the database. This is the internal method that is used
    ///   when recursively inserting <see cref="ObservableDbEntity" /> instances.
    /// </summary>
    /// <param name="value">The <see cref="ObservableDbEntity" /> value to insert.</param>
    /// <param name="valueType">The <see cref="ObservableDbEntity" /> <see cref="Type" />.</param>
    /// <param name="context">The <see cref="MetadataDatabaseContext" /> instance.</param>
    /// <returns>A <see cref="Task{T}" /> returning the inserted <see cref="ObservableDbEntity" />.</returns>
    private static async Task<ObservableDbEntity?> InsertInternalAsync(ObservableDbEntity value, Type valueType, MetadataDatabaseContext context) {
      if (value == null) {
        return null;
      }

      if (!InsertDelegateCache.TryGetValue(valueType, out InsertDelegateAsync? insertDelegateAsync)) {
        insertDelegateAsync = CreateInsertDelegateAsync(valueType);
        InsertDelegateCache[valueType] = insertDelegateAsync;
      }

      return await insertDelegateAsync(value, context);
    }

    /// <summary>
    ///   Creates an <see cref="InsertDelegateAsync" /> for the specified <see cref="Type" />.
    /// </summary>
    /// <param name="valueType">The value <see cref="Type" />. This will be the generic.</param>
    /// <returns>An <see cref="InsertDelegateAsync" /> instance.</returns>
    private static InsertDelegateAsync CreateInsertDelegateAsync(Type valueType) {
      MethodInfo genericInsertMethod = InsertMethod.MakeGenericMethod(valueType);
      return async (entity, context) => {
        object taskObj = genericInsertMethod.Invoke(null, [entity, context])!;
        dynamic awaitedTask = taskObj;
        ObservableDbEntity result = await awaitedTask;
        return result;
      };
    }

    /// <summary>
    ///   Copies the specified <see cref="ObservableDbEntity" /> asynchronously.
    /// </summary>
    /// <param name="entity">The <see cref="ObservableDbEntity" /> to copy.</param>
    /// <param name="context">The <see cref="MetadataDatabaseContext" /> instance.</param>
    /// <returns>A copy of <paramref name="entity" />.</returns>
    private static async Task<ObservableDbEntity> CopyEntityAsync(ObservableDbEntity entity, MetadataDatabaseContext context) {
      Type runtimeType = entity.GetType();
      ObservableDbEntity entityCopy = CopyEntity(runtimeType);
      PropertyInfo[] properties = GetEntityProperties(runtimeType);

      foreach (PropertyInfo property in properties) {
        if (!property.CanRead || !property.CanWrite) {
          continue;
        }

        object? originalValue = property.GetValue(entity);
        if (originalValue == null) {
          continue;
        }

        object? copiedValue = await CopyValueAsync(originalValue, property.PropertyType, context);
        property.SetValue(entityCopy, copiedValue);
      }

      return entityCopy;
    }

    /// <summary>
    ///   Creates a copy of the specified entity <see cref="Type" />.
    /// </summary>
    /// <param name="runtimeType">The actual <see cref="Type" /> of the entity.</param>
    /// <returns>An instance of the entity <see cref="Type" />.</returns>
    private static ObservableDbEntity CopyEntity(Type runtimeType) => (ObservableDbEntity)Activator.CreateInstance(runtimeType)!;

    /// <summary>
    ///   Gets the public properties of the specified entity <see cref="Type" />.
    /// </summary>
    /// <param name="entityType">The entity <see cref="Type" />.</param>
    /// <returns>An <see cref="Array" /> of <see cref="PropertyInfo" />.</returns>
    private static PropertyInfo[] GetEntityProperties(Type entityType) {
      if (!PropertiesCache.TryGetValue(entityType, out PropertyInfo[]? properties)) {
        properties = entityType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        PropertiesCache[entityType] = properties;
      }

      return properties;
    }

    /// <summary>
    ///   Copies the specified value asynchronously.
    /// </summary>
    /// <param name="value">The value to copy.</param>
    /// <param name="valueType">The value <see cref="Type" />.</param>
    /// <param name="context">The <see cref="MetadataDatabaseContext" /> instance.</param>
    /// <returns>A copy of <paramref name="value" />.</returns>
    private static async Task<object?> CopyValueAsync(object value, Type valueType, MetadataDatabaseContext context) {
      if (valueType.IsAbstract) {
        valueType = value.GetType();
      }

      // 1. Handle primitives and value types.
      if (IsPrimitiveOrValueType(valueType)) {
        return value;
      }

      // 2. Handle ObservableDbEntity types.
      if (value is ObservableDbEntity observableDbEntity) {
        return await InsertInternalAsync(observableDbEntity, valueType, context);
      }

      // 3. Handle collections with ObservableDbEntity.
      if (value is IList collection) {
        return await CopyCollection(collection, valueType, context);
      }

      // 4. Default to the original value.
      return value;
    }

    /// <summary>
    ///   Determines if the specified <see cref="Type" /> is a primitive or value type.
    /// </summary>
    /// <param name="type">The <see cref="Type" /> to check.</param>
    /// <returns>
    ///   <see langword="true" /> if the <see cref="Type" /> is primitive or a value type; <see langword="false" /> if not.
    /// </returns>
    private static bool IsPrimitiveOrValueType(Type type) => type.IsPrimitive || type.IsValueType || type == typeof(string);

    /// <summary>
    ///   Copies a collection of <see cref="ObservableDbEntity" /> instances.
    /// </summary>
    /// <param name="collection">The original collection.</param>
    /// <param name="collectionType">The original collection <see cref="Type" />.</param>
    /// <param name="context">The <see cref="MetadataDatabaseContext" /> instance.</param>
    /// <returns>A <see cref="IList" /> with copied <see cref="ObservableDbEntity" /> instances.</returns>
    private static async Task<IList?> CopyCollection(IList collection, Type collectionType, MetadataDatabaseContext context) {
      if (!collectionType.IsGenericType) {
        return null;
      }

      IList? newCollection = CreateCollection(collectionType);
      if (newCollection == null) {
        return null;
      }

      foreach (ObservableDbEntity observableDbEntity in collection.Cast<ObservableDbEntity>()) {
        Type itemType = observableDbEntity.GetType();
        ObservableDbEntity? insertedEntity = await InsertInternalAsync(observableDbEntity, itemType, context);
        newCollection.Add(insertedEntity);
      }

      return newCollection;
    }

    /// <summary>
    ///   Creates a collection of the specified <see cref="Type" />. This is used to copy different collection
    ///   <see cref="Type" />s.
    /// </summary>
    /// <param name="collectionType">The collection <see cref="Type" />.</param>
    /// <returns>A collection of the element <see cref="Type" />.</returns>
    private static IList? CreateCollection(Type collectionType) {
      IList? collection = (IList?)Activator.CreateInstance(collectionType);
      return collection;
    }

    private delegate Task<ObservableDbEntity> InsertDelegateAsync(ObservableDbEntity entity, MetadataDatabaseContext context);
  }
}
