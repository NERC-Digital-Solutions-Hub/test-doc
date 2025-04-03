
#region Imported Namespaces

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.Models {

  /// <summary>
  /// 
  /// </summary>
  [Table("LevenshteinTitleStatistics")]
  public sealed class LevenshteinTitleStatistics {

    #region Public Properties

    /// <summary>
    /// Gets/Sets the primary key.
    /// </summary>
    public int Id {
      get; set;
    }

    private int _recordId;

    /// <summary>
    /// Gets/Sets the titles record id.
    /// </summary>
    public int RecordId {
      get {
        return _recordId;
      }
      set {
        _recordId = value;
      }
    }

    private int _min;

    /// <summary>
    /// Gets/Sets the minimum Levenshtein distance for this title.
    /// </summary>
    public int Min {
      get {
        return _min;
      }
      set {
        _min = value;
      }
    }

    private int _max;

    /// <summary>
    /// Gets/Sets the maximum Levenshtein distance for this title.
    /// </summary>
    public int Max {
      get {
        return _max;
      }
      set {
        _max = value;
      }
    }

    private double _mean;

    /// <summary>
    /// Gets/Sets the mean of the Levenshtein distance for this title.
    /// </summary>
    public double Mean {
      get {
        return _mean;
      }
      set {
        _mean = value;
      }
    }

    private double _median;

    /// <summary>
    /// Gets/Sets the median of the Levenshtein distances for this title.
    /// </summary>
    public double Median {
      get {
        return _median;
      }
      set {
        _median = value;
      }
    }

    private double _variance;

    /// <summary>
    /// Gets/Sets the variance of the Levenshtein distances for this title.
    /// </summary>
    public double Variance {
      get {
        return _variance;
      }
      set {
        _variance = value;
      }
    }

    private double _stDev;

    /// <summary>
    /// Gets/Sets the standard deviation of the Levenshtein distances for this title.
    /// </summary>
    public double StDev {
      get {
        return _stDev;
      }
      set {
        _stDev = value;
      }
    }

    private double _kurtosis;

    /// <summary>
    /// 
    /// </summary>
    public double Kurtosis {
      get {
        return _kurtosis;
      }
      set {
        _kurtosis = value;
      }
    }

    private double _skewness;

    /// <summary>
    /// 
    /// </summary>
    public double Skewness {
      get {
        return _skewness;
      }
      set {
        _skewness = value;
      }
    }

    #endregion

  }

}
