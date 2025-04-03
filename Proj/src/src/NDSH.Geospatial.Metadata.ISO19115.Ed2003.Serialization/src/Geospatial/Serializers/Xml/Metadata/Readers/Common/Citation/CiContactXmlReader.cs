using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Citation {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Contact_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class CiContactXmlReader : XmlElementReader<CI_Contact_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Contact_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="CI_Contact_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="CI_Contact_Type"/> instance that represents the XML element.</returns>
    public override CI_Contact_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new CI_Contact_Type {
        Phone = this.Get<CI_Telephone_Type>("phone", element, options),
        Address = this.Get<CI_Address_Type>("address", element, options),
        OnlineResource = this.Get<CI_OnlineResource_Type>("onlineResource", element, options),
        HoursOfService = this.Get<CharacterString>("hoursOfService", element, options),
        ContactInstructions = this.Get<CharacterString>("contactInstructions", element, options)
      };
    }
  }
}
