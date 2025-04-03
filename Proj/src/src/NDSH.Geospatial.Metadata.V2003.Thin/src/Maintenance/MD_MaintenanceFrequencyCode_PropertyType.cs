
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 14:40, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Maintenance {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_MaintenanceFrequencyCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_MaintenanceFrequencyCode_PropertyType")]
  public class MD_MaintenanceFrequencyCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_MaintenanceFrequencyCode_PropertyType"/>.
    /// </summary>
    public MD_MaintenanceFrequencyCode_PropertyType() {
      _md_MaintenanceFrequencyCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_MaintenanceFrequencyCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_MaintenanceFrequencyCode", Order = 0)]
    [JsonProperty("MD_MaintenanceFrequencyCode", Order = 0)]
    public CodeListValue_Type MD_MaintenanceFrequencyCode {
      get {
        return _md_MaintenanceFrequencyCode;
      }
      set {
        if (_md_MaintenanceFrequencyCode == value) {
          return;
        }
        if (_md_MaintenanceFrequencyCode == null || _md_MaintenanceFrequencyCode.Equals(value) != true) {
          _md_MaintenanceFrequencyCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
