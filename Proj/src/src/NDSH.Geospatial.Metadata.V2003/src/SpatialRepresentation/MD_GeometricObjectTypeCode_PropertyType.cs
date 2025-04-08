
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:20, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_GeometricObjectTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_GeometricObjectTypeCode_PropertyType")]
  public class MD_GeometricObjectTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_GeometricObjectTypeCode_PropertyType"/>.
    /// </summary>
    public MD_GeometricObjectTypeCode_PropertyType() {
      _md_GeometricObjectTypeCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_GeometricObjectTypeCode;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_GeometricObjectTypeCode", Order = 0)]
    [JsonProperty("MD_GeometricObjectTypeCode", Order = 0)]
    public CodeListValue_Type MD_GeometricObjectTypeCode {
      get {
        return _md_GeometricObjectTypeCode;
      }
      set {
        if (_md_GeometricObjectTypeCode == value) {
          return;
        }
        if (_md_GeometricObjectTypeCode == null || _md_GeometricObjectTypeCode.Equals(value) != true) {
          _md_GeometricObjectTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
