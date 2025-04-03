using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Maintenance;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Maintenance {
  /// <summary>
  ///   Reads an <see cref="XElement" /> to a <see cref="MD_ScopeDescription_Type" />.
  /// </summary>
  public sealed class MdScopeDescriptionXmlReader : XmlElementReader<MD_ScopeDescription_Type> {
    /// <inheritdoc />
    public override MD_ScopeDescription_Type Read(XElement element, XmlElementSerializerOptions options) {
      XElement? propertyElement = element.GetPropertyElement();
      if (propertyElement == null) {
        throw new InvalidOperationException("The property element is missing.");
      }

      string name = propertyElement.Name.LocalName.Trim().ToLower();
      switch (name) {
        case "attributeinstances":
          throw new NotImplementedException();
        case "attributes":
          throw new NotImplementedException();
        case "dataset":
          throw new NotImplementedException();
        case "featureinstances":
          throw new NotImplementedException();
        case "features":
          throw new NotImplementedException();
        case "other":
          CharacterString? other = XmlElementSerializer.Read<CharacterString>(propertyElement, options);
          return new OtherScopeDescription { Other = other };
        default:
          throw new InvalidOperationException($"The scope description type '{name}' is not supported.");
      }
    }
  }
}
