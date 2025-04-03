using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Metadata.Citation;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Citation {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Date_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class CiDateXmlReader : XmlElementReader<CI_Date_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Date_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="CI_Date_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="CI_Date_Type"/> instance that represents the XML element.</returns>
    public override CI_Date_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new CI_Date_Type {
        Date = this.Get<DateDbEntity>("date", element, options),
        DateType = this.Get<CI_DateTypeCode_CodeList>("dateType", element, options)
      };
    }
  }
}
