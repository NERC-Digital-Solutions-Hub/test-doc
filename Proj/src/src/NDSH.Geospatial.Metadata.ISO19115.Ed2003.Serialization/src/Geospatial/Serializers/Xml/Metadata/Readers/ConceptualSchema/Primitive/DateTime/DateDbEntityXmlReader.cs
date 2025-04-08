using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using System.Text.RegularExpressions;
using System.Xml.Linq;


namespace NDSH.Geospatial.Serializers.Xml.Metadata.Readers.ConceptualSchema.Primitive.DateTime {
  /// <summary>
  ///   Reads an <see cref="XElement" />to a <see cref="DateDbEntity" />.
  /// </summary>
  public sealed class DateDbEntityXmlReader : XmlElementReader<DateDbEntity> {
    private static readonly Regex YearOnlyRegex = new(@"^\d{4}$");
    private static readonly Regex YearMonthRegex = new(@"^\d{4}[-/]\d{2}$");
    private static readonly Regex DayMonthYearRegex = new(@"^\d{2}[-/]\d{2}[-/]\d{4}$");
    private static readonly Regex YearMonthDayRegex = new(@"^\d{4}[-/]\d{2}[-/]\d{2}$");

    /// <inheritdoc />
    public override DateDbEntity Read(XElement element, XmlElementSerializerOptions options) {
      string value = element.Value.Trim();

      return ParseDateDbEntity(value);
    }

    /// <summary>
    ///   Parses a date <see cref="string" /> into a <see cref="DateDbEntity" />.
    /// </summary>
    /// <param name="value">The date.</param>
    /// <returns>A parsed <see cref="DateDbEntity" />.</returns>
    /// <exception cref="FormatException">Thrown if the <see cref="string" /> does not fit into the expected format.</exception>
    private DateDbEntity ParseDateDbEntity(string value) {
      if (YearOnlyRegex.IsMatch(value)) {
        int year = int.Parse(value);
        return new DateDbEntity { DateOrDateTime = new System.DateTime(year, 1, 1), DateVariant = DateVariant.Year };
      }

      if (YearMonthRegex.IsMatch(value)) {
        char sep = value.Contains('-') ? '-' : '/';
        string[] parts = value.Split(sep);
        int year = int.Parse(parts[0]);
        int month = int.Parse(parts[1]);
        return new DateDbEntity { DateOrDateTime = new System.DateTime(year, month, 1), DateVariant = DateVariant.YearMonth };
      }

      if (DayMonthYearRegex.IsMatch(value)) {
        char sep = value.Contains('-') ? '-' : '/';
        string[] parts = value.Split(sep);
        int day = int.Parse(parts[0]);
        int month = int.Parse(parts[1]);
        int year = int.Parse(parts[2]);
        return new DateDbEntity { DateOrDateTime = new System.DateTime(year, month, day), DateVariant = DateVariant.FullDate };
      }

      if (YearMonthDayRegex.IsMatch(value)) {
        char sep = value.Contains('-') ? '-' : '/';
        string[] parts = value.Split(sep);
        int year = int.Parse(parts[0]);
        int month = int.Parse(parts[1]);
        int day = int.Parse(parts[2]);

        return new DateDbEntity { DateOrDateTime = new System.DateTime(year, month, day), DateVariant = DateVariant.FullDate };
      }

      if (System.DateTime.TryParse(value, out System.DateTime dateTime)) {
        return new DateDbEntity { DateOrDateTime = dateTime, DateVariant = DateVariant.DateAndTime };
      }

      return new DateDbEntity { DateOrDateTime = null, DateVariant = DateVariant.FullDate };
    }
  }
}
