
using System.Reflection;
using System.Diagnostics;
using System.Collections;
using NDSH.Geospatial.Metadata.V2003.Thin.Application;

namespace NDSH.Geospatial.Metadata.V2003.Thin.Tests {

  /// <summary>
  /// 
  /// </summary>
  public class Helper {

    public static readonly Dictionary<string, string> RestrictedStringDummyValues = new(){
      {"Show", NDSH.Geospatial.Metadata.V2003.Thin.XLinks.IShow.ShowBehaviours[XLinks.ShowBehaviour.None] },
      {"Actuate", NDSH.Geospatial.Metadata.V2003.Thin.XLinks.IActuate.ActuateBehaviours[XLinks.ActuateBehaviour.None] }
    };

    public void GenerateInitializationUnitTests() {
      var assembly = Assembly.GetAssembly(typeof(AbstractDS_Aggregate_Type));

      List<Type> publicClasses = assembly.GetTypes().Where(
        t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("_Type")
        ).ToList();
    }

    /// <summary>
    /// Checks if the requested <see cref="Type"/> is a a <see cref="List{T}"><paramref name="T"/></see>.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to be checked.</param>
    /// <returns>
    /// A <see cref="bool"/> indicating whether the <see cref="Type"/> is a <see cref="List{T}"><paramref name="T"/></see> or not.
    /// </returns>
    public static bool IsList(Type type) {
      return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
    }

    /// <summary>
    /// Gets a dummy object initialized with default values.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> of object to initialize.</param>
    /// <returns>An instance of the <see cref="Type"/> specified.</returns>
    /// <exception cref="NullReferenceException">
    /// Thrown when <see cref="PropertyInfo"/> is <see cref="null"/> or
    /// when a <see cref="List{T}"><paramref name="T"/></see> is <see cref="null"/>.
    /// </exception>
    /// <exception cref="NotImplementedException"></exception>
    /// <exception cref="NotSupportedException"></exception>
    public static object GetDummyObject(Type type) {
      Debug.Assert(type != null);

      // TODO: do other unit test for PropertyType Classes, and its inheritances.
      if (type.Name.EndsWith("_PropertyType") || type.Name.EndsWith("PropertyType") || type.IsAbstract) { // TODO: The problem here is that soon we will need to change the names of the classes. So, this needs to change using the inheritance path and discovering if root object is AbstractObject_Type (this name will change as well).
        return null;
      }
      Debug.Assert(type.FullName is not null);
      var o = type.Assembly.CreateInstance(typeName: type.FullName);
      Debug.Assert(o != null);

      PropertyInfo[] propInfos = type.GetProperties();
      foreach (PropertyInfo pi in propInfos) {
        if (pi == null) {
          throw new NullReferenceException("Get PropertyInfo failed.");
        }

        if (!(pi.CanRead && pi.CanWrite)) {
          continue;
        }

        if (pi.PropertyType == typeof(string)) {
          bool isRestrictedString = RestrictedStringDummyValues.TryGetValue(pi.Name, out string value);

          if (isRestrictedString) {
            pi.SetValue(o, value);
          }
          else {
            pi.SetValue(o, $"{pi.Name}_DummyValue");
          }

          continue;
        }

        if (pi.PropertyType == typeof(int)) {
          pi.SetValue(o, 999);
          continue;
        }

        if (pi.PropertyType == typeof(bool)) {
          pi.SetValue(o, false);
          continue;
        }

        if (pi.PropertyType == typeof(double)) {
          pi.SetValue(o, 0.0);
          continue;
        }

        if (pi.PropertyType == typeof(DateTime)) {
          pi.SetValue(o, DateTime.Now);
          continue;
        }

        if (IsList(pi.PropertyType)) {
          Type elementType = pi.PropertyType.GetGenericArguments().Single();

          if (elementType == typeof(string)) {
            return new List<string>() { $"{pi.Name}_DummyValue" }; // just for GML
          }


          Type listType = typeof(List<>).MakeGenericType(elementType);

          Debug.Assert(listType.FullName is not null);
          IList myList = listType.Assembly.CreateInstance(typeName: listType.FullName) as IList;

          if (myList == null) {
            throw new NullReferenceException("List Creation failed.");
          }

          object e = GetDummyObject(elementType);
          // TODO: add a param to populate the list, cases: 0 element, 1 element, 2 elements 
          myList?.Add(e);
          pi.SetValue(o, myList);
          continue;
        }

        if (pi.PropertyType.IsClass) {
          pi.SetValue(o, GetDummyObject(pi.PropertyType));
          continue;
        }

        if (pi.PropertyType.IsEnum) {
          Array arr = pi.PropertyType.GetEnumValues();
          Debug.Assert(arr.Length > 0);
          pi.SetValue(o, arr.GetValue(0));
          continue;
        }

        throw new NotSupportedException(
          $"Unhandled PropertyType: " + $"{type.Name}.{pi.PropertyType.Name} {pi.Name} "
          );
      }

      return o;
    }

  }

}
