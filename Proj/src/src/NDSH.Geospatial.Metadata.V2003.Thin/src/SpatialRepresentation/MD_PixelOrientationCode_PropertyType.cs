
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:02, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_PixelOrientationCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_PixelOrientationCode_PropertyType")]
  public class MD_PixelOrientationCode_PropertyType : NilReasonModel { // TODO: DANGER !!! - Why this inherits only from NilModel?
    
    #region Public Properties
    
    private MD_PixelOrientationCode_Type _md_PixelOrientationCode;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_PixelOrientationCode", Order = 0)]
    [JsonProperty("MD_PixelOrientationCode", Order = 0)]
    public MD_PixelOrientationCode_Type MD_PixelOrientationCode {
      get {
        return _md_PixelOrientationCode;
      }
      set {
        if (_md_PixelOrientationCode.Equals(value) != true) {
          _md_PixelOrientationCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
