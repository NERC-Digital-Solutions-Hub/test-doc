
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 00:21, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.Measure;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Common.Extent
{

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("EX_GeographicBoundingBox", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("EX_GeographicBoundingBox", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_GeographicBoundingBox")]
  public class EX_GeographicBoundingBox : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_GeographicBoundingBox"/>.
    /// </summary>
    public EX_GeographicBoundingBox() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _extentTypeCode = new EX_ExtentTypeCode();
      _westBoundLongitude = new Angle();
      _eastBoundLongitude = new Angle();
      _southBoundLatitude = new Angle();
      _northBoundLatitude = new Angle();

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

    private EX_ExtentTypeCode _extentTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "extentTypeCode")]
    [JsonProperty("extentTypeCode", Order = 0)]
    public EX_ExtentTypeCode ExtentTypeCode {
      get {
        return _extentTypeCode;
      }
      set {
        if (_extentTypeCode == value) {
          return;
        }
        if (_extentTypeCode == null || _extentTypeCode.Equals(value) != true) {
          _extentTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    private Angle _westBoundLongitude;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "westBoundLongitude")]
    [JsonProperty("westBoundLongitude", Order = 1)]
    public Angle WestBoundLongitude {
      get {
        return _westBoundLongitude;
      }
      set {
        if (_westBoundLongitude == value) {
          return;
        }
        if (_westBoundLongitude == null || _westBoundLongitude.Equals(value) != true) {
          _westBoundLongitude = value;
          OnPropertyChanged();
        }
      }
    }

    private Angle _eastBoundLongitude;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "eastBoundLongitude")]
    [JsonProperty("eastBoundLongitude", Order = 2)]
    public Angle EastBoundLongitude {
      get {
        return _eastBoundLongitude;
      }
      set {
        if (_eastBoundLongitude == value) {
          return;
        }
        if (_eastBoundLongitude == null || _eastBoundLongitude.Equals(value) != true) {
          _eastBoundLongitude = value;
          OnPropertyChanged();
        }
      }
    }

    private Angle _southBoundLatitude;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "southBoundLatitude")]
    [JsonProperty("southBoundLatitude", Order = 3)]
    public Angle SouthBoundLatitude {
      get {
        return _southBoundLatitude;
      }
      set {
        if (_southBoundLatitude == value) {
          return;
        }
        if (_southBoundLatitude == null || _southBoundLatitude.Equals(value) != true) {
          _southBoundLatitude = value;
          OnPropertyChanged();
        }
      }
    }

    private Angle _northBoundLatitude;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "northBoundLatitude")]
    [JsonProperty("northBoundLatitude", Order = 4)]
    public Angle NorthBoundLatitude {
      get {
        return _northBoundLatitude;
      }
      set {
        if (_northBoundLatitude == value) {
          return;
        }
        if (_northBoundLatitude == null || _northBoundLatitude.Equals(value) != true) {
          _northBoundLatitude = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore()]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [XmlIgnore()]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
