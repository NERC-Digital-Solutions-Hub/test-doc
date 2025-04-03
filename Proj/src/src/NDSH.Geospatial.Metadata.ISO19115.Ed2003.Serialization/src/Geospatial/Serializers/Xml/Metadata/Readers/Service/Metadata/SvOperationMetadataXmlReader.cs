using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Service.Metadata;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Service.Metadata {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="SV_OperationMetadata_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class SvOperationMetadataXmlReader : XmlElementReader<SV_OperationMetadata_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="SV_OperationMetadata_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="SV_OperationMetadata_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="SV_OperationMetadata_Type"/> instance that represents the XML element.</returns>
    public override SV_OperationMetadata_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new SV_OperationMetadata_Type {
        OperationName = this.Get<CharacterString>("operationName", element, options),
        DCP = this.GetCollection<ObservableCollection<DCPList_CodeList>>("DCP", element, options),
        OperationDescription = this.Get<CharacterString>("operationDescription", element, options),
        InvocationName = this.Get<CharacterString>("invocationName", element, options),
        Parameters = this.GetCollection<ObservableCollection<SV_Parameter_Type>>("parameters", element, options),
        ConnectPoint = this.GetCollection<ObservableCollection<CI_OnlineResource_Type>>("connectPoint", element, options),
        DependsOn = this.GetCollection<ObservableCollection<SV_OperationMetadata_Type>>("dependsOn", element, options)
      };
    }
  }
}
