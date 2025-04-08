using Microsoft.EntityFrameworkCore;
using NDSH.Geospatial.Metadata;
using NDSH.Geospatial.Metadata.EntitySet;

namespace NDSH.Geospatial.MetadataDB.Relational {
  /// <summary>
  ///   The <see cref="DbContext" /> for the Metadata Database.
  /// </summary>
  public class MetadataDatabaseContext : DbContext {
    private const string DatabaseName = "NDSH_Metadata_Database.sqlite";
    private readonly string _databasePath;

    /// <summary>
    ///   Initializes the <see cref="MetadataDatabaseContext" />.
    /// </summary>
    /// <param name="databasePath">The path to the database file. Leave null to use default path.</param>
    public MetadataDatabaseContext(string? databasePath = null) {
      _databasePath = databasePath ??
                      Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DatabaseName);
    }

    /// <summary>
    ///   The <see cref="DbSet{T}" /> for <see cref="MetadataDocument" />.
    /// </summary>
    public DbSet<MetadataDocument> MetadataBlobDocuments {
      get;
      set;
    }

    /// <summary>
    ///   The <see cref="DbSet{T}" /> for <see cref="MD_Metadata_Type" />.
    /// </summary>
    public DbSet<MD_Metadata_Type> MetadataInstances {
      get;
      set;
    }

    /// <summary>
    ///   Configures the <see cref="DbContextOptionsBuilder" /> for the <see cref="MetadataDatabaseContext" />.
    /// </summary>
    /// <param name="options">The <see cref="DbContextOptionsBuilder" />.</param>
    protected override void OnConfiguring(DbContextOptionsBuilder options)
      => options.UseSqlite($"Data Source={_databasePath}");

    /// <summary>
    ///   Configures the <see cref="ModelBuilder" /> for the <see cref="MetadataDatabaseContext" />.
    /// </summary>
    /// <param name="modelBuilder">The <see cref="ModelBuilder" />.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);
      ModelReferencedObjects(modelBuilder);

      modelBuilder.ApplyConfigurationsFromAssembly(typeof(MetadataDatabaseContext).Assembly);
    }

    /// <summary>
    ///   Configures the <see cref="ReferenceEntity" /> for the <see cref="MetadataDatabaseContext" />.
    /// </summary>
    /// <param name="modelBuilder">The <see cref="ModelBuilder" />.</param>
    private void ModelReferencedObjects(ModelBuilder modelBuilder) {
      modelBuilder.Entity<ReferenceEntity>()
        .HasKey(referencedObject => referencedObject.DbId);

      modelBuilder.Entity<ReferenceEntity>()
        .Property(referencedObject => referencedObject.DbId)
        .HasColumnName("DbId")
        .ValueGeneratedOnAdd();
    }


    /// <summary>
    ///   Resets the database by deleting and recreating it.
    /// </summary>
    /// <returns>A <see cref="Task" />.</returns>
    public async Task ResetDatabaseAsync() {
      // delete the database
      bool deleted = await Database.EnsureDeletedAsync();
      string deletedMessage = deleted
        ? "Database deleted successfully."
        : "Database did not exist or could not be deleted.";

      Console.WriteLine(deletedMessage);

      // create the database
      bool created = await Database.EnsureCreatedAsync();
      string createdMessage = created
        ? "Database created successfully."
        : "Database already exists or could not be created.";

      Console.WriteLine(createdMessage);
    }
  }
}
