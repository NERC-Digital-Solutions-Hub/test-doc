using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Service.Metadata;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Service.Metadata {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="SV_CoupledResource_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class SvCoupledResourceXmlReader : XmlElementReader<SV_CoupledResource_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="SV_CoupledResource_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="SV_CoupledResource_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="SV_CoupledResource_Type"/> instance that represents the XML element.</returns>
    public override SV_CoupledResource_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new SV_CoupledResource_Type {
        OperationName = this.Get<CharacterString>("operationName", element, options),
        Identifier = this.Get<CharacterString>("identifier", element, options)
      };
    }
  }
}
