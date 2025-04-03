
#region Imported Namespaces

using NDSH.Geospatial.Metadata.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Serializers.Tests.GeoNetworkGmd2005 {

  /// <summary>
  /// The Serializer serializes Geospatial Metadata objects according to GeoNetwork XML metadata.
  /// </summary>
  internal static class Serializer {

    /// <summary>
    /// Serializes a specified object in XML.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to serialize.</param>
    /// <returns>An XML <see cref="string"/> of the serialized object.</returns>
    public static string SerializeXml(object obj) {

      return SerializeXml(obj, true, "  ");

    }

    /// <summary>
    /// Serializes a specified object in XML.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to serialize.</param>
    /// <param name="indent">
    /// Indicates whether the XML string is indented or not.
    /// </param>
    /// <param name="indentChars">
    /// The characters used for indentation.
    /// </param>
    /// <returns></returns>
    public static string SerializeXml(object obj, bool indent = true, string indentChars = "  ") {

      StreamReader streamReader = null;
      MemoryStream memoryStream = null;
      
      try {

        memoryStream = new MemoryStream();

        XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();

        xmlWriterSettings.Indent = indent;
        xmlWriterSettings.IndentChars = indentChars;

        XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);

        GeoNetworkGmd2005Serializer xmlSerializer = new GeoNetworkGmd2005Serializer(obj.GetType());
        //XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
        xmlSerializer.Serialize(xmlWriter, obj);
        
        memoryStream.Seek(0, SeekOrigin.Begin);
        streamReader = new StreamReader(memoryStream);

        return streamReader.ReadToEnd();

      }
      finally {

        if (streamReader != null) {
          streamReader.Dispose();
        }
        if (memoryStream != null) {
          memoryStream.Dispose();
        }

      }

    }

  }

}
