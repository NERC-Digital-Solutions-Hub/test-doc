
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:13, @gisvlasta.
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
  [XmlType("DQ_DomainConsistency_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_DomainConsistency_PropertyType")]
  public class DQ_DomainConsistency_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_DomainConsistency_PropertyType"/>.
    /// </summary>
    public DQ_DomainConsistency_PropertyType() {
      _dq_DomainConsistency  = default; //  new DQ_DomainConsistency_Type();
    }

    #endregion

    #region Public Properties

    private DQ_DomainConsistency_Type _dq_DomainConsistency;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_DomainConsistency", Order = 0)]
    [JsonProperty("DQ_DomainConsistency", Order = 0)]
    public DQ_DomainConsistency_Type DQ_DomainConsistency {
      get {
        return _dq_DomainConsistency;
      }
      set {
        if (_dq_DomainConsistency == value) {
          return;
        }
        if (_dq_DomainConsistency == null || _dq_DomainConsistency.Equals(value) != true) {
          _dq_DomainConsistency = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}