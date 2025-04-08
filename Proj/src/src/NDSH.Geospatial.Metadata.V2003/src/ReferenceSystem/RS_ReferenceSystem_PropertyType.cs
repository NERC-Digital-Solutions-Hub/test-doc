
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/12/2022, 18:43, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("RS_ReferenceSystem_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("RS_ReferenceSystem_PropertyType")]
  public class RS_ReferenceSystem_PropertyType : ObjectReference_PropertyType {

    #region Public Properties
    
    private AbstractRS_ReferenceSystem_Type _abstractRS_ReferenceSystem;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractRS_ReferenceSystem", Order = 0)]
    [JsonProperty("AbstractRS_ReferenceSystem", Order = 0)]
    public AbstractRS_ReferenceSystem_Type AbstractRS_ReferenceSystem {
      get {
        return _abstractRS_ReferenceSystem;
      }
      set {
        if (_abstractRS_ReferenceSystem == value) {
          return;
        }
        if (_abstractRS_ReferenceSystem == null || _abstractRS_ReferenceSystem.Equals(value) != true) {
          _abstractRS_ReferenceSystem = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
