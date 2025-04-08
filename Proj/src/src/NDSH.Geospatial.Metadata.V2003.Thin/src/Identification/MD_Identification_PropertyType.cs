
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 02:47, @gisvlasta.
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
  [XmlType("MD_Identification_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Identification_PropertyType")]
  public class MD_Identification_PropertyType : ObjectReference_PropertyType {
    
    #region Public Properties

    private AbstractMD_Identification_Type _abstractMD_Identification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractMD_Identification", Order = 0)]
    [JsonProperty("AbstractMD_Identification", Order = 0)]
    public AbstractMD_Identification_Type AbstractMD_Identification {
      get {
        return _abstractMD_Identification;
      }
      set {
        if (_abstractMD_Identification == value) {
          return;
        }
        if (_abstractMD_Identification == null || _abstractMD_Identification.Equals(value) != true) {
          _abstractMD_Identification = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
