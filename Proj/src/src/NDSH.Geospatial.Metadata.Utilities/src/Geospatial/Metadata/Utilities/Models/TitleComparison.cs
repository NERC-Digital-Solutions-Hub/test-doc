
#region Imported Namespaces

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.Models {

  /// <summary>
  /// 
  /// </summary>
  [Table("TitleComparisons")]
  [PrimaryKey(nameof(Id))]
  public class TitleComparison {

    #region Public Properties

    /// <summary>
    /// Gets/Sets the id of the metadata title comparison.
    /// </summary>
    public int Id {
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
    public double LevenshteinDistance {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the Hamming distance of the compared titles.
    /// </summary>
    public double HammingDistance {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the Jaccard distance of the compared titles.
    /// </summary>
    public double JaccardDistance {
      get; set;
    }

    #endregion

  }

}
