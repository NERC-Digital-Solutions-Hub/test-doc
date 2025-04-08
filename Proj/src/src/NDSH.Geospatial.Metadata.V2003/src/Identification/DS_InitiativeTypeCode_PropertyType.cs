
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 03:51, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_InitiativeTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_InitiativeTypeCode_PropertyType")]
  public class DS_InitiativeTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Intializes the <see cref="DS_InitiativeTypeCode_PropertyType"/>.
    /// </summary>
    public DS_InitiativeTypeCode_PropertyType() {
      _ds_InitiativeTypeCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _ds_InitiativeTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_InitiativeTypeCode", Order = 0)]
    [JsonProperty("DS_InitiativeTypeCode", Order = 0)]
    public CodeListValue_Type DS_InitiativeTypeCode {
      get {
        return _ds_InitiativeTypeCode;
      }
      set {
        if (_ds_InitiativeTypeCode == value) {
          return;
        }
        if (_ds_InitiativeTypeCode == null || _ds_InitiativeTypeCode.Equals(value) != true) {
          _ds_InitiativeTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
