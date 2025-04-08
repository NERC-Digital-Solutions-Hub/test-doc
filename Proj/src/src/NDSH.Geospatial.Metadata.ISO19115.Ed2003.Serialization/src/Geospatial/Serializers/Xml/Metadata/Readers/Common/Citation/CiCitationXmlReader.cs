using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.ReferenceSystem;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.Common.Citation {
  /// <summary>
  /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Citation_Type"/>.
  /// </summary>
  /// <seealso cref="XmlElementReader{T}"/>
  public sealed class CiCitationXmlReader : XmlElementReader<CI_Citation_Type> {
    /// <summary>
    /// Reads an <see cref="XElement"/> and converts it to a <see cref="CI_Citation_Type"/>.
    /// </summary>
    /// <param name="element">The XML element containing the <see cref="CI_Citation_Type"/> information.</param>
    /// <param name="options">A <see cref="XmlElementSerializerOptions"/> instance.</param>
    /// <returns>A <see cref="CI_Citation_Type"/> instance that represents the XML element.</returns>
    public override CI_Citation_Type Read(XElement element, XmlElementSerializerOptions options) {
      return new CI_Citation_Type {
        Title = this.Get<CharacterString>("title", element, options),
        AlternateTitle = this.GetCollection<ObservableCollection<CharacterString>>("alternateTitle", element, options),
        Date = this.GetCollection<ObservableCollection<CI_Date_Type>>("date", element, options),
        Edition = this.Get<CharacterString>("edition", element, options),
        EditionDate = this.Get<DateDbEntity>("editionDate", element, options),
        Identifier = this.GetCollection<ObservableCollection<MD_Identifier_Type>>("identifier", element, options),
        CitedResponsibleParty = this.GetCollection<ObservableCollection<CI_ResponsibleParty_Type>>("citedResponsibleParty", element, options),
        PresentationForm = this.GetCollection<ObservableCollection<CI_PresentationFormCode_CodeList>>("presentationForm", element, options),
        Series = this.Get<CI_Series_Type>("series", element, options),
        OtherCitationDetails = this.Get<CharacterString>("otherCitationDetails", element, options),
        CollectiveTitle = this.Get<CharacterString>("collectiveTitle", element, options),
        ISBN = this.Get<CharacterString>("isbn", element, options),
        ISSN = this.Get<CharacterString>("issn", element, options)
      };
    }
  }
}
