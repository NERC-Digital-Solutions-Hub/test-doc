
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 18/12/2022, 03:57, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
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

namespace NDSH.Geospatial.Metadata.V2005.Extension {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("MD_ExtendedElementInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("MD_ExtendedElementInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ExtendedElementInformation")]
  public class MD_ExtendedElementInformation : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ExtendedElementInformation"/>.
    /// </summary>
    public MD_ExtendedElementInformation() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name = default;
      _shortName = default;
      _domainCode = default;
      _definition = default;
      _obligation = default; //new MD_ObligationCode();
      _condition = default;
      _dataType = default; //new MD_DatatypeCode();
      _maximumOccurence = default;
      _domainValue = default;
      _parentEntity = default; //new List<string>();
      _rule = default;
      _rationale = default; //new List<string>();
      _source = default; //new List<CI_ResponsibleParty>();

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

    private string _name;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "name")]
    [JsonProperty("name", Order = 0)]
    public string Name {
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

    private string _shortName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "shortName")]
    [JsonProperty("shortName", Order = 1)]
    public string ShortName {
      get {
        return _shortName;
      }
      set {
        if (_shortName == value) {
          return;
        }
        if (_shortName == null || _shortName.Equals(value) != true) {
          _shortName = value;
          OnPropertyChanged();
        }
      }
    }

    private int _domainCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "domainCode")]
    [RequiredAttribute()]
    [JsonProperty("domainCode", Order = 2)]
    public int DomainCode {
      get {
        return _domainCode;
      }
      set {
        if (_domainCode.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "DomainCode";
          Validator.ValidateProperty(value, validatorPropContext);
          _domainCode = value;
          OnPropertyChanged();
        }
      }
    }

    private string _definition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "definition")]
    [JsonProperty("definition", Order = 3)]
    public string Definition {
      get {
        return _definition;
      }
      set {
        if (_definition == value) {
          return;
        }
        if (_definition == null || _definition.Equals(value) != true) {
          _definition = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_ObligationCode _obligation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4, ElementName = "obligation")]
    [JsonProperty("obligation", Order = 4)]
    public MD_ObligationCode Obligation {
      get {
        return _obligation;
      }
      set {
        if (_obligation == value) {
          return;
        }
        if (_obligation == null || _obligation.Equals(value) != true) {
          _obligation = value;
          OnPropertyChanged();
        }
      }
    }

    private string _condition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5, ElementName = "condition")]
    [JsonProperty("condition", Order = 5)]
    public string Condition {
      get {
        return _condition;
      }
      set {
        if (_condition == value) {
          return;
        }
        if (_condition == null || _condition.Equals(value) != true) {
          _condition = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_DatatypeCode _dataType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6, ElementName = "dataType")]
    [JsonProperty("dataType", Order = 6)]
    public MD_DatatypeCode DataType {
      get {
        return _dataType;
      }
      set {
        if (_dataType == value) {
          return;
        }
        if (_dataType == null || _dataType.Equals(value) != true) {
          _dataType = value;
          OnPropertyChanged();
        }
      }
    }

    private string _maximumOccurence;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7, ElementName = "maximumOccurence")]
    [JsonProperty("maximumOccurence", Order = 7)]
    public string MaximumOccurence {
      get {
        return _maximumOccurence;
      }
      set {
        if (_maximumOccurence == value) {
          return;
        }
        if (_maximumOccurence == null || _maximumOccurence.Equals(value) != true) {
          _maximumOccurence = value;
          OnPropertyChanged();
        }
      }
    }

    private string _domainValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8, ElementName = "domainValue")]
    [JsonProperty("domainValue", Order = 8)]
    public string DomainValue {
      get {
        return _domainValue;
      }
      set {
        if (_domainValue == value) {
          return;
        }
        if (_domainValue == null || _domainValue.Equals(value) != true) {
          _domainValue = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _parentEntity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("parentEntity", Order = 9, ElementName = "parentEntity")]
    [JsonProperty("parentEntity", Order = 9)]
    public List<string> ParentEntity {
      get {
        return _parentEntity;
      }
      set {
        if (_parentEntity == value) {
          return;
        }
        if (_parentEntity == null || _parentEntity.Equals(value) != true) {
          _parentEntity = value;
          OnPropertyChanged();
        }
      }
    }

    private string _rule;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10, ElementName = "rule")]
    [JsonProperty("rule", Order = 10)]
    public string Rule {
      get {
        return _rule;
      }
      set {
        if (_rule == value) {
          return;
        }
        if (_rule == null || _rule.Equals(value) != true) {
          _rule = value;
          OnPropertyChanged();
        }
      }
    }

    private List<string> _rationale;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rationale", Order = 11, ElementName = "rationale")]
    [JsonProperty("rationale", Order = 11)]
    public List<string> Rationale {
      get {
        return _rationale;
      }
      set {
        if (_rationale == value) {
          return;
        }
        if (_rationale == null || _rationale.Equals(value) != true) {
          _rationale = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty> _source;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("source", Order = 12, ElementName = "source")]
    [JsonProperty("source", Order = 12)]
    public List<CI_ResponsibleParty> Source {
      get {
        return _source;
      }
      set {
        if (_source == value) {
          return;
        }
        if (_source == null || _source.Equals(value) != true) {
          _source = value;
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
