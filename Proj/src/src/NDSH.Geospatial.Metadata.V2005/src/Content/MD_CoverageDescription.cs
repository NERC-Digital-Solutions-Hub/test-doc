
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 02:19, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Records;
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

namespace NDSH.Geospatial.Metadata.V2005.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_CoverageDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_CoverageDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_CoverageDescription")]
  public class MD_CoverageDescription : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_CoverageDescription"/>.
    /// </summary>
    public MD_CoverageDescription() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd"); // TODO: Make sure that the namespace is GMD.

      _attributeDescription = default; //new RecordType();
      _contentType = default; //new MD_CoverageContentTypeCode();
      _dimension = default; //new List<Parent_MD_RangeDimension>();

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

    private RecordType _attributeDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "attributeDescription")]
    [JsonProperty("attributeDescription", Order = 0)]
    public RecordType AttributeDescription {
      get {
        return _attributeDescription;
      }
      set {
        if (_attributeDescription == value) {
          return;
        }
        if (_attributeDescription == null || _attributeDescription.Equals(value) != true) {
          _attributeDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_CoverageContentTypeCode _contentType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "contentType")]
    [JsonProperty("contentType", Order = 1)]
    public MD_CoverageContentTypeCode ContentType {
      get {
        return _contentType;
      }
      set {
        if (_contentType == value) {
          return;
        }
        if (_contentType == null || _contentType.Equals(value) != true) {
          _contentType = value;
          OnPropertyChanged();
        }
      }
    }

    private List<Parent_MD_RangeDimension> _dimension;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dimension", Order = 2, ElementName = "dimension")]
    [JsonProperty("dimension", Order = 2)]
    public List<Parent_MD_RangeDimension> Dimension {
      get {
        return _dimension;
      }
      set {
        if (_dimension == value) {
          return;
        }
        if (_dimension == null || _dimension.Equals(value) != true) {
          _dimension = value;
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
