using NDSH.Apps;
using System.Text.Json;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml {
  /// <summary>
  ///   Handles serialization of <see cref="XElement"/> instances.
  /// </summary>
  /// <remarks>This implementation is inspired from <see cref="JsonSerializer"/>.</remarks>
  public static class XmlElementSerializer {
    /// <summary>
    ///  Reads an <see cref="XElement"/> as an instance of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The <paramref name="element"/> <see cref="Type"/>.</typeparam>
    /// <param name="element">The element to read.</param>
    /// <param name="options">The <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>The an instance of <typeparamref name="T"/> using the <paramref name="element"/>.</returns>
    public static T Read<T>(XElement element, XmlElementSerializerOptions options) {
      XmlElementReader reader = options.GetReader(typeof(T));
      return (T)reader.ReadAsObject(element, options);
    }

    /// <summary>
    ///  Reads an <see cref="XElement"/> to an <see cref="object"/>.
    /// </summary>
    /// <param name="type">The <paramref name="element"/> <see cref="Type"/>.</param>
    /// <param name="element">The element to read.</param>
    /// <param name="options">The <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>The an instance of the <see cref="Type"/> using the <paramref name="element"/>.</returns>
    public static object Read(Type type, XElement element, XmlElementSerializerOptions options) {
      XmlElementReader reader = options.GetReader(type);
      return reader.ReadAsObject(element, options);
    }
  }
}
