
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 00:52, @gisvlasta.
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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("TM_PeriodDuration_PropertyType", Namespace = "http://www.isotc211.org/2005/gts")]
  [JsonObject("TM_PeriodDuration_PropertyType")]
  public class TM_PeriodDuration_PropertyType : NilReasonModel {

    #region Public Properties

    private string _tm_PeriodDuration;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("TM_PeriodDuration", DataType = "duration", Order = 0)]
    [JsonProperty("TM_PeriodDuration", Order = 0)]
    public string TM_PeriodDuration {
      get {
        return _tm_PeriodDuration;
      }
      set {
        if (_tm_PeriodDuration == value) {
          return;
        }
        if (_tm_PeriodDuration == null || _tm_PeriodDuration.Equals(value) != true) {
          _tm_PeriodDuration = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
