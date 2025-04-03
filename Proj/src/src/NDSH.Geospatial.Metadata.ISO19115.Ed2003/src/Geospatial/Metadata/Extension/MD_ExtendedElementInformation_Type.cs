
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataExtension.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_ExtendedElementInformation_Type">
//   <xs:annotation>
//     <xs:documentation>New metadata element, not found in ISO 19115, which is required to describe geographic data</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="name" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="shortName" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="domainCode" type="gco:Integer_PropertyType" minOccurs="0"/>
//         <xs:element name="definition" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="obligation" type="gmd:MD_ObligationCode_PropertyType" minOccurs="0"/>
//         <xs:element name="condition" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="dataType" type="gmd:MD_DatatypeCode_PropertyType"/>
//         <xs:element name="maximumOccurrence" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="domainValue" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="parentEntity" type="gco:CharacterString_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="rule" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="rationale" type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="source" type="gmd:CI_ResponsibleParty_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_ExtendedElementInformation" type="gmd:MD_ExtendedElementInformation_Type"/>
// <xs:complexType name="MD_ExtendedElementInformation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_ExtendedElementInformation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Extension {

  /// <summary>
  /// New metadata element, not found in ISO 19115, which is required to describe geographic data.
  /// </summary>
  [Serializable]
  //[XmlType("MD_ExtendedElementInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_ExtendedElementInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ExtendedElementInformation")]
  public class MD_ExtendedElementInformation_Type : MetadataObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ExtendedElementInformation_Type"/>.
    /// </summary>
    public MD_ExtendedElementInformation_Type() {
      _name = default; //  new CharacterString();
      _shortName = default; //  new CharacterString();
      _domainCode = default; //  new Integer_PropertyType();
      _definition = default; //  new CharacterString();
      _obligation = default; //  new MD_ObligationCode_PropertyType();
      _condition = default; //  new CharacterString();
      _dataType = default; //  new MD_DatatypeCode_PropertyType();
      _maximumOccurrence = default; //  new CharacterString();
      _domainValue = default; //  new CharacterString();
      _parentEntity = default; //  new List<CharacterString>();
      _rule = default; //  new CharacterString();
      _rationale = default; //  new List<CharacterString>();
      _source = default; //  new List<CI_ResponsibleParty_Type>();
    }

    #endregion

    #region Public Properties

    private CharacterString _name;

    /// <summary>
    /// Name of the extended metadata element.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private CharacterString? _shortName;

    /// <summary>
    /// Short form suitable for use in an implementation method such as XML or SGML.
    /// </summary>
    /// <remarks>Other methods may be used.</remarks>
    // TODO: OBL - C (dataType not equal "codelistElement?)
    // TODO: CAR - 1
    //[XmlElement("shortName", Order = 1)]
    [JsonProperty("shortName", Order = 1)]
    public CharacterString? ShortName {
      get => _shortName;
      set => SetProperty(ref _shortName, value);
    }

    private int? _domainCode;

    /// <summary>
    /// Three digit code assigned to the extended element.
    /// </summary>
    // TODO: OBL - C (is dataType codelistElement?)
    // TODO: CAR - 1
    //[XmlElement("domainCode", Order = 2)]
    [JsonProperty("domainCode", Order = 2)]
    public int? DomainCode {
      get => _domainCode;
      // TODO: SetProperty
      set {
        if (_domainCode == value) {
          return;
        }
        if (/*_domainCode == null || */_domainCode.Equals(value) != true) {
          _domainCode = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _definition;

    /// <summary>
    /// Definition of the extended element.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("definition", Order = 3)]
    [JsonProperty("definition", Order = 3)]
    public CharacterString Definition {
      get => _definition;
      set => SetProperty(ref _definition, value);
    }

    private MD_ObligationCode_PropertyType? _obligation;

    /// <summary>
    /// Obligation of the extended element.
    /// </summary>
    // TODO: OBL - C (dataType is not "codelist", "enumeration" or "codelistElement"?)
    // TODO: CAR - 1
    //[XmlElement("obligation", Order = 4)]
    [JsonProperty("obligation", Order = 4)]
    public MD_ObligationCode_PropertyType? Obligation {
      get => _obligation;
      set => SetProperty(ref _obligation, value);
    }

    private CharacterString? _condition;

    /// <summary>
    /// Condition under which the extended element is mandatory.
    /// </summary>
    // TODO: OBL - C (obligation = "Conditional"?)
    // TODO: CAR - 1
    //[XmlElement("condition", Order = 5)]
    [JsonProperty("condition", Order = 5)]
    public CharacterString? Condition {
      get => _condition;
      set => SetProperty(ref _condition, value);
    }

    private MD_DatatypeCode_CodeList _dataType;

    /// <summary>
    /// Code which identifies the kind of value provided in the extended element.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("dataType", Order = 6)]
    [JsonProperty("dataType", Order = 6)]
    public MD_DatatypeCode_CodeList DataType {
      get => _dataType;
      set => SetProperty(ref _dataType, value);
    }

    private CharacterString? _maximumOccurrence;

    /// <summary>
    /// Maximum occurrence of the extended element.
    /// </summary>
    // TODO: OBL - C (dataType not "codelist", "enumeration" or "codelistElement"?)
    // TODO: CAR - 1
    //[XmlElement("maximumOccurrence", Order = 7)]
    [JsonProperty("maximumOccurrence", Order = 7)]
    public CharacterString? MaximumOccurrence {
      get => _maximumOccurrence;
      set => SetProperty(ref _maximumOccurrence, value);
    }

    private CharacterString? _domainValue;

    /// <summary>
    /// Valid values that can be assigned to the extended element.
    /// </summary>
    // TODO: OBL - C (dataType not "codelist", "enumeration" or "codelistElement"?)
    // TODO: CAR - 1
    //[XmlElement("domainValue", Order = 8)]
    [JsonProperty("domainValue", Order = 8)]
    public CharacterString? DomainValue {
      get => _domainValue;
      set => SetProperty(ref _domainValue, value);
    }

    private ObservableCollection<CharacterString> _parentEntity;

    /// <summary>
    /// Name of the metadata entity(s) under which this extended metadata element may appear.
    /// The name(s) may be standard metadata element(s) or other extended metadata element(s).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("parentEntity", Order = 9)]
    [JsonProperty("parentEntity", Order = 9)]
    public ObservableCollection<CharacterString> ParentEntity {
      get => _parentEntity;
      set => SetProperty(ref _parentEntity, value);
    }

    private CharacterString _rule;

    /// <summary>
    /// Specifies how the extended element relates to other existing elements and entities.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("rule", Order = 10)]
    [JsonProperty("rule", Order = 10)]
    public CharacterString Rule {
      get => _rule;
      set => SetProperty(ref _rule, value);
    }

    private ObservableCollection<CharacterString>? _rationale;

    /// <summary>
    /// Reason for creating the extended element.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("rationale", Order = 11)]
    [JsonProperty("rationale", Order = 11)]
    public ObservableCollection<CharacterString>? Rationale {
      get => _rationale;
      set => SetProperty(ref _rationale, value);
    }

    private ObservableCollection<CI_ResponsibleParty_Type> _source;

    /// <summary>
    /// Name of the person or organisation creating the extended element.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("source", Order = 12)]
    [JsonProperty("source", Order = 12)]
    public ObservableCollection<CI_ResponsibleParty_Type> Source {
      get => _source;
      set => SetProperty(ref _source, value);
    }

    #endregion

  }

}
