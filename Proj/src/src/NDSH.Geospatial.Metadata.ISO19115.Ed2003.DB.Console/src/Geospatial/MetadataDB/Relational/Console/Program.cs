
#region Imported Namespaces

using NDSH.Geospatial.Metadata.EntitySet;
using NDSH.Geospatial.MetadataDB.Relational;
using NDSH.Geospatial.Serializers.Xml.Metadata;

#endregion

namespace NDSH.Geospatial.MetadataDB.Relational.Console {

  /// <summary>
  /// The program class. This is used for experimenting with the metadata database.
  /// </summary>
  internal class Program {

    /// <summary>
    /// The entry point of the program.
    /// </summary>
    /// <param name="args">The program arguments.</param>
    private static async Task Main(string[] args) {
      // string xmlDirectory = @"C:\NDSH\GitHub\nerc-digital-solutons-hub\nerc-data-centres\Metadata\NERC\2.0.2\GMD";
      //string outputJsonDirectory = @"C:\NDSH\GitHub\nerc-digital-solutons-hub\nerc-data-centres\Metadata\NERC\2.0.2\GMD-JSON";
      string xmlDirectory = @"C:\Users\j04413bc\OneDrive - The University of Manchester\Desktop\temp";
      //string xmlPathTxt = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "xmlPath.txt");
      //string xmlDirectory = File.ReadAllText(xmlPathTxt);
      string[] xmlFilePaths = Directory.GetFiles(xmlDirectory, "*.xml", SearchOption.AllDirectories);
      //for (int i = 0; i < xmlFilePaths.Length; i++) {
      //  string xmlFilePath = xmlFilePaths[i];
      //  Console.WriteLine($"Processing {i + 1} of {xmlFilePaths.Length}: {xmlFilePath}");
      //  XmlToJsonConverter.Convert(xmlFilePath, outputJsonDirectory);
      //}
      //MetadataDatabaseContext context = new();
      //await context.ResetDatabaseAsync();

      //IEnumerable<MD_Metadata_Type> metadata = MetadataXmlParser.Instance.Parse(xmlFilePaths);
      //await MetadataXmlInserter.Instance.InsertMetadataAsync(metadata);

      IEnumerable<MetadataDocument> documents = MetadataXmlDocumentParser.Instance.Parse(xmlFilePaths);
      await MetadataXmlInserter.Instance.InsertDocumentsAsync(documents);
    }

  }

}
