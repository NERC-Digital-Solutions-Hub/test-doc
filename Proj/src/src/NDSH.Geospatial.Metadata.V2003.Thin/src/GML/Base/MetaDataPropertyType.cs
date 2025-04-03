
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 03:51, @gisvlasta.
// Updated by        : 09/01/2023, 00:27, @gisvlasta.
//                     1.0.1 - Added code in IAssociationAttributeGroup interface.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// XSD               : /2005/gml/gmlBase.xsd
// --------------------------------------------------------------------------------
// <complexType name="MetaDataPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractMetaData"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attribute name="about" type="anyURI"/>
// </complexType>
// <attributeGroup name="AssociationAttributeGroup">
//   <annotation>
//     <documentation>
//       XLink components are the standard method to support hypertext referencing in XML. An XML Schema attribute group, gml:AssociationAttributeGroup, is provided to support the use of Xlinks as the method for indicating the value of a property by reference in a uniform manner in GML.
//     </documentation>
//   </annotation>
//   <attributeGroup ref="xlink:simpleLink"/>
//   <attribute name="nilReason" type="gml:NilReasonType"/>
//   <attribute ref="gml:remoteSchema"/>
// </attributeGroup>
#endregion

#region Imported Namespaces


using NDSH.Xml.XLink;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Base {

  // TODO: check id attributes MUST be qualified and if DataTypes must be defined.

  /// <summary>
  /// 
  /// </summary>
  [Obsolete()]
  [Serializable]
  [XmlType("MetaDataPropertyType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MetaDataPropertyType")]
  public class MetaDataPropertyType : Model, IAssociation { // TODO: Extract the correct Interfaces.

    private AbstractMetaDataType _abstractMetaData;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractMetaData", Order = 0)]
    [JsonProperty("AbstractMetaData", Order = 0)]
    public AbstractMetaDataType AbstractMetaData {
      get {
        return _abstractMetaData;
      }
      set {
        if (_abstractMetaData == value) {
          return;
        }
        if (_abstractMetaData == null || _abstractMetaData.Equals(value) != true) {
          _abstractMetaData = value;
          OnPropertyChanged();
        }
      }
    }

    #region IAssociationAttributeGroup Interface

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "type", DataType = "string", Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("type")]
    public string Type => "simple";

    private string _href;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("href", DataType = "anyURI", Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("href")]
    public string Href {
      get {
        return _href;
      }
      set {
        if (_href == value) {
          return;
        }
        if (_href == null || _href.Equals(value) != true) {
          _href = value;
          OnPropertyChanged();
        }
      }
    }

    private string _role;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("role", DataType = "anyURI", Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("role")]
    public string Role {
      get {
        return _role;
      }
      set {
        if (_role == value) {
          return;
        }
        if (_role == null || _role.Equals(value) != true) {
          _role = value;
          OnPropertyChanged();
        }
      }
    }

    private string _arcRole;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("arcrole", DataType = "anyURI", Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("arcrole")]
    public string ArcRole {
      get {
        return _arcRole;
      }
      set {
        if (_arcRole == value) {
          return;
        }
        if (_arcRole == null || _arcRole.Equals(value) != true) {
          _arcRole = value;
          OnPropertyChanged();
        }
      }
    }

    private string _title;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("title", DataType = "string", Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("title")]
    public string Title {
      get {
        return _title;
      }
      set {
        if (_title == value) {
          return;
        }
        if (_title == null || _title.Equals(value) != true) {
          _title = value;
          OnPropertyChanged();
        }
      }
    }

    private string _show;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("show", Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("show")]
    public string Show {
      get {
        return _show;
      }
      set {
        if (_show.Equals(value) != true) {
          _show = value;
          OnPropertyChanged();
        }
      }
    }

    private string _actuate;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("actuate", Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("actuate")]
    public string Actuate {
      get {
        return _actuate;
      }
      set {
        if (_actuate.Equals(value) != true) {
          _actuate = value;
          OnPropertyChanged();
        }
      }
    }

    private string _nilReason;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("nilReason")] // TODO: Should nilReason have a DataType?
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged();
        }
      }
    }

    private string _remoteSchema;

    /// <summary>
    /// 
    /// </summary>
    [Obsolete()]
    [XmlIgnore] // Ignored because it is obsolete.
    [XmlAttribute("remoteSchema", DataType = "anyURI", Form = XmlSchemaForm.Qualified)]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    private string _about;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("about", DataType = "anyURI")]
    [JsonProperty("about")]
    public string About {
      get {
        return _about;
      }
      set {
        if (_about == value) {
          return;
        }
        if (_about == null || _about.Equals(value) != true) {
          _about = value;
          OnPropertyChanged();
        }
      }
    }

  }

}
