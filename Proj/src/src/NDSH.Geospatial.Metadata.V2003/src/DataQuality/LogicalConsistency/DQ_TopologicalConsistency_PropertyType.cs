
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:58, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.DataQuality.LogicalConsistency {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_TopologicalConsistency_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_TopologicalConsistency_PropertyType")]
  public class DQ_TopologicalConsistency_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_TopologicalConsistency_PropertyType"/>.
    /// </summary>
    public DQ_TopologicalConsistency_PropertyType() {
      _dq_TopologicalConsistency  = default; //  new DQ_TopologicalConsistency_Type();
    }

    #endregion

    #region Public Properties

    private DQ_TopologicalConsistency_Type _dq_TopologicalConsistency;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_TopologicalConsistency", Order = 0)]
    [JsonProperty("DQ_TopologicalConsistency", Order = 0)]
    public DQ_TopologicalConsistency_Type DQ_TopologicalConsistency {
      get {
        return _dq_TopologicalConsistency;
      }
      set {
        if (_dq_TopologicalConsistency == value) {
          return;
        }
        if (_dq_TopologicalConsistency == null || _dq_TopologicalConsistency.Equals(value) != true) {
          _dq_TopologicalConsistency = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}