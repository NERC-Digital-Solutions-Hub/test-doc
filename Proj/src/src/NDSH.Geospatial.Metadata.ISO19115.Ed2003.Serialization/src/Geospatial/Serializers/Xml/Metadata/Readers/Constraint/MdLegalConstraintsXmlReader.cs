using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Constraint;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Constraint {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_LegalConstraints_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdLegalConstraintsXmlReader : XmlElementReader<MD_LegalConstraints_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_LegalConstraints_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_LegalConstraints_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_LegalConstraints_Type"/> instance that represents the XML element.</returns>
    public override MD_LegalConstraints_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_LegalConstraints_Type {
        AccessConstraints = this.GetCollection<ObservableCollection<MD_RestrictionCode_CodeList>>("accessConstraints", element, options),
        UseConstraints = this.GetCollection<ObservableCollection<MD_RestrictionCode_CodeList>>("useConstraints", element, options),
        OtherConstraints = this.GetCollection<ObservableCollection<CharacterString>>("otherConstraints", element, options)
      };
    }
  }
}
