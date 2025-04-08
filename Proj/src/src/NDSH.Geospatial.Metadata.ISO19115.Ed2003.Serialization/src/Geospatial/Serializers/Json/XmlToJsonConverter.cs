using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Json {
  /// <summary>
  /// Converts the XML metadata to JSON.
  /// </summary>
  public static class XmlToJsonConverter {

    /// <summary>
    /// Converts the XML metadata to JSON.
    /// </summary>
    /// <param name="document">The document with the XML metadata.</param>
    /// <returns>The converted JSON.</returns>
    public static string Convert(XDocument document) {
      return JsonConvert.SerializeXNode(document);
    }

    /// <summary>
    /// Converts the XML metadata to JSON.
    /// </summary>
    /// <param name="xmlFilePath">The path to an XML file.</param>
    /// <param name="outputDirectoryPath">The path to the output directory.</param>
    public static void Convert(string xmlFilePath, string outputDirectoryPath) {
      if (!File.Exists(xmlFilePath)) {
        throw new FileNotFoundException("The XML file does not exist.", xmlFilePath);
      }

      if (!Directory.Exists(outputDirectoryPath)) {
        Directory.CreateDirectory(outputDirectoryPath);
      }

      XDocument xmlDocument = XDocument.Load(xmlFilePath);
      string json = JsonConvert.SerializeXNode(xmlDocument);
      string jsonFilePath = Path.Combine(outputDirectoryPath, GetJsonFileName(xmlFilePath));
      File.WriteAllText(jsonFilePath, json);
    }

    /// <summary>
    /// Gets the JSON file name from the XML file path.
    /// </summary>
    /// <param name="xmlFilePath">The path to the XML file.</param>
    /// <returns>The JSON file name.</returns>
    private static string GetJsonFileName(string xmlFilePath) {
      string fileName = Path.GetFileNameWithoutExtension(xmlFilePath);
      return $"{fileName}.json";
    }
  }
}