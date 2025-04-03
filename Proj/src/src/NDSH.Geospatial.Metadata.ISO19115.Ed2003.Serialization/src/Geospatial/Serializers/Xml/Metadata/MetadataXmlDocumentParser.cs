using NDSH.Apps;
using NDSH.Geospatial.Metadata.Common;
using NDSH.Geospatial.Metadata.EntitySet;
using System.Xml;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata {
  /// <summary>
  /// Parses the metadata XML documents.
  /// </summary>
  public sealed class MetadataXmlDocumentParser {
    private const string SearchStatusElementName = "SearchStatus";
    private const string TimestampAttributeName = "timestamp";
    private const string MdMetadataElementName = "MD_Metadata";

    /// <summary>
    ///   Initializes a new instance of the <see cref="MetadataXmlDocumentParser" /> class.
    /// </summary>
    private MetadataXmlDocumentParser() {
    }

    /// <summary>
    ///   A singleton instance of the <see cref="MetadataXmlDocumentParser" />.
    /// </summary>
    public static MetadataXmlDocumentParser Instance {
      get;
    } = new();

    /// <summary>
    ///   Parses the Metadata XML files at the specified paths.
    /// </summary>
    /// <param name="paths">The paths to be XML files.</param>
    /// <returns>An <see cref="IEnumerable{T}" /> of <see cref="MetadataDocument" />.</returns>
    public IEnumerable<MetadataDocument> Parse(string[] paths) {
      foreach (string path in paths) {
        foreach (MetadataDocument document in Parse(path)) {
          yield return document;
        }
      }
    }

    /// <summary>
    ///   Parses the Metadata XML file at the specified path.
    /// </summary>
    /// <param name="path">The path to the XML file.</param>
    /// <returns>An <see cref="IEnumerable{T}" /> of <see cref="MetadataDocument" />.</returns>
    public IEnumerable<MetadataDocument> Parse(string path) {
      ArgumentNullException.ThrowIfNull(path, nameof(path));
      if (!TryGetXDocument(path, out XDocument xmlDocument)) {
        yield break;
      }

      if (xmlDocument.Root == null) {
        Console.WriteLine($"Root element is null in file: {path}");
        yield break;
      }

      XElement searchStatusElement = FindElements(xmlDocument.Root, SearchStatusElementName).First();
      DateTime downloaded = DateTime.Parse(searchStatusElement.GetAttributeByLocalName(TimestampAttributeName)!);
      DateTime updated = DateTime.Now;

      XElement[] startElements = FindElements(xmlDocument.Root, MdMetadataElementName).ToArray();
      for (int i = 0; i < startElements.Length; i++) {
        Console.WriteLine($"[MetadataXmlDocumentParser] Parsing element {i + 1} of {startElements.Length}...");
        yield return ParseMetadataElement(startElements[i], downloaded, updated);
      }
    }

    /// <summary>
    ///   Gets an <see cref="XDocument" /> from the specified path.
    /// </summary>
    /// <param name="path">The path to the XML file.</param>
    /// <param name="xmlDocument">The XML <see cref="XDocument" /></param>
    /// <returns>A <see cref="bool" /> indicating if the XML file was successfully read.</returns>
    private bool TryGetXDocument(string path, out XDocument xmlDocument) {
      xmlDocument = null!;
      try {
        xmlDocument = XDocument.Load(path);
        return true;
      }
      catch (Exception ex) {
        Console.WriteLine($"Failed to load XML file '{path}': {ex.Message}");
        return false;
      }
    }

    /// <summary>
    ///   Finds all elements with the specified name in an XML document.
    /// </summary>
    /// <param name="element">The <see cref="XElement" />.</param>
    /// <param name="elementName">The name of the element to find.</param>
    /// <returns>An <see cref="IEnumerable{T}" /> of <see cref="XElement" />'s with the name.</returns>
    private IEnumerable<XElement> FindElements(XElement element, string elementName) {
      if (element.Name.LocalName.Equals(elementName, StringComparison.InvariantCultureIgnoreCase)) {
        yield return element;
      }

      foreach (XElement childElement in element.Elements()) {
        IEnumerable<XElement> foundElements = FindElements(childElement, elementName);
        foreach (XElement foundElement in foundElements) {
          yield return foundElement;
        }
      }
    }

    /// <summary>
    ///   Parses an <see cref="XElement" /> into an <see cref="MetadataDocument" />.
    /// </summary>
    /// <param name="element">The <see cref="XElement"/> to parse.</param>
    /// <param name="created">The date and time the metadata was created.</param>
    /// <param name="updated">The date and time the metadata was updated.</param>
    private MetadataDocument ParseMetadataElement(XElement element, DateTime created, DateTime updated) {
      return new() {
        Schema = "PLACEHOLDER",
        UniqueIdentifier = Guid.NewGuid(),
        Data = element.ToString(),
        CreateDate = created,
        UpdateDate = updated,
      };
      ;
    }
  }
}
