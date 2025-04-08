
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:11, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [XmlType("MI_EnvironmentalRecord", Namespace = "http://www.isotc211.org/2005/gmi")]
  [XmlRoot("MI_EnvironmentalRecord", Namespace = "http://www.isotc211.org/2005/gmi", IsNullable = false)]
  [JsonObject("MI_EnvironmentalRecord")]
  public class MI_EnvironmentalRecord_Type : AbstractObject_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_EnvironmentalRecord_Type"/>.
    /// </summary>
    public MI_EnvironmentalRecord_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmi", "http://www.isotc211.org/2005/gmi");

      _averageAirTemperature = default; // new Real_PropertyType();
      _maxRelativeHumidity = default; // new Real_PropertyType();
      _maxAltitude = default; // new Real_PropertyType();
      _meterologicalConditions = default; // new CharacterString_PropertyType();

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
    
    private Real_PropertyType _averageAirTemperature;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("averageAirTemperature", Order = 0)]
    [JsonProperty("averageAirTemperature", Order = 0)]
    public Real_PropertyType AverageAirTemperature {
      get {
        return _averageAirTemperature;
      }
      set {
        if (_averageAirTemperature == value) {
          return;
        }
        if (_averageAirTemperature == null || _averageAirTemperature.Equals(value) != true) {
          _averageAirTemperature = value;
          OnPropertyChanged();
        }
      }
    }

    private Real_PropertyType _maxRelativeHumidity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("maxRelativeHumidity", Order = 1)]
    [JsonProperty("maxRelativeHumidity", Order = 1)]
    public Real_PropertyType MaxRelativeHumidity {
      get {
        return _maxRelativeHumidity;
      }
      set {
        if (_maxRelativeHumidity == value) {
          return;
        }
        if (_maxRelativeHumidity == null || _maxRelativeHumidity.Equals(value) != true) {
          _maxRelativeHumidity = value;
          OnPropertyChanged();
        }
      }
    }

    private Real_PropertyType _maxAltitude;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("maxAltitude", Order = 2)]
    [JsonProperty("maxAltitude", Order = 2)]
    public Real_PropertyType MaxAltitude {
      get {
        return _maxAltitude;
      }
      set {
        if (_maxAltitude == value) {
          return;
        }
        if (_maxAltitude == null || _maxAltitude.Equals(value) != true) {
          _maxAltitude = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _meterologicalConditions;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("meterologicalConditions", Order = 3)]
    [JsonProperty("meterologicalConditions", Order = 3)]
    public CharacterString_PropertyType MeterologicalConditions {
      get {
        return _meterologicalConditions;
      }
      set {
        if (_meterologicalConditions == value) {
          return;
        }
        if (_meterologicalConditions == null || _meterologicalConditions.Equals(value) != true) {
          _meterologicalConditions = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
