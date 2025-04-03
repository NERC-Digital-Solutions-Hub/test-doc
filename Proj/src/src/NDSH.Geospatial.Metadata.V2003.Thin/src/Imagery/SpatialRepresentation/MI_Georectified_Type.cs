
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:55, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Georectified", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Georectified", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Georectified")]
  public class MI_Georectified_Type : MD_Georectified_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Georectified_Type"/>
    /// </summary>
    public MI_Georectified_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _checkPoint = default; // new List<MI_GCP_PropertyType>();
      _geolocationIdentification = default; // new List<MI_GCPCollection_PropertyType>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<MI_GCP_PropertyType> _checkPoint;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("checkPoint", Order = 0)]
    [JsonProperty("checkPoint", Order = 0)]
    public List<MI_GCP_PropertyType> CheckPoint {
      get {
        return _checkPoint;
      }
      set {
        if (_checkPoint == value) {
          return;
        }
        if (_checkPoint == null || _checkPoint.Equals(value) != true) {
          _checkPoint = value;
          OnPropertyChanged();
        }
      }
    }
    
    private List<MI_GCPCollection_PropertyType> _geolocationIdentification;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geolocationIdentification", Order = 1)]
    [JsonProperty("geolocationIdentification", Order = 1)]
    public List<MI_GCPCollection_PropertyType> GeolocationIdentification {
      get {
        return _geolocationIdentification;
      }
      set {
        if (_geolocationIdentification == value) {
          return;
        }
        if (_geolocationIdentification == null || _geolocationIdentification.Equals(value) != true) {
          _geolocationIdentification = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
