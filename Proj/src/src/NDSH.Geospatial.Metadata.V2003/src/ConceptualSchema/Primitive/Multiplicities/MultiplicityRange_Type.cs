
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Multiplicities {

  /// <summary>
  /// A component of a multiplicity, consisting of an non-negative
  /// lower bound, and a potentially infinite upper bound.
  /// </summary>
  [Serializable]
  [XmlType("MultiplicityRange", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("MultiplicityRange")]
  public class MultiplicityRange_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MultiplicityRange_Type"/>.
    /// </summary>
    public MultiplicityRange_Type() {
      _upper = new UnlimitedInteger_PropertyType();
      _lower = new Integer_PropertyType();
    }

    #endregion

    #region Public Properties

    private Integer_PropertyType _lower;

    [XmlElement("lower", Order = 0)]
    [JsonProperty("lower", Order = 0)]
    public Integer_PropertyType Lower {
      get => _lower;
      set {
        if (_lower == value) {
          return;
        }
        if (_lower == null || !_lower.Equals(value)) {
          _lower = value;
          OnPropertyChanged();
        }
      }
    }

    private UnlimitedInteger_PropertyType _upper;

    [XmlElement("upper", Order = 1)]
    [JsonProperty("upper", Order = 1)]
    public UnlimitedInteger_PropertyType Upper {
      get => _upper;
      set {
        if (_upper == value) {
          return;
        }
        if (_upper == null || !_upper.Equals(value)) {
          _upper = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
