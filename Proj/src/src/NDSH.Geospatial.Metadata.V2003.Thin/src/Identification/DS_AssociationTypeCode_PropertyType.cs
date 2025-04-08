
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 03:44, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_AssociationTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_AssociationTypeCode_PropertyType")]
  public class DS_AssociationTypeCode_PropertyType : NilReasonModel {

    #region Constuctors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_AssociationTypeCode_PropertyType"/>.
    /// </summary>
    public DS_AssociationTypeCode_PropertyType() {
      _ds_AssociationTypeCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _ds_AssociationTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_AssociationTypeCode", Order = 0)]
    [JsonProperty("DS_AssociationTypeCode", Order = 0)]
    public CodeListValue_Type DS_AssociationTypeCode {
      get {
        return _ds_AssociationTypeCode;
      }
      set {
        if (_ds_AssociationTypeCode == value) {
          return;
        }
        if (_ds_AssociationTypeCode == null || _ds_AssociationTypeCode.Equals(value) != true) {
          _ds_AssociationTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
