
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:08, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_ConformanceResult_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_ConformanceResult_PropertyType")]
  public class DQ_ConformanceResult_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_ConformanceResult_PropertyType"/>.
    /// </summary>
    public DQ_ConformanceResult_PropertyType() {
      _dq_ConformanceResult  = default; //  new DQ_ConformanceResult_Type();
    }

    #endregion

    #region Public Properties

    private DQ_ConformanceResult_Type _dq_ConformanceResult;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_ConformanceResult", Order = 0)]
    [JsonProperty("DQ_ConformanceResult", Order = 0)]
    public DQ_ConformanceResult_Type DQ_ConformanceResult {
      get {
        return _dq_ConformanceResult;
      }
      set {
        if (_dq_ConformanceResult == value) {
          return;
        }
        if (_dq_ConformanceResult == null || _dq_ConformanceResult.Equals(value) != true) {
          _dq_ConformanceResult = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}