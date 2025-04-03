#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/identification.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="AbstractMD_Identification_Type" abstract="true">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="citation"
//                     type="gmd:CI_Citation_PropertyType"/>
//         <xs:element name="abstract"
//                     type="gco:CharacterString_PropertyType"/>
//         <xs:element name="purpose"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="credit"
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="status"
//                     type="gmd:MD_ProgressCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="pointOfContact"
//                     type="gmd:CI_ResponsibleParty_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="resourceMaintenance"
//                     type="gmd:MD_MaintenanceInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="graphicOverview"
//                     type="gmd:MD_BrowseGraphic_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="resourceFormat"
//                     type="gmd:MD_Format_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="descriptiveKeywords"
//                     type="gmd:MD_Keywords_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="resourceSpecificUsage"
//                     type="gmd:MD_Usage_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="resourceConstraints"
//                     type="gmd:MD_Constraints_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="aggregationInfo"
//                     type="gmd:MD_AggregateInformation_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="AbstractMD_Identification" type="gmd:AbstractMD_Identification_Type" abstract="true"/>
// <xs:complexType name="MD_Identification_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:AbstractMD_Identification"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;
using NDSH.Geospatial.Metadata.Constraint;
using NDSH.Geospatial.Metadata.Distribution;
using NDSH.Geospatial.Metadata.Maintenance;
using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Identification {

  /// <summary>
  /// Basic information about data.
  /// </summary>
  [Serializable]
  //[XmlInclude(typeof(SV_ServiceIdentification_Type))]
  //[XmlInclude(typeof(MD_DataIdentification_Type))]
  //[XmlType("AbstractMD_Identification", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("AbstractMD_Identification", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractMD_Identification")]
  public abstract class AbstractMD_Identification_Type : MetadataObject, IComparable<AbstractMD_Identification_Type>, IEquatable<AbstractMD_Identification_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractMD_Identification_Type"/>.
    /// </summary>
    public AbstractMD_Identification_Type() {
      _citation = default; //  new CI_Citation_Type();
      _abstract = default; //  new CharacterString();
      _purpose = default; //  new CharacterString();
      _credit = default; //  new List<CharacterString>();
      _status = default; //  new List<MD_ProgressCode_PropertyType>();
      _pointOfContact = default; //  new List<CI_ResponsibleParty_Type>();
      _resourceMaintenance = default; //  new List<MD_MaintenanceInformation_Type>();
      _graphicOverview = default; //  new List<MD_BrowseGraphic_Type>();
      _resourceFormat = default; //  new List<MD_Format_Type>();
      _descriptiveKeywords = default; //  new List<MD_Keywords_Type>();
      _resourceSpecificUsage = default; //  new List<MD_Usage_Type>();
      _resourceConstraints = default; //  new List<MD_Constraints_Type>();
      _aggregationInfo = default; //  new List<MD_AggregateInformation_Type>();
    }

    #endregion

    #region Public Properties

    private CI_Citation_Type _citation;

    /// <summary>
    /// Citation data for the resource(s).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("citation", Order = 0)]
    [JsonProperty("citation", Order = 0)]
    public CI_Citation_Type Citation {
      get => _citation;
      set => SetProperty(ref _citation, value);
    }

    private CharacterString _abstract;

    /// <summary>
    /// Brief narrative summary of the content of the resource(s).
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("abstract", Order = 1)]
    [JsonProperty("abstract", Order = 1)]
    public CharacterString Abstract {
      get => _abstract;
      set => SetProperty(ref _abstract, value);
    }

    private CharacterString? _purpose;

    /// <summary>
    /// Summary of intentions with which the resource(s) was developed.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("purpose", Order = 2)]
    [JsonProperty("purpose", Order = 2)]
    public CharacterString? Purpose {
      get => _purpose;
      set => SetProperty(ref _purpose, value);
    }

    private ObservableCollection<CharacterString>? _credit;

    /// <summary>
    /// Recognition of those who contributed to the resource(s).
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("credit", Order = 3)]
    [JsonProperty("credit", Order = 3)]
    public ObservableCollection<CharacterString>? Credit {
      get => _credit;
      set => SetProperty(ref _credit, value);
    }

    private ObservableCollection<MD_ProgressCode_CodeList>? _status;

    /// <summary>
    /// Status of the resource(s).
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("status", Order = 4)]
    [JsonProperty("status", Order = 4)]
    public ObservableCollection<MD_ProgressCode_CodeList>? Status {
      get => _status;
      set => SetProperty(ref _status, value);
    }

    private ObservableCollection<CI_ResponsibleParty_Type>? _pointOfContact;

    /// <summary>
    /// Identification of, and means of communication with, person(s) and organization(s) associated with the resource(s).
    /// </summary>
    // TODO: OBL - O
    // TODO:  CAR - N
    //[XmlElement("pointOfContact", Order = 5)]
    [JsonProperty("pointOfContact", Order = 5)]
    public ObservableCollection<CI_ResponsibleParty_Type>? PointOfContact {
      get => _pointOfContact;
      set => SetProperty(ref _pointOfContact, value);
    }

    private ObservableCollection<MD_MaintenanceInformation_Type>? _resourceMaintenance;

    /// <summary>
    /// Provides information about the frequency of resource updates, and the scope of those updates.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("resourceMaintenance", Order = 6)]
    [JsonProperty("resourceMaintenance", Order = 6)]
    public ObservableCollection<MD_MaintenanceInformation_Type>? ResourceMaintenance {
      get => _resourceMaintenance;
      set => SetProperty(ref _resourceMaintenance, value);
    }

    private ObservableCollection<MD_BrowseGraphic_Type>? _graphicOverview;

    /// <summary>
    /// Provides a graphic that illustrates the resource(s).
    /// </summary>
    /// <remarks>Should include a legend for the graphic.</remarks>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("graphicOverview", Order = 7)]
    [JsonProperty("graphicOverview", Order = 7)]
    public ObservableCollection<MD_BrowseGraphic_Type>? GraphicOverview {
      get => _graphicOverview;
      set => SetProperty(ref _graphicOverview, value);
    }

    private ObservableCollection<MD_Format_Type>? _resourceFormat;

    /// <summary>
    /// Provides a description of the format of the resource(s).
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("resourceFormat", Order = 8)]
    [JsonProperty("resourceFormat", Order = 8)]
    public ObservableCollection<MD_Format_Type>? ResourceFormat {
      get => _resourceFormat;
      set => SetProperty(ref _resourceFormat, value);
    }

    private ObservableCollection<MD_Keywords_Type>? _descriptiveKeywords;

    /// <summary>
    /// Provides category keywords, their type, and reference source.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("descriptiveKeywords", Order = 9)]
    [JsonProperty("descriptiveKeywords", Order = 9)]
    public ObservableCollection<MD_Keywords_Type>? DescriptiveKeywords {
      get => _descriptiveKeywords;
      set => SetProperty(ref _descriptiveKeywords, value);
    }

    private ObservableCollection<MD_Usage_Type>? _resourceSpecificUsage;

    /// <summary>
    /// Provides basic information about specific application(s) for which the resource(s) has/have been or is being used by different users.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("resourceSpecificUsage", Order = 10)]
    [JsonProperty("resourceSpecificUsage", Order = 10)]
    public ObservableCollection<MD_Usage_Type>? ResourceSpecificUsage {
      get => _resourceSpecificUsage;
      set => SetProperty(ref _resourceSpecificUsage, value);
    }

    private ObservableCollection<MD_Constraints_Type>? _resourceConstraints;

    /// <summary>
    /// Provides information about constraints which apply to the resource(s).
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR -N
    //[XmlElement("resourceConstraints", Order = 11)]
    [JsonProperty("resourceConstraints", Order = 11)]
    public ObservableCollection<MD_Constraints_Type>? ResourceConstraints {
      get => _resourceConstraints;
      set => SetProperty(ref _resourceConstraints, value);
    }

    private ObservableCollection<MD_AggregateInformation_Type>? _aggregationInfo;

    /// <summary>
    /// Provides aggregate dataset information.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("aggregationInfo", Order = 12)]
    [JsonProperty("aggregationInfo", Order = 12)]
    public ObservableCollection<MD_AggregateInformation_Type>? AggregationInfo {
      get => _aggregationInfo;
      set => SetProperty(ref _aggregationInfo, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="AbstractMD_Identification_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="AbstractMD_Identification_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public virtual int CompareTo(AbstractMD_Identification_Type? other) {
      int result;

      return
          (other is null) ? 1 :
          (result = Citation.CompareTo(other.Citation)) != 0 ? result :
          (result = Abstract.CompareTo(other.Abstract)) != 0 ? result :
          (result = Purpose?.CompareTo(other.Purpose) ?? 1) != 0 ? result :
          (result = Credit?.Count.CompareTo(other.Credit?.Count ?? 0) ?? 1) != 0 ? result :
          (result = Status?.Count.CompareTo(other.Status?.Count ?? 0) ?? 1) != 0 ? result :
          (result = PointOfContact?.Count.CompareTo(other.PointOfContact?.Count ?? 0) ?? 1) != 0 ? result :
          (result = ResourceMaintenance?.Count.CompareTo(other.ResourceMaintenance?.Count ?? 0) ?? 1) != 0 ? result :
          (result = GraphicOverview?.Count.CompareTo(other.GraphicOverview?.Count ?? 0) ?? 1) != 0 ? result :
          (result = ResourceFormat?.Count.CompareTo(other.ResourceFormat?.Count ?? 0) ?? 0) != 0 ? result :
          (result = DescriptiveKeywords?.Count.CompareTo(other.DescriptiveKeywords?.Count ?? 0) ?? 1) != 0 ? result :
          (result = ResourceSpecificUsage?.Count.CompareTo(other.ResourceSpecificUsage?.Count ?? 0) ?? 1) != 0 ? result :
          (result = ResourceConstraints?.Count.CompareTo(other.ResourceConstraints?.Count ?? 0) ?? 1) != 0 ? result :
          AggregationInfo?.Count.CompareTo(other.AggregationInfo?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="AbstractMD_Identification_Type"/> is equal to the current <see cref="AbstractMD_Identification_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="AbstractMD_Identification_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public virtual bool Equals(AbstractMD_Identification_Type? other) {
      return other != null &&
          Equals(Citation, other.Citation) &&
          Equals(Abstract, other.Abstract) &&
          Equals(Purpose, other.Purpose) &&
          Credit.SequenceEqualOrdered(other.Credit) &&
          Status.SequenceEqualOrdered(other.Status) &&
          PointOfContact.SequenceEqualOrdered(other.PointOfContact) &&
          ResourceMaintenance.SequenceEqualOrdered(other.ResourceMaintenance) &&
          GraphicOverview.SequenceEqualOrdered(other.GraphicOverview) &&
          ResourceFormat.SequenceEqualOrdered(other.ResourceFormat) &&
          DescriptiveKeywords.SequenceEqualOrdered(other.DescriptiveKeywords) &&
          ResourceSpecificUsage.SequenceEqualOrdered(other.ResourceSpecificUsage) &&
          ResourceConstraints.SequenceEqualOrdered(other.ResourceConstraints) &&
          AggregationInfo.SequenceEqualOrdered(other.AggregationInfo);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="AbstractMD_Identification_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as AbstractMD_Identification_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="AbstractMD_Identification_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Citation);
      hash.Add(Abstract);
      hash.Add(Purpose);

      foreach (CharacterString characterString in Credit.SafeOrderBy()) {
        hash.Add(characterString);
      }

      foreach (MD_ProgressCode_CodeList status in Status.SafeOrderBy()) {
        hash.Add(status);
      }

      foreach (CI_ResponsibleParty_Type pointOfContact in PointOfContact.SafeOrderBy()) {
        hash.Add(pointOfContact);
      }

      foreach (MD_MaintenanceInformation_Type resourceMaintenance in ResourceMaintenance.SafeOrderBy()) {
        hash.Add(resourceMaintenance);
      }

      foreach (MD_BrowseGraphic_Type graphicOverview in GraphicOverview.SafeOrderBy()) {
        hash.Add(graphicOverview);
      }

      foreach (MD_Format_Type resourceFormat in ResourceFormat.SafeOrderBy()) {
        hash.Add(resourceFormat);
      }

      foreach (MD_Keywords_Type descriptiveKeywords in DescriptiveKeywords.SafeOrderBy()) {
        hash.Add(descriptiveKeywords);
      }

      foreach (MD_Usage_Type resourceSpecificUsage in ResourceSpecificUsage.SafeOrderBy()) {
        hash.Add(resourceSpecificUsage);
      }

      foreach (MD_Constraints_Type resourceConstraints in ResourceConstraints.SafeOrderBy()) {
        hash.Add(resourceConstraints);
      }

      foreach (MD_AggregateInformation_Type aggregationInfo in AggregationInfo.SafeOrderBy()) {
        hash.Add(aggregationInfo);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
