
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:18, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_EvaluationMethodTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_EvaluationMethodTypeCode_PropertyType")]
  public class DQ_EvaluationMethodTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_EvaluationMethodTypeCode_PropertyType"/>.
    /// </summary>
    public DQ_EvaluationMethodTypeCode_PropertyType() {
      _dq_EvaluationMethodTypeCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _dq_EvaluationMethodTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_EvaluationMethodTypeCode", Order = 0)]
    [JsonProperty("DQ_EvaluationMethodTypeCode", Order = 0)]
    public CodeListValue_Type DQ_EvaluationMethodTypeCode {
      get {
        return _dq_EvaluationMethodTypeCode;
      }
      set {
        if (_dq_EvaluationMethodTypeCode == value) {
          return;
        }
        if (_dq_EvaluationMethodTypeCode == null || _dq_EvaluationMethodTypeCode.Equals(value) != true) {
          _dq_EvaluationMethodTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}