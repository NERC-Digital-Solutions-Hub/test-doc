
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:52, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Imagery.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_GeolocationInformation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_GeolocationInformation_PropertyType")]
  public class MI_GeolocationInformation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_GeolocationInformation_PropertyType"/>.
    /// </summary>
    public MI_GeolocationInformation_PropertyType() {
      _mi_GeolocationInformation = default; // new MI_GeolocationInformation_Type();
    }

    #endregion

    #region Public Properties

    private AbstractMI_GeolocationInformation_Type _mi_GeolocationInformation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_GeolocationInformation", Order = 0)]
    [JsonProperty("MI_GeolocationInformation", Order = 0)]
    public AbstractMI_GeolocationInformation_Type MI_GeolocationInformation {
      get {
        return _mi_GeolocationInformation;
      }
      set {
        if (_mi_GeolocationInformation == value) {
          return;
        }
        if (_mi_GeolocationInformation == null || _mi_GeolocationInformation.Equals(value) != true) {
          _mi_GeolocationInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
