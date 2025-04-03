
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 11:48, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_TransferFunctionTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_TransferFunctionTypeCode_PropertyType")]
  public class MI_TransferFunctionTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_TransferFunctionTypeCode_PropertyType"/>.
    /// </summary>
    public MI_TransferFunctionTypeCode_PropertyType() {
      _mi_TransferFunctionTypeCode = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_TransferFunctionTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_TransferFunctionTypeCode", Order = 0)]
    [JsonProperty("MI_TransferFunctionTypeCode", Order = 0)]
    public CodeListValue_Type MI_TransferFunctionTypeCode {
      get {
        return _mi_TransferFunctionTypeCode;
      }
      set {
        if (_mi_TransferFunctionTypeCode == value) {
          return;
        }
        if (_mi_TransferFunctionTypeCode == null || _mi_TransferFunctionTypeCode.Equals(value) != true) {
          _mi_TransferFunctionTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
