
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 00:59, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
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

namespace NDSH.Geospatial.Metadata.V2005.Common.SpatialSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("GM_Point", Namespace = "http://www.isotc211.org/2005/gss", IsNullable = false)]
  [XmlType("GM_Point", Namespace = "http://www.isotc211.org/2005/gss")]
  [JsonObject("GM_Point")]
  public class GM_Point : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GM_Point"/>.
    /// </summary>
    public GM_Point() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gss", "http://www.isotc211.org/2005/gss");

      _x = default;
      _y = default;
      _z = default;
      
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public PRoperties

    private double _x;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "x")]
    [JsonProperty("x")]
    public double X {
      get {
        return _x;
      }
      set {
        if (_x.Equals(value) != true) {
          _x = value;
          OnPropertyChanged();
        }
      }
    }

    private double _y;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "y")]
    [JsonProperty("y")]
    public double Y {
      get {
        return _y;
      }
      set {
        if (_y.Equals(value) != true) {
          _y = value;
          OnPropertyChanged();
        }
      }
    }

    private double _z;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "z")]
    [JsonProperty("z")]
    public double Z {
      get {
        return _z;
      }
      set {
        if (_z.Equals(value) != true) {
          _z = value;
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
