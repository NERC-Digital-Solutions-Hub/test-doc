
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 04:45, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Xml.XLink;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Base {

  /// <summary>
  /// 
  /// </summary>
  [Obsolete()]
  [Serializable]
  [XmlType("AssociationRoleType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AssociationRoleType")]
  public class AssociationRoleType : Model, IOwnershipAttributeGroup, IAssociation {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AssociationRoleType"/>.
    /// </summary>
    public AssociationRoleType() {
      _owns = default; //  false;
    }

    #endregion

    #region Public Properties

    private object _abstractObject;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractObject", Order = 0)]
    [JsonProperty("AbstractObject", Order = 0)]
    public object AbstractObject {
      get {
        return _abstractObject;
      }
      set {
        if (_abstractObject == value) {
          return;
        }
        if (_abstractObject == null || _abstractObject.Equals(value) != true) {
          _abstractObject = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IOwnershipAttributeGroup

    private bool _owns;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("owns")]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IAssociationAttributeGroup

    private string _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "type", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    public string Type {
      get {
        return _type;
      }
      set {
        if (_type == value) {
          return;
        }
        if (_type == null || _type.Equals(value) != true) {
          _type = value;
          OnPropertyChanged();
        }
      }
    }

    private string _href;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "href", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
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
    [XmlAttribute(AttributeName = "role", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
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

    private string _arcrole;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "arcrole", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
    [JsonProperty("arcrole")]
    public string ArcRole {
      get {
        return _arcrole;
      }
      set {
        if (_arcrole == value) {
          return;
        }
        if (_arcrole == null || _arcrole.Equals(value) != true) {
          _arcrole = value;
          OnPropertyChanged();
        }
      }
    }

    private string _title;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "title", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
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
    [XmlAttribute(AttributeName = "show", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
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
    [XmlAttribute(AttributeName = "actuate", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
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
    [XmlAttribute("nilReason")]
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
    [XmlAttribute("remoteSchema", Form = XmlSchemaForm.Qualified, DataType = "anyURI")]
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

  }

}
