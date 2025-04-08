using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers {
  /// <summary>
  /// Extension methods for <see cref="XmlElementReader"/>.
  /// </summary>
  public static class XmlElementReaderExtensions {
    /// <summary>
    /// Gets the value of an element from an <see cref="XElement"/> children. This is designed for reading ISO 19115
    /// elements. Therefore, it will use <see cref="XElementExtensions.GetPropertyElement(XElement)"/> to get the
    /// first child element of the specified element.
    /// </summary>
    /// <remarks>
    /// Since this method is designed specifically for reading ISO 19115 elements, it is added as an extension 
    /// method to the <see cref="XmlElementReader"/> class, rather than in the class itself.
    /// </remarks>
    /// <typeparam name="T">The element <see cref="Type"/>.</typeparam>
    /// <param name="reader">The <see cref="XmlElementReader"/> instance.</param>
    /// <param name="elementName">The name of the element.</param>
    /// <param name="element">
    /// The element to read. This is the element which should contain the child element with the 
    /// <paramref name="elementName"/>.
    /// </param>
    /// <param name="options">The <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>An instance of <typeparamref name="T"/> or <see langword="null"/> if the element was not found.</returns>
    public static T? Get<T>(this XmlElementReader reader, string elementName, XElement element, XmlElementSerializerOptions options) {
      XElement? childElement = element.Elements()
        .Where(e => e.Name.LocalName == elementName)
        .FirstOrDefault();

      if (childElement == null) {
        return default;
      }

      XElement? propertyElement = childElement.GetPropertyElement();

      return propertyElement != null
        ? XmlElementSerializer.Read<T>(propertyElement, options)
        : default;
    }

    /// <summary>
    /// Gets a <see cref="ICollection"/> of read elements from an <see cref="XElement"/> children. This is designed
    /// for reading ISO 19115 elements. Therefore, it will use <see cref="XElementExtensions.GetPropertyElement(XElement)"/> to get the
    /// first child element of the specified elements.
    /// </summary>
    /// <remarks>
    /// Since this method is designed specifically for reading ISO 19115 elements, it is added as an extension 
    /// method to the <see cref="XmlElementReader"/> class, rather than in the class itself.
    /// </remarks>
    /// <typeparam name="TCollection">The collection <see cref="Type"/>.</typeparam>
    /// <param name="reader">The <see cref="XmlElementReader"/> instance.</param>
    /// <param name="elementName">The name of the elements to added to the collection.</param>
    /// <param name="element">
    /// The element to read. This is the element which should contain the child elements with the 
    /// <paramref name="elementName"/>.
    /// </param>
    /// <param name="options">The <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>An instance of <typeparamref name="TCollection"/> containing read elements with the <paramref name="elementName"/>.</returns>
    public static TCollection GetCollection<TCollection>(this XmlElementReader reader, string elementName, XElement element,
      XmlElementSerializerOptions options) where TCollection : IList, new() {
      Type itemType = typeof(TCollection).GenericTypeArguments[0];
      TCollection collection = new();
      foreach (XElement childElement in element.Elements().Where(e => e.Name.LocalName == elementName)) {
        XElement? propertyElement = childElement.GetPropertyElement();
        if (propertyElement == null) {
          continue;
        }

        object item = XmlElementSerializer.Read(itemType, propertyElement, options);
        if (item != null) {
          collection.Add(item);
        }
      }

      return collection;
    }
  }
}
