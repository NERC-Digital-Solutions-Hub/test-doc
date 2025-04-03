using NDSH.Geospatial.Metadata.Extent;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Extent {
  /// <summary>
  ///   Reads an <see cref="XElement" />to a <see cref="EX_GeographicBoundingBox_Type" />.
  /// </summary>
  public sealed class ExGeographicBoundingBoxXmlReader : XmlElementReader<EX_GeographicBoundingBox_Type> {
    /// <inheritdoc />
    public override EX_GeographicBoundingBox_Type Read(XElement element, XmlElementSerializerOptions options) {
      decimal westBoundLongitude = 0;
      decimal eastBoundLongitude = 0;
      decimal southBoundLatitude = 0;
      decimal northBoundLatitude = 0;

      foreach (XElement childElement in element.Elements()) {
        string elementName = childElement.Name.LocalName;
        switch (elementName) {
          case "westBoundLongitude":
            westBoundLongitude = decimal.TryParse(childElement?.Value, out decimal westValue) ? westValue : 0;
            break;
          case "eastBoundLongitude":
            eastBoundLongitude = decimal.TryParse(childElement?.Value, out decimal eastValue) ? eastValue : 0;
            break;
          case "southBoundLatitude":
            southBoundLatitude = decimal.TryParse(childElement?.Value, out decimal southValue) ? southValue : 0;
            break;
          case "northBoundLatitude":
            northBoundLatitude = decimal.TryParse(childElement?.Value, out decimal northValue) ? northValue : 0;
            break;
        }
      }

      return new EX_GeographicBoundingBox_Type {
        WestBoundLongitude = westBoundLongitude,
        EastBoundLongitude = eastBoundLongitude,
        SouthBoundLatitude = southBoundLatitude,
        NorthBoundLatitude = northBoundLatitude
      };
    }
  }
}
