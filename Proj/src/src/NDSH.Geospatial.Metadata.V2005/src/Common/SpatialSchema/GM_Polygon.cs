
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 01:02, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Common.SpatialSchema {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("GM_Polygon", Namespace = "http://www.isotc211.org/2005/gss", IsNullable = false)]
  [XmlType("GM_Polygon", Namespace = "http://www.isotc211.org/2005/gss")]
  [JsonObject("GM_Polygon")]
  public class GM_Polygon : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GM_Polygon"/>.
    /// </summary>
    public GM_Polygon() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gss", "http://www.isotc211.org/2005/gss");

      _points = default; // new List<GM_Point>();

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

    private List<GM_Point> _points;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("points", Order = 0, ElementName = "points")]
    [JsonProperty("points", Order = 0)]
    public List<GM_Point> Points {
      get {
        return _points;
      }
      set {
        if (_points == value) {
          return;
        }
        if (_points == null || _points.Equals(value) != true) {
          _points = value;
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
