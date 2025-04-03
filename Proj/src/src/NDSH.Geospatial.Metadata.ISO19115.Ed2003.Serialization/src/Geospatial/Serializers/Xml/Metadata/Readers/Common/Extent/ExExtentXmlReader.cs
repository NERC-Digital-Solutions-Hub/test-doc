using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Extent;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Extent {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="EX_Extent_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class ExExtentXmlReader : XmlElementReader<EX_Extent_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="EX_Extent_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="EX_Extent_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="EX_Extent_Type"/> instance that represents the XML element.</returns>
    public override EX_Extent_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new EX_Extent_Type {
        Description = this.Get<CharacterString>("description", element, options),
        GeographicElement = this.GetCollection<ObservableCollection<AbstractEX_GeographicExtent_Type>>("geographicElement", element, options)
      };
    }
  }
}
