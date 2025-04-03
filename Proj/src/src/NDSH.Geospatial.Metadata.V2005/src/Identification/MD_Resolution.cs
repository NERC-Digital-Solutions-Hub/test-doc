
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 01:25, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Derived.UnitsOfMeasure;
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

namespace NDSH.Geospatial.Metadata.V2005.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_Resolution", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_Resolution", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Resolution")]
  public class MD_Resolution : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Resolution"/>.
    /// </summary>
    public MD_Resolution() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _equivalentScale = default; //new MD_RepresentativeFraction();
      _distance = default; //new Distance();

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

    private MD_RepresentativeFraction _equivalentScale;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "equivalentScale")]
    [JsonProperty("equivalentScale", Order = 0)]
    public MD_RepresentativeFraction EquivalentScale {
      get {
        return _equivalentScale;
      }
      set {
        if (_equivalentScale == value) {
          return;
        }
        if (_equivalentScale == null || _equivalentScale.Equals(value) != true) {
          _equivalentScale = value;
          OnPropertyChanged();
        }
      }
    }

    private Distance _distance;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "distance")]
    [JsonProperty("distance", Order = 1)]
    public Distance Distance {
      get {
        return _distance;
      }
      set {
        if ((_distance == value)) {
          return;
        }
        if (_distance == null || _distance.Equals(value) != true) {
          _distance = value;
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
