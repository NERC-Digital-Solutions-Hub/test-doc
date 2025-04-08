
using NDSH.Geospatial.Metadata;
using NDSH.Geospatial.Metadata.EntitySet;
using NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata {
  /// <summary>
  ///   Parses metadata XML.
  /// </summary>
  public class MetadataXmlParser {

    public static XmlElementSerializerOptions Options => _options.Value;

    private static readonly Lazy<XmlElementSerializerOptions> _options = new Lazy<XmlElementSerializerOptions>(() => {
      XmlElementSerializerOptions options = new();
      AddXmlReaders(options);
      return options;
    });

    private const string MdMetadataElementName = "MD_Metadata";

    private readonly List<MD_Metadata_Type> _metadata = new();

    /// <summary>
    ///   Initializes a new instance of the <see cref="MetadataXmlParser" /> class.
    /// </summary>
    private MetadataXmlParser() {
    }

    /// <summary>
    ///   A singleton instance of the <see cref="MetadataXmlParser" />.
    /// </summary>
    public static MetadataXmlParser Instance {
      get;
    } = new();

    /// <summary>
    ///   Parses the Metadata XML files at the specified paths.
    /// </summary>
    /// <param name="paths">The paths to be XML files.</param>
    /// <returns>An <see cref="IEnumerable{T}" /> of <see cref="MD_Metadata_Type" /> instances.</returns>
    public IEnumerable<MD_Metadata_Type> Parse(string[] paths) {
      foreach (string path in paths) {
        Parse(path);
      }

      return _metadata;
    }

    /// <summary>
    ///   Parses the Metadata XML file at the specified path.
    /// </summary>
    /// <param name="path">The path to the XML file.</param>
    /// <returns>An <see cref="IEnumerable{T}" /> of <see cref="MD_Metadata_Type" /> instances.</returns>
    public IEnumerable<MD_Metadata_Type> Parse(string path) {
      ArgumentNullException.ThrowIfNull(path, nameof(path));
      if (!TryGetXDocument(path, out XDocument xmlDocument)) {
        return Enumerable.Empty<MD_Metadata_Type>();
      }

      if (xmlDocument.Root == null) {
        Console.WriteLine($"Root element is null in file: {path}");
        return Enumerable.Empty<MD_Metadata_Type>();
      }

      XElement[] startElements = FindElements(xmlDocument.Root, MdMetadataElementName).ToArray();
      foreach (XElement element in startElements) {
        MD_Metadata_Type? metadata = XmlElementSerializer.Read<MD_Metadata_Type>(element, _options.Value);
        _metadata.Add(metadata);
      }

      return _metadata;
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
    ///   Adds the XML readers to the <see cref="XmlElementSerializerOptions" />.
    /// </summary>
    /// <param name="options">The <see cref="XmlElementSerializerOptions"/> instance.</param>
    private static void AddXmlReaders(XmlElementSerializerOptions options) {
      IEnumerable<Type> readerTypes = AppDomain.CurrentDomain.GetAssemblies()
        .SelectMany(assembly => assembly.GetTypes())
        .Where(type => typeof(XmlElementReader).IsAssignableFrom(type)
                       && !type.IsAbstract
                       && !type.ContainsGenericParameters);

      XmlElementReader[] readers = readerTypes
        .Select(type => (XmlElementReader)Activator.CreateInstance(type)!)
        .Union(GetCodeListValueReaders())
        .ToArray();

      options.Readers = readers;
    }

    /// <summary>
    ///   Gets the <see cref="XmlElementReader"/> instances for the <see cref="CodeListValue_Type"/> types.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}" /> of <see cref="XmlElementReader" /> instances.</returns>
    private static IEnumerable<XmlElementReader> GetCodeListValueReaders() {
      IEnumerable<Type> codeListValueTypes = AppDomain.CurrentDomain.GetAssemblies()
        .SelectMany(assembly => assembly.GetTypes())
        .Where(type => typeof(CodeListValue_Type).IsAssignableFrom(type)
                       && !type.IsAbstract
                       && type.GetConstructor(Type.EmptyTypes) != null);

      foreach (Type type in codeListValueTypes) {
        Type readerType = typeof(CodeListValueXmlReader<>).MakeGenericType(type);
        yield return (XmlElementReader)Activator.CreateInstance(readerType)!;
      }
    }
  }
}
