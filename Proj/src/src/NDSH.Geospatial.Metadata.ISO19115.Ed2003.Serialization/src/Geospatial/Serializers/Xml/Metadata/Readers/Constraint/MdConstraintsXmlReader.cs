using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Constraint;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Constraint {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Constraints_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdConstraintsXmlReader : XmlElementReader<MD_Constraints_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_Constraints_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_Constraints_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_Constraints_Type"/> instance that represents the XML element.</returns>
    public override MD_Constraints_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_Constraints_Type { UseLimitation = this.GetCollection<ObservableCollection<CharacterString>>("useLimitation", element, options) };
    }
  }
}
