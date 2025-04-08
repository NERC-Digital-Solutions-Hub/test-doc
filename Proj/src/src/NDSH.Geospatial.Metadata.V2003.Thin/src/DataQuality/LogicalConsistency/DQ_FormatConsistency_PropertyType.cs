
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:21, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.LogicalConsistency {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_FormatConsistency_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_FormatConsistency_PropertyType")]
  public class DQ_FormatConsistency_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_FormatConsistency_PropertyType"/>.
    /// </summary>
    public DQ_FormatConsistency_PropertyType() {
      _dq_FormatConsistency  = default; //  new DQ_FormatConsistency_Type();
    }

    #endregion

    #region Public Properties

    private DQ_FormatConsistency_Type _dq_FormatConsistency;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_FormatConsistency", Order = 0)]
    [JsonProperty("DQ_FormatConsistency", Order = 0)]
    public DQ_FormatConsistency_Type DQ_FormatConsistency {
      get {
        return _dq_FormatConsistency;
      }
      set {
        if (_dq_FormatConsistency == value) {
          return;
        }
        if (_dq_FormatConsistency == null || _dq_FormatConsistency.Equals(value) != true) {
          _dq_FormatConsistency = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}