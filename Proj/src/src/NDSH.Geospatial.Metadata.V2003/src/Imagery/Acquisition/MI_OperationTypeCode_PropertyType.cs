
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:42, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_OperationTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_OperationTypeCode_PropertyType")]
  public class MI_OperationTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_OperationTypeCode_PropertyType"/>.
    /// </summary>
    public MI_OperationTypeCode_PropertyType() {
      _mi_OperationTypeCode = default; // new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_OperationTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_OperationTypeCode", Order = 0)]
    [JsonProperty("MI_OperationTypeCode", Order = 0)]
    public CodeListValue_Type MI_OperationTypeCode {
      get {
        return _mi_OperationTypeCode;
      }
      set {
        if (_mi_OperationTypeCode == value) {
          return;
        }
        if (_mi_OperationTypeCode == null || _mi_OperationTypeCode.Equals(value) != true) {
          _mi_OperationTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
