
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 20:42, @gisvlasta - Cleaned Xml Serialization Attributes. 
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2005.ReferenceSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
  [XmlRoot("SC_VerticalDatum", Namespace = "", IsNullable = false)] // TODO: Discover Correct Namespace
  [XmlType("SC_VerticalDatum", Namespace = "")] // TODO: Discover Correct Namespace
  [JsonObject("SC_VerticalDatum")]
  public class SC_VerticalDatum : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SC_VerticalDatum"/>.
    /// </summary>
    public SC_VerticalDatum() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd"); // TODO: Discover Correct Namespace

      _anchorDefinition = default;
      _realizationEpoch = default; // TODO: Is this a Nullable with null inital value?
      _domainOfValidity = default; //new EX_Extent();
      _scope = default; //new List<string>();
      _name = default; //new RS_Identifier();
      _alias = default; //new GenericName();
      _remarks = default;
      
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

    private string _anchorDefinition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "anchorDefinition")]
    [JsonProperty("anchorDefinition", Order = 0)]
    public string AnchorDefinition {
      get {
        return _anchorDefinition;
      }
      set {
        if (_anchorDefinition == value) {
          return;
        }
        if (_anchorDefinition == null || _anchorDefinition.Equals(value) != true) {
          _anchorDefinition = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime _realizationEpoch;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "realizationEpoch")]
    [RequiredAttribute()]
    [JsonProperty("realizationEpoch", Order = 1)]
    public DateTime RealizationEpoch { // TODO: Is this nullable with NULL initial value???
      get {
        return _realizationEpoch;
      }
      set {
        if (_realizationEpoch.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "RealizationEpoch";
          Validator.ValidateProperty(value, validatorPropContext);
          _realizationEpoch = value;
          OnPropertyChanged();
        }
      }
    }

    private EX_Extent _domainOfValidity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "domainOfValidity")]
    [JsonProperty("domainOfValidity", Order = 2)]
    public EX_Extent DomainOfValidity {
      get {
        return _domainOfValidity;
      }
      set {
        if (_domainOfValidity == value) {
          return;
        }
        if (_domainOfValidity == null || _domainOfValidity.Equals(value) != true) {
          _domainOfValidity = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _scope;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scope", Order = 3, ElementName = "scope")]
    [JsonProperty("scope", Order = 3)]
    public List<string> Scope {
      get {
        return _scope;
      }
      set {
        if (_scope == value) {
          return;
        }
        if (_scope == null || _scope.Equals(value) != true) {
          _scope = value;
          OnPropertyChanged();
        }
      }
    }

    private RS_Identifier _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "name")]
    [JsonProperty("name", Order = 4)]
    public RS_Identifier Name {
      get {
        return _name;
      }
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || _name.Equals(value) != true) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private GenericName _alias;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "alias")]
    [JsonProperty("alias", Order = 5)]
    public GenericName Alias {
      get {
        return _alias;
      }
      set {
        if (_alias == value) {
          return;
        }
        if (_alias == null || _alias.Equals(value) != true) {
          _alias = value;
          OnPropertyChanged();
        }
      }
    }

    private string _remarks;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6, ElementName = "remarks")]
    [JsonProperty("remarks", Order = 6)]
    public string Remarks {
      get {
        return _remarks;
      }
      set {
        if (_remarks == value) {
          return;
        }
        if (_remarks == null || _remarks.Equals(value) != true) {
          _remarks = value;
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
