using NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.ConceptualSchema.Derived.UnitsOfMeasure {
  /// <summary>
  ///   Reads an <see cref="XElement" /> to a <see cref="Distance_PropertyType" />.
  /// </summary>
  public sealed class DistanceXmlReader : XmlElementReader<Distance_PropertyType> {
    /// <inheritdoc />
    public override Distance_PropertyType Read(XElement element, XmlElementSerializerOptions options) {
      string? unitOfMeasure = element.GetAttributeByLocalName("uom");
      double value = double.TryParse(element.Value, out double @double) ? @double : 0;
      return new Distance_PropertyType { UnitOfMeasure = unitOfMeasure, Value = value };
    }
  }
}
