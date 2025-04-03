using NDSH.Apps;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml {
  /// <summary>
  ///   An abstract class that specifies the mapping of an <see cref="XElement" /> to a class instance.
  /// </summary>
  public abstract class XmlElementReader {
    /// <summary>
    /// The <see cref="Type"/> that the <see cref="XmlElementReader"/> maps an <see cref="XElement"/> to.
    /// </summary>
    public abstract Type Type {
      get;
    }

    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to an <see cref="object"/>.
    /// </summary>
    /// <param name="element">The element to read.</param>
    /// <param name="options">The <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>The mapped element as an <see cref="object"/>.</returns>
    public abstract object? ReadAsObject(XElement element, XmlElementSerializerOptions options);

    /// <summary>
    /// Determines if the <see cref="XmlElementReader"/> can read the specified <see cref="Type"/>.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to read.</param>
    /// <returns>
    /// <see langword="true"/> if the <see cref="XmlElementReader"/> can read the <see cref="Type"/>;
    /// <see langword="false"/> if not.
    /// </returns>
    public virtual bool CanRead(Type type) => Type == type;
  }

  /// <summary>
  ///  An abstract class that specifies the mapping of an <see cref="XElement" /> to a class instance.
  /// </summary>
  /// <typeparam name="T">The <see cref="Type"/> to map the <see cref="XElement"/> to.</typeparam>
  public abstract class XmlElementReader<T> : XmlElementReader {
    private static readonly Type _type = typeof(T);

    /// <inheritdoc />
    public override Type Type => _type;

    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <typeparamref name="T"/>.
    /// </summary>
    /// <param name="element">The element to read.</param>
    /// <param name="options">The <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>The mapped element as an instance of <typeparamref name="T"/>.</returns>
    public abstract T Read(XElement element, XmlElementSerializerOptions options);

    /// <inheritdoc />
    public sealed override object? ReadAsObject(XElement element, XmlElementSerializerOptions options) => Read(element, options);
  }
}
