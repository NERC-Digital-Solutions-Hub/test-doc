
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 19:07, @fdq09eca - Cleaned Xml Serialization Attributes.
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
  [XmlRoot("MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ReferenceSystem")]
  public class MD_ReferenceSystem : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ReferenceSystem"/>.
    /// </summary>
    public MD_ReferenceSystem() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _referenceSystemIdentifier = default; // new RS_Identifier();

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
