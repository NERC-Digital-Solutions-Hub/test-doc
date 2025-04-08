
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 18:53, @fdq09eca - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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

namespace NDSH.Geospatial.Metadata.V2005.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_CRS", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_CRS", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_CRS")]
  public class MD_CRS : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_CRS"/>.
    /// </summary>
    public MD_CRS() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _referenceSystemIdentifier = default; // new RS_Identifier();
      _projection = default; // new RS_Identifier();
      _ellipsoid = default; // new RS_Identifier();
      _datum = default; // new RS_Identifier();
      _projectionParameters = default; // new MD_EllipsoidParameters();
      _ellipsoidParameters = default; // new MD_ProjectionParameters();

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

    private RS_Identifier _referenceSystemIdentifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "referenceSystemIdentifier")]
    [JsonProperty("referenceSystemIdentifier", Order = 0)]
    public RS_Identifier ReferenceSystemIdentifier {
      get {
        return _referenceSystemIdentifier;
      }
      set {
        if (_referenceSystemIdentifier == value) {
          return;
        }
        if (_referenceSystemIdentifier == null || _referenceSystemIdentifier.Equals(value) != true) {
          _referenceSystemIdentifier = value;
          OnPropertyChanged();
        }
      }
    }

    private RS_Identifier _projection;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "projection")]
    [JsonProperty("projection", Order = 1)]
    public RS_Identifier Projection {
      get {
        return _projection;
      }
      set {
        if (_projection == value) {
          return;
        }
        if (_projection == null || _projection.Equals(value) != true) {
          _projection = value;
          OnPropertyChanged();
        }
      }
    }

    private RS_Identifier _ellipsoid;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "ellipsoid")]
    [JsonProperty("ellipsoid", Order = 2)]
    public RS_Identifier Ellipsoid {
      get {
        return _ellipsoid;
      }
      set {
        if (_ellipsoid == value) {
          return;
        }
        if (_ellipsoid == null || _ellipsoid.Equals(value) != true) {
          _ellipsoid = value;
          OnPropertyChanged();
        }
      }
    }

    private RS_Identifier _datum;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "datum")]
    [JsonProperty("datum", Order = 3)]
    public RS_Identifier Datum {
      get {
        return _datum;
      }
      set {
        if (_datum == value) {
          return;
        }
        if (_datum == null || _datum.Equals(value) != true) {
          _datum = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_EllipsoidParameters _projectionParameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "projectionParameters")]
    [JsonProperty("projectionParameters", Order = 4)]
    public MD_EllipsoidParameters ProjectionParameters {
      get {
        return _projectionParameters;
      }
      set {
        if (_projectionParameters == value) {
          return;
        }
        if (_projectionParameters == null || _projectionParameters.Equals(value) != true) {
          _projectionParameters = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_ProjectionParameters _ellipsoidParameters;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "ellipsoidParameters")]
    [JsonProperty("ellipsoidParameters", Order = 5)]
    public MD_ProjectionParameters EllipsoidParameters {
      get {
        return _ellipsoidParameters;
      }
      set {
        if ((_ellipsoidParameters == value)) {
          return;
        }
        if (_ellipsoidParameters == null || _ellipsoidParameters.Equals(value) != true) {
          _ellipsoidParameters = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [XmlIgnore]
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
    [XmlIgnore]
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
