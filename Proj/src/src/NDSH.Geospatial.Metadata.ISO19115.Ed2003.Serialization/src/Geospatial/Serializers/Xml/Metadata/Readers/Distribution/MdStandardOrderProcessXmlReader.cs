using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Distribution;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Distribution {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_StandardOrderProcess_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class MdStandardOrderProcessXmlReader : XmlElementReader<MD_StandardOrderProcess_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="MD_StandardOrderProcess_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="MD_StandardOrderProcess_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="MD_StandardOrderProcess_Type"/> instance that represents the XML element.</returns>
    /// <example>
    /// The following example demonstrates how to use the <see cref="MdStandardOrderProcessXmlReader"/>:
    /// <code language="csharp">
    /// XmlElementSerializerOptions options = new();
    /// options.Readers = [ new MdStandardOrderProcessXmlReader() ];
    /// MD_StandardOrderProcess_Type standardOrderProcess = XmlElementSerializer.Read&lt;MD_StandardOrderProcess_Type&gt;(element, options);
    /// </code>
    /// </example>
    public override MD_StandardOrderProcess_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new MD_StandardOrderProcess_Type {
        Fees = this.Get<CharacterString>("fees", element, options),
        PlannedAvailableDateTime = this.Get<DateTimeDbEntity>("plannedAvailableDateTime", element, options),
        OrderingInstructions = this.Get<CharacterString>("orderingInstructions", element, options),
        Turnaround = this.Get<CharacterString>("turnaround", element, options)
      };
    }
  }
}
