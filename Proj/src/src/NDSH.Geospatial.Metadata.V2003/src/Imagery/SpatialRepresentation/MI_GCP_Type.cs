
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/01/2023, 01:41, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.DataQuality;
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
  [XmlType("MI_GCP", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_GCP", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_GCP")]
  public class MI_GCP_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_GCP_Type"/>
    /// </summary>
    public MI_GCP_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _geographicCoordinates = default; // new DirectPosition_PropertyType();
      _accuracyReport = default; // new List<DQ_Element_PropertyType>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private DirectPosition_PropertyType _geographicCoordinates;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geographicCoordinates", Order = 0)]
    [JsonProperty("geographicCoordinates", Order = 0)]
    public DirectPosition_PropertyType GeographicCoordinates {
      get {
        return _geographicCoordinates;
      }
      set {
        if (_geographicCoordinates == value) {
          return;
        }
        if (_geographicCoordinates == null || _geographicCoordinates.Equals(value) != true) {
          _geographicCoordinates = value;
          OnPropertyChanged();
        }
      }
    }

    private List<DQ_Element_PropertyType> _accuracyReport;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("accuracyReport", Order = 1)]
    [JsonProperty("accuracyReport", Order = 1)]
    public List<DQ_Element_PropertyType> AccuracyReport {
      get {
        return _accuracyReport;
      }
      set {
        if (_accuracyReport == value) {
          return;
        }
        if (_accuracyReport == null || _accuracyReport.Equals(value) != true) {
          _accuracyReport = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
