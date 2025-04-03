
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 00:15, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Time;
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
  [XmlRoot("EX_SpatialTemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("EX_SpatialTemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_SpatialTemporalExtent")]
  public class EX_SpatialTemporalExtent : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_SpatialTemporalExtent"/>.
    /// </summary>
    public EX_SpatialTemporalExtent() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _extent = default; //new TM_PeriodDuration();
      _spatialExtent = default; //new List<Parent_EX_GeographicExtent>();

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

    private TM_PeriodDuration _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "extent")]
    [JsonProperty("extent", Order = 0)]
    public TM_PeriodDuration Extent {
      get {
        return _extent;
      }
      set {
        if (_extent == value) {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true) {
          _extent = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Parent_EX_GeographicExtent> _spatialExtent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("spatialExtent", Order = 1, ElementName = "spatialExtent")]
    [JsonProperty("spatialExtent", Order = 1)]
    public List<Parent_EX_GeographicExtent> SpatialExtent {
      get {
        return _spatialExtent;
      }
      set {
        if (_spatialExtent == value) {
          return;
        }
        if (_spatialExtent == null || _spatialExtent.Equals(value) != true) {
          _spatialExtent = value;
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
