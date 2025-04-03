using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Citation {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_ResponsibleParty_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class CiResponsiblePartyXmlReader : XmlElementReader<CI_ResponsibleParty_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_ResponsibleParty_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="CI_ResponsibleParty_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="CI_ResponsibleParty_Type"/> instance that represents the XML element.</returns>
    public override CI_ResponsibleParty_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new CI_ResponsibleParty_Type {
        IndividualName = this.Get<CharacterString>("individualName", element, options),
        OrganisationName = this.Get<CharacterString>("organisationName", element, options),
        PositionName = this.Get<CharacterString>("positionName", element, options),
        ContactInfo = this.Get<CI_Contact_Type>("contactInfo", element, options),
        Role = this.Get<CI_RoleCode_CodeList>("role", element, options)
      };
    }
  }
}
