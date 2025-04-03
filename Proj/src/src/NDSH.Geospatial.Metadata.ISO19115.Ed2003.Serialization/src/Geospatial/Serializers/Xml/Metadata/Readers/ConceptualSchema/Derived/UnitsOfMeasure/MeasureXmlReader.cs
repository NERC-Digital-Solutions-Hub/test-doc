using NDSH.Geospatial.Gml.Measures;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.ConceptualSchema.Derived.UnitsOfMeasure {
  /// <summary>
  ///   Reads an <see cref="XElement" /> to a <see cref="MeasureType" />.
  /// </summary>
  public sealed class MeasureXmlReader : XmlElementReader<MeasureType> {
    /// <inheritdoc />
    public override MeasureType Read(XElement element, XmlElementSerializerOptions options) {
      string? unitOfMeasure = element.GetAttributeByLocalName("uom");
      double value = double.TryParse(element.Value, out double @double) ? @double : 0;
      return new MeasureType { UnitOfMeasure = unitOfMeasure, Value = value };
    }
  }
}
