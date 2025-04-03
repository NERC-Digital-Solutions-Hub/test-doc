
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 14:57, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Maintenance {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_MaintenanceInformation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_MaintenanceInformation_PropertyType")]
  public class MD_MaintenanceInformation_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_MaintenanceInformation_PropertyType"/>.
    /// </summary>
    public MD_MaintenanceInformation_PropertyType() {
      _md_MaintenanceInformation  = default; //  new MD_MaintenanceInformation_Type();
    }

    #endregion

    #region Private fields

    private MD_MaintenanceInformation_Type _md_MaintenanceInformation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_MaintenanceInformation", Order = 0)]
    [JsonProperty("MD_MaintenanceInformation", Order = 0)]
    public MD_MaintenanceInformation_Type MD_MaintenanceInformation {
      get {
        return _md_MaintenanceInformation;
      }
      set {
        if (_md_MaintenanceInformation == value) {
          return;
        }
        if (_md_MaintenanceInformation == null || _md_MaintenanceInformation.Equals(value) != true) {
          _md_MaintenanceInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
