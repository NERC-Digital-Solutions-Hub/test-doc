
#region Imported Namespaces

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.Models {

  /// <summary>
  /// The Levenshtein titles comparisons.
  /// </summary>
  [Table("LevenshteinTitleComparisons")]
  public sealed class LevenshteinTitleComparison {

    #region Public Properties

    /// <summary>
    /// Gets/Sets the primary key.
    /// </summary>
    public int Id {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the batch id of the comparisons.
    /// </summary>
    public int BatchId {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the record id of the first title.
    /// </summary>
    public int RecordId1 {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the record id of the second title.
    /// </summary>
    public int RecordId2 {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the Levenshtein distance of the compared titles.
    /// </summary>
    public int LevenshteinDistance {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the percentile in which this Levenshtein distance falls
    /// in the set of all Levenshtein distances for this title.
    /// </summary>
    public int Percentile {
      get; set;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Creates an <see cref="LevenshteinTitleComparison"/>.
    /// </summary>
    /// <param name="record">
    /// A <see cref="string"/> with the record of two titles and their Levenshtein distance.
    /// </param>
    /// <returns>A <see cref="LevenshteinTitleComparison"/> instance.</returns>
    public static LevenshteinTitleComparison Create(string record) {

      if (String.IsNullOrEmpty(record)) {
        throw new ArgumentNullException("The Levenshtein record is null.");
      }

      string[] values = record.Split(',');

      LevenshteinTitleComparison comparison = new LevenshteinTitleComparison();
      comparison.BatchId = Convert.ToInt32(values[0]);
      comparison.RecordId1 = Convert.ToInt32(values[1]);
      comparison.RecordId2 = Convert.ToInt32(values[2]);
      comparison.LevenshteinDistance = Convert.ToInt32(values[3]);
      comparison.Percentile = -1;

      return comparison;

    }

    /// <summary>
    /// Creates a string representation of the <see cref="LevenshteinTitleComparison"/>.
    /// </summary>
    /// <remarks>
    /// The string has the following form: <br></br>
    /// <see cref="Id"/>: {<see cref="Id"/>}, <see cref="BatchId"/>: {<see cref="BatchId"/>}, <see cref="RecordId1"/>: {<see cref="RecordId1"/>}, <see cref="RecordId2"/>: {<see cref="RecordId2"/>}, <see cref="Percentile"/>: {<see cref="Percentile"/>}
    /// </remarks>
    /// <returns>
    /// A <see cref="string"/> of the <see cref="LevenshteinTitleComparison"/> representation.
    /// </returns>
    public override string ToString() {

      StringBuilder sb = new StringBuilder();

      sb.Append(nameof(this.Id));
      sb.Append(": ");
      sb.Append(this.Id);
      sb.Append(", ");

      sb.Append(nameof(this.BatchId));
      sb.Append(": ");
      sb.Append(this.BatchId);
      sb.Append(", ");

      sb.Append(nameof(this.RecordId1));
      sb.Append(": ");
      sb.Append(this.RecordId1);
      sb.Append(", ");

      sb.Append(nameof(this.RecordId2));
      sb.Append(": ");
      sb.Append(this.RecordId2);
      sb.Append(", ");

      sb.Append(nameof(this.LevenshteinDistance));
      sb.Append(": ");
      sb.Append(this.LevenshteinDistance);
      sb.Append(", ");

      sb.Append(nameof(this.Percentile));
      sb.Append(": ");
      sb.Append(this.Percentile);

      return sb.ToString();

    }

    /// <summary>
    /// Creates a string representation of the <see cref="LevenshteinTitleComparison"/>.
    /// </summary>
    /// <remarks>
    /// The string has the following form: <br></br>
    /// <see cref="Id"/>: {<see cref="Id"/>}, <see cref="BatchId"/>: {<see cref="BatchId"/>}, <see cref="RecordId1"/>: {<see cref="RecordId1"/>}, <see cref="RecordId2"/>: {<see cref="RecordId2"/>}, <see cref="Percentile"/>: {<see cref="Percentile"/>}
    /// </remarks>
    /// <param name="stringBuilder">
    /// The <see cref="StringBuilder"/> used to generate the string.
    /// </param>
    /// <returns>
    /// A <see cref="string"/> of the <see cref="LevenshteinTitleComparison"/> representation.
    /// </returns>
    public string ToString(StringBuilder stringBuilder) {

      stringBuilder.Clear();

      stringBuilder.Append(nameof(this.Id));
      stringBuilder.Append(": ");
      stringBuilder.Append(this.Id);
      stringBuilder.Append(", ");

      stringBuilder.Append(nameof(this.BatchId));
      stringBuilder.Append(": ");
      stringBuilder.Append(this.BatchId);
      stringBuilder.Append(", ");

      stringBuilder.Append(nameof(this.RecordId1));
      stringBuilder.Append(": ");
      stringBuilder.Append(this.RecordId1);
      stringBuilder.Append(", ");

      stringBuilder.Append(nameof(this.RecordId2));
      stringBuilder.Append(": ");
      stringBuilder.Append(this.RecordId2);
      stringBuilder.Append(", ");

      stringBuilder.Append(nameof(this.LevenshteinDistance));
      stringBuilder.Append(": ");
      stringBuilder.Append(this.LevenshteinDistance);
      stringBuilder.Append(", ");

      stringBuilder.Append(nameof(this.Percentile));
      stringBuilder.Append(": ");
      stringBuilder.Append(this.Percentile);

      return stringBuilder.ToString();

    }

    /// <summary>
    /// Creates a string comma separated record of the <see cref="LevenshteinTitleComparison"/>.
    /// </summary>
    /// <returns>
    /// A comma separated <see cref="string"/> representing the <see cref="LevenshteinTitleComparison"/>.
    /// </returns>
    public string ToCsvRecord() {

      StringBuilder sb = new StringBuilder();

      sb.Append(this.Id);
      sb.Append(", ");
      sb.Append(this.BatchId);
      sb.Append(", ");
      sb.Append(this.RecordId1);
      sb.Append(", ");
      sb.Append(this.RecordId2);
      sb.Append(", ");
      sb.Append(this.LevenshteinDistance);
      sb.Append(", ");
      sb.Append(this.Percentile);

      return sb.ToString();

    }

    /// <summary>
    /// Creates a string comma separated record of the <see cref="LevenshteinTitleComparison"/>.
    /// </summary>
    /// <param name="stringBuilder">
    /// The <see cref="StringBuilder"/> used to generate the string.
    /// </param>
    /// <returns>
    /// A comma separated <see cref="string"/> representing the <see cref="LevenshteinTitleComparison"/>.
    /// </returns>
    public string ToCsvRecord(StringBuilder stringBuilder) {

      stringBuilder.Clear();

      stringBuilder.Append(this.Id);
      stringBuilder.Append(", ");
      stringBuilder.Append(this.BatchId);
      stringBuilder.Append(", ");
      stringBuilder.Append(this.RecordId1);
      stringBuilder.Append(", ");
      stringBuilder.Append(this.RecordId2);
      stringBuilder.Append(", ");
      stringBuilder.Append(this.LevenshteinDistance);
      stringBuilder.Append(", ");
      stringBuilder.Append(this.Percentile);

      return stringBuilder.ToString();

    }

    #endregion

  }

}
