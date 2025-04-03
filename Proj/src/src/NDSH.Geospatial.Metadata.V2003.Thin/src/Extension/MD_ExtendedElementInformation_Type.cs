
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 00:43, @gisvlasta.
// Updated by        : 09/01/2023, 19:18, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Thin.Common;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Extension {

  /// <summary>
  /// New metadata element, not found in ISO 19115, which is required to describe geographic data.
  /// </summary>
  [Serializable]
  [XmlType("MD_ExtendedElementInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_ExtendedElementInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ExtendedElementInformation")]
  public class MD_ExtendedElementInformation_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ExtendedElementInformation_Type"/>.
    /// </summary>
    public MD_ExtendedElementInformation_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name  = default; //  new CharacterString_PropertyType();
      _shortName  = default; //  new CharacterString_PropertyType();
      _domainCode  = default; //  new Integer_PropertyType();
      _definition  = default; //  new CharacterString_PropertyType();
      _obligation  = default; //  new MD_ObligationCode_PropertyType();
      _condition  = default; //  new CharacterString_PropertyType();
      _dataType  = default; //  new MD_DatatypeCode_PropertyType();
      _maximumOccurrence  = default; //  new CharacterString_PropertyType();
      _domainValue  = default; //  new CharacterString_PropertyType();
      _parentEntity  = default; //  new List<CharacterString_PropertyType>();
      _rule  = default; //  new CharacterString_PropertyType();
      _rationale  = default; //  new List<CharacterString_PropertyType>();
      _source  = default; //  new List<CI_ResponsibleParty_PropertyType>();

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

    private CharacterString _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
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

    private CharacterString _shortName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("shortName", Order = 1)]
    [JsonProperty("shortName", Order = 1)]
    public CharacterString ShortName {
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

    private Integer_PropertyType _domainCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("domainCode", Order = 2)]
    [JsonProperty("domainCode", Order = 2)]
    public Integer_PropertyType DomainCode {
      get {
        return _domainCode;
      }
      set {
        if (_domainCode == value) {
          return;
        }
        if (_domainCode == null || _domainCode.Equals(value) != true) {
          _domainCode = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _definition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("definition", Order = 3)]
    [JsonProperty("definition", Order = 3)]
    public CharacterString Definition {
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

    private MD_ObligationCode_PropertyType _obligation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("obligation", Order = 4)]
    [JsonProperty("obligation", Order = 4)]
    public MD_ObligationCode_PropertyType Obligation {
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

    private CharacterString _condition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("condition", Order = 5)]
    [JsonProperty("condition", Order = 5)]
    public CharacterString Condition {
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

    private MD_DatatypeCode_PropertyType _dataType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dataType", Order = 6)]
    [JsonProperty("dataType", Order = 6)]
    public MD_DatatypeCode_PropertyType DataType {
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

    private CharacterString _maximumOccurrence;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("maximumOccurrence", Order = 7)]
    [JsonProperty("maximumOccurrence", Order = 7)]
    public CharacterString MaximumOccurrence {
      get {
        return _maximumOccurrence;
      }
      set {
        if (_maximumOccurrence == value) {
          return;
        }
        if (_maximumOccurrence == null || _maximumOccurrence.Equals(value) != true) {
          _maximumOccurrence = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _domainValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("domainValue", Order = 8)]
    [JsonProperty("domainValue", Order = 8)]
    public CharacterString DomainValue {
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

    private List<CharacterString> _parentEntity;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("parentEntity", Order = 9)]
    [JsonProperty("parentEntity", Order = 9)]
    public List<CharacterString> ParentEntity {
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

    private CharacterString _rule;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rule", Order = 10)]
    [JsonProperty("rule", Order = 10)]
    public CharacterString Rule {
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

    private List<CharacterString> _rationale;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rationale", Order = 11)]
    [JsonProperty("rationale", Order = 11)]
    public List<CharacterString> Rationale {
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

    private List<CI_ResponsibleParty_PropertyType> _source;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("source", Order = 12)]
    [JsonProperty("source", Order = 12)]
    public List<CI_ResponsibleParty_PropertyType> Source {
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

    #endregion

  }

}