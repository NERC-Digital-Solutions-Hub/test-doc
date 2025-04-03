
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 02:52, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_PlatformSpecificServiceSpecification_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_PlatformSpecificServiceSpecification_PropertyType")]
  public class SV_PlatformSpecificServiceSpecification_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_PlatformSpecificServiceSpecification_PropertyType"/>.
    /// </summary>
    public SV_PlatformSpecificServiceSpecification_PropertyType() {
      _sv_PlatformSpecificServiceSpecification = new SV_PlatformSpecificServiceSpecification_Type();
    }

    #endregion

    #region Public Properties

    private SV_PlatformSpecificServiceSpecification_Type _sv_PlatformSpecificServiceSpecification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_PlatformSpecificServiceSpecification", Order = 0)]
    [JsonProperty("SV_PlatformSpecificServiceSpecification", Order = 0)]
    public SV_PlatformSpecificServiceSpecification_Type SV_PlatformSpecificServiceSpecification {
      get {
        return _sv_PlatformSpecificServiceSpecification;
      }
      set {
        if (_sv_PlatformSpecificServiceSpecification == value) {
          return;
        }
        if (_sv_PlatformSpecificServiceSpecification == null || _sv_PlatformSpecificServiceSpecification.Equals(value) != true) {
          _sv_PlatformSpecificServiceSpecification = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
