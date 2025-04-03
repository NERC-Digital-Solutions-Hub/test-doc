
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 00:06, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.SpatialSchema;
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

namespace NDSH.Geospatial.Metadata.V2005.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("EX_BoundingPolygon", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("EX_BoundingPolygon", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_BoundingPolygon")]
  public class EX_BoundingPolygon : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_BoundingPolygon"/>.
    /// </summary>
    public EX_BoundingPolygon() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _extentTypeCode = default; //new EX_ExtentTypeCode();
      _polygon = default; //new List<GM_Object>();

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

    private List<GM_Object> _polygon;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("polygon", Order = 1, ElementName = "polygon")]
    [JsonProperty("polygon", Order = 1)]
    public List<GM_Object> Polygon {
      get {
        return _polygon;
      }
      set {
        if (_polygon == value) {
          return;
        }
        if (_polygon == null || _polygon.Equals(value) != true) {
          _polygon = value;
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
