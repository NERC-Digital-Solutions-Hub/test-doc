
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:26, @gisvlasta.
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
  [XmlType("DQ_LogicalConsistency_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_LogicalConsistency_PropertyType")]
  public class DQ_LogicalConsistency_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractDQ_LogicalConsistency_Type _abstractDQ_LogicalConsistency;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractDQ_LogicalConsistency", Order = 0)]
    [JsonProperty("AbstractDQ_LogicalConsistency", Order = 0)]
    public AbstractDQ_LogicalConsistency_Type AbstractDQ_LogicalConsistency {
      get {
        return _abstractDQ_LogicalConsistency;
      }
      set {
        if (_abstractDQ_LogicalConsistency == value) {
          return;
        }
        if (_abstractDQ_LogicalConsistency == null || _abstractDQ_LogicalConsistency.Equals(value) != true) {
          _abstractDQ_LogicalConsistency = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
