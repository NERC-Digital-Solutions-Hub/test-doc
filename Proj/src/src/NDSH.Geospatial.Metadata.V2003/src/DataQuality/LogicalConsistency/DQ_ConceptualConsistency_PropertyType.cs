
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:05, @gisvlasta.
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
  [XmlType("DQ_ConceptualConsistency_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_ConceptualConsistency_PropertyType")]
  public class DQ_ConceptualConsistency_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_ConceptualConsistency_PropertyType"/>.
    /// </summary>
    public DQ_ConceptualConsistency_PropertyType() {
      _dq_ConceptualConsistency  = default; //  new DQ_ConceptualConsistency_Type();
    }

    #endregion

    #region Public Properties

    private DQ_ConceptualConsistency_Type _dq_ConceptualConsistency;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_ConceptualConsistency", Order = 0)]
    [JsonProperty("DQ_ConceptualConsistency", Order = 0)]
    public DQ_ConceptualConsistency_Type DQ_ConceptualConsistency {
      get {
        return _dq_ConceptualConsistency;
      }
      set {
        if (_dq_ConceptualConsistency == value) {
          return;
        }
        if (_dq_ConceptualConsistency == null || _dq_ConceptualConsistency.Equals(value) != true) {
          _dq_ConceptualConsistency = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}