
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:00, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_ContentInformation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ContentInformation_PropertyType")]
  public class MD_ContentInformation_PropertyType : ObjectReference_PropertyType {
    
    #region Public Properties

    private AbstractMD_ContentInformation_Type _abstractMD_ContentInformation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractMD_ContentInformation", Order = 0)]
    [JsonProperty("AbstractMD_ContentInformation", Order = 0)]
    public AbstractMD_ContentInformation_Type AbstractMD_ContentInformation {
      get {
        return _abstractMD_ContentInformation;
      }
      set {
        if (_abstractMD_ContentInformation == value) {
          return;
        }
        if (_abstractMD_ContentInformation == null || _abstractMD_ContentInformation.Equals(value) != true) {
          _abstractMD_ContentInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
