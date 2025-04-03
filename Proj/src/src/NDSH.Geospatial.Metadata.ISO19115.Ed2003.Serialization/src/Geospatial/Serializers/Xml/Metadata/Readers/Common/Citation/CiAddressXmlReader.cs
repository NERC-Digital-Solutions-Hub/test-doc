using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Citation {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Address_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class CiAddressXmlReader : XmlElementReader<CI_Address_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Address_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="CI_Address_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="CI_Address_Type"/> instance that represents the XML element.</returns>
    public override CI_Address_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new CI_Address_Type {
        DeliveryPoint = this.GetCollection<ObservableCollection<CharacterString>>("deliveryPoint", element, options),
        City = this.Get<CharacterString>("city", element, options),
        AdministrativeArea = this.Get<CharacterString>("administrativeArea", element, options),
        PostalCode = this.Get<CharacterString>("postalCode", element, options),
        Country = this.Get<CharacterString>("country", element, options),
        ElectronicMailAddress = this.GetCollection<ObservableCollection<CharacterString>>("electronicMailAddress", element, options)
      };
    }
  }
}
