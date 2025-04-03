
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 00:28, @gisvlasta - Cleaned Xml Serialization Attributes.
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

namespace NDSH.Geospatial.Metadata.V2005.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("EX_Extent", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("EX_Extent", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_Extent")]
  public class EX_Extent  : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_Extent"/>.
    /// </summary>
    public EX_Extent() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _description = default;
      _geographicElement = default; //new List<Parent_EX_GeographicExtent>();
      _temporalElement = default; //new List<Parent_EX_TemporalExtent>();
      _verticalElement = default; //new List<EX_VerticalExtent>();

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

    private string _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "description")]
    [JsonProperty("description", Order = 0)]
    public string Description {
      get {
        return _description;
      }
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || _description.Equals(value) != true) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Parent_EX_GeographicExtent> _geographicElement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("geographicElement", Order = 1, ElementName = "geographicElement")]
    [JsonProperty("geographicElement", Order = 1)]
    public List<Parent_EX_GeographicExtent> GeographicElement {
      get {
        return _geographicElement;
      }
      set {
        if (_geographicElement == value) {
          return;
        }
        if (_geographicElement == null || _geographicElement.Equals(value) != true) {
          _geographicElement = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Parent_EX_TemporalExtent> _temporalElement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("temporalElement", Order = 2, ElementName = "temporalElement")]
    [JsonProperty("temporalElement", Order = 2)]
    public List<Parent_EX_TemporalExtent> TemporalElement {
      get {
        return _temporalElement;
      }
      set {
        if (_temporalElement == value) {
          return;
        }
        if (_temporalElement == null || _temporalElement.Equals(value) != true) {
          _temporalElement = value;
          OnPropertyChanged();
        }
      }
    }

    private List<EX_VerticalExtent> _verticalElement;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("verticalElement", Order = 3, ElementName = "verticalElement")]
    [JsonProperty("verticalElement", Order = 3)]
    public List<EX_VerticalExtent> VerticalElement {
      get {
        return _verticalElement;
      }
      set {
        if (_verticalElement == value) {
          return;
        }
        if (_verticalElement == null || _verticalElement.Equals(value) != true) {
          _verticalElement = value;
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
