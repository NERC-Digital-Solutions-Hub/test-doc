
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 02:43, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names;
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
  [XmlRoot("MD_RangeDimension", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_RangeDimension", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_RangeDimension")]
  public class MD_RangeDimension : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_RangeDimension"/>.
    /// </summary>
    public MD_RangeDimension() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd"); // TODO: Make sure that the namespace is GMD.

      _sequenceIdentifier = default; //new MemberName();
      _descriptor = default;

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

    private MemberName _sequenceIdentifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "sequenceIdentifier")]
    [JsonProperty("sequenceIdentifier", Order = 0)]
    public MemberName SequenceIdentifier {
      get {
        return _sequenceIdentifier;
      }
      set {
        if (_sequenceIdentifier == value) {
          return;
        }
        if (_sequenceIdentifier == null || _sequenceIdentifier.Equals(value) != true) {
          _sequenceIdentifier = value;
          OnPropertyChanged();
        }
      }
    }

    private string _descriptor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "descriptor")]
    [JsonProperty("descriptor", Order = 1)]
    public string Descriptor {
      get {
        return _descriptor;
      }
      set {
        if (_descriptor == value) {
          return;
        }
        if (_descriptor == null || _descriptor.Equals(value) != true) {
          _descriptor = value;
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
