using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml {
  /// <summary>
  ///   An extension class for <see cref="XElement" />.
  /// </summary>
  public static class XElementExtensions {
    /// <summary>
    ///   Gets the attribute value of the specified local name.
    /// </summary>
    /// <param name="element">The <see cref="XElement" />.</param>
    /// <param name="localName">The attribute local name.</param>
    /// <returns>The attribute value.</returns>
    public static string? GetAttributeByLocalName(this XElement element, string localName) {
      return element.Attributes()
        .FirstOrDefault(attribute => attribute.Name.LocalName.Equals(localName, StringComparison.OrdinalIgnoreCase))
        ?.Value;
    }

    /// <summary>
    ///   Gets the first child element of the specified <see cref="XElement" />.
    /// </summary>
    /// <param name="element">The <see cref="XElement" /> to get the property <see cref="XElement" /> from.</param>
    /// <returns>The property <see cref="XElement" />.</returns>
    public static XElement? GetPropertyElement(this XElement element) => element.Elements().FirstOrDefault();
  }
}
