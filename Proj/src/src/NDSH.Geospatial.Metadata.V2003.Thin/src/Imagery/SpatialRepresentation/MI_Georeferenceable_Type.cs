            
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:39, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition;
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
  /// Description of information provided in metadata that allows
  /// the geographic or map location raster points to be located.
  /// </summary>
  /// <remarks>
  /// <para>FGDC: Georeferencing_Description</para>
  /// <para>ShortName: IGeoref</para>
  /// </remarks>
  [Serializable]
  [XmlType("MI_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_Georeferenceable", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_Georeferenceable")]
  public class MI_Georeferenceable_Type : MD_Georeferenceable_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Georeferenceable_Type"/>
    /// </summary>
    public MI_Georeferenceable_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _geolocationInformation = default; // new List<MI_GeolocationInformation_PropertyType>();
      _platformParameters = default; // new MI_Platform_PropertyType();

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

    private List<MI_GeolocationInformation_PropertyType> _geolocationInformation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geolocationInformation", Order = 0)]
    [JsonProperty("geolocationInformation", Order = 0)]
    public List<MI_GeolocationInformation_PropertyType> GeolocationInformation {
      get {
        return _geolocationInformation;
      }
      set {
        if (_geolocationInformation == value) {
          return;
        }
        if (_geolocationInformation == null || _geolocationInformation.Equals(value) != true) {
          _geolocationInformation = value;
          OnPropertyChanged();
        }
      }
    }

    private MI_Platform_PropertyType _platformParameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("platformParameters", Order = 1)]
    [JsonProperty("platformParameters", Order = 1)]
    public MI_Platform_PropertyType PlatformParameters {
      get {
        return _platformParameters;
      }
      set {
        if (_platformParameters == value) {
          return;
        }
        if (_platformParameters == null || _platformParameters.Equals(value) != true) {
          _platformParameters = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
