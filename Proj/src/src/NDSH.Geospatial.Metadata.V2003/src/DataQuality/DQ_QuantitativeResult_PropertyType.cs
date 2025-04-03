
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:35, @gisvlasta.
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
  [XmlType("DQ_QuantitativeResult_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_QuantitativeResult_PropertyType")]
  public class DQ_QuantitativeResult_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_QuantitativeResult_PropertyType"/>.
    /// </summary>
    public DQ_QuantitativeResult_PropertyType() {
      _dq_QuantitativeResult  = default; //  new DQ_QuantitativeResult_Type();
    }

    #endregion

    #region Public Properties
    
    private DQ_QuantitativeResult_Type _dq_QuantitativeResult;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_QuantitativeResult", Order = 0)]
    [JsonProperty("DQ_QuantitativeResult", Order = 0)]
    public DQ_QuantitativeResult_Type DQ_QuantitativeResult {
      get {
        return _dq_QuantitativeResult;
      }
      set {
        if (_dq_QuantitativeResult == value) {
          return;
        }
        if (_dq_QuantitativeResult == null || _dq_QuantitativeResult.Equals(value) != true) {
          _dq_QuantitativeResult = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion
    
  }

}