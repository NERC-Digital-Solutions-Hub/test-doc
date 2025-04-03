
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/maintenance.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MD_MaintenanceInformation_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="maintenanceAndUpdateFrequency"
//                     type="gmd:MD_MaintenanceFrequencyCode_PropertyType"/>
//         <xs:element name="dateOfNextUpdate"
//                     type="gco:Date_PropertyType" minOccurs="0"/>
//         <xs:element name="userDefinedMaintenanceFrequency"
//                     type="gts:TM_PeriodDuration_PropertyType" minOccurs="0"/>
//         <xs:element name="updateScope"
//                     type="gmd:MD_ScopeCode_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="updateScopeDescription"
//                     type="gmd:MD_ScopeDescription_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="maintenanceNote"
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="contact"
//                     type="gmd:CI_ResponsibleParty_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="MD_MaintenanceInformation" type="gmd:MD_MaintenanceInformation_Type"/>
// <xs:complexType name="MD_MaintenanceInformation_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_MaintenanceInformation"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.DateTime;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Citation;

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

namespace NDSH.Geospatial.Metadata.Maintenance {

  /// <summary>
  /// Information about the scope and frequency of updating.
  /// </summary>
  [Serializable]
  //[XmlType("MD_MaintenanceInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_MaintenanceInformation", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_MaintenanceInformation")]
  public class MD_MaintenanceInformation_Type : MetadataObject,
    IComparable<MD_MaintenanceInformation_Type>,
    IEquatable<MD_MaintenanceInformation_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_MaintenanceInformation_Type"/>.
    /// </summary>
    public MD_MaintenanceInformation_Type() {
      _maintenanceAndUpdateFrequency = default; //  new MD_MaintenanceFrequencyCode_PropertyType();
      _dateOfNextUpdate = default; //  new Date_PropertyType();
      _userDefinedMaintenanceFrequency = default; //  new TM_PeriodDuration_PropertyType();
      _updateScope = default; //  new List<MD_ScopeCode_PropertyType>();
      _updateScopeDescription = default; //  new List<MD_ScopeDescription_PropertyType>();
      _maintenanceNote = default; //  new List<CharacterString>();
      _contact = default; //  new List<CI_ResponsibleParty_Type>();
    }

    #endregion

    #region Public Properties

    private MD_MaintenanceFrequencyCode_CodeList _maintenanceAndUpdateFrequency;

    /// <summary>
    /// Frequency with which changes and additions are made to the resource after the initial resource is completed.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("maintenanceAndUpdateFrequency", Order = 0)]
    [JsonProperty("maintenanceAndUpdateFrequency", Order = 0)]
    public MD_MaintenanceFrequencyCode_CodeList MaintenanceAndUpdateFrequency {
      get => _maintenanceAndUpdateFrequency;
      set => SetProperty(ref _maintenanceAndUpdateFrequency, value);
    }

    private DateDbEntity? _dateOfNextUpdate;

    /// <summary>
    /// Scheduled revision date for resource.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("dateOfNextUpdate", Order = 1)]
    [JsonProperty("dateOfNextUpdate", Order = 1)]
    public DateDbEntity? DateOfNextUpdate {
      get => _dateOfNextUpdate;
      set => SetProperty(ref _dateOfNextUpdate, value);
    }

    private TM_PeriodDuration_PropertyType? _userDefinedMaintenanceFrequency;

    /// <summary>
    /// Maintenance period other than those defined.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("userDefinedMaintenanceFrequency", Order = 2)]
    [JsonProperty("userDefinedMaintenanceFrequency", Order = 2)]
    public TM_PeriodDuration_PropertyType? UserDefinedMaintenanceFrequency {
      get => _userDefinedMaintenanceFrequency;
      set => SetProperty(ref _userDefinedMaintenanceFrequency, value);
    }

    private ObservableCollection<MD_ScopeCode_CodeList>? _updateScope;

    /// <summary>
    /// Scope of data to which maintenance is applied.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("updateScope", Order = 3)]
    [JsonProperty("updateScope", Order = 3)]
    public ObservableCollection<MD_ScopeCode_CodeList>? UpdateScope {
      get => _updateScope;
      set => SetProperty(ref _updateScope, value);
    }

    private ObservableCollection<MD_ScopeDescription_Type>? _updateScopeDescription;

    /// <summary>
    /// Additional information about the range or extent of the resource.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("updateScopeDescription", Order = 4)]
    [JsonProperty("updateScopeDescription", Order = 4)]
    public ObservableCollection<MD_ScopeDescription_Type>? UpdateScopeDescription {
      get => _updateScopeDescription;
      set => SetProperty(ref _updateScopeDescription, value);
    }

    private ObservableCollection<CharacterString>? _maintenanceNote;

    /// <summary>
    /// Information regarding specific requirements for maintaining the resource.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("maintenanceNote", Order = 5)]
    [JsonProperty("maintenanceNote", Order = 5)]
    public ObservableCollection<CharacterString>? MaintenanceNote {
      get => _maintenanceNote;
      set => SetProperty(ref _maintenanceNote, value);
    }

    private ObservableCollection<CI_ResponsibleParty_Type>? _contact;

    /// <summary>
    /// Identification of, and means of communicating with,
    /// person(s) and organization(s) with responsibility for maintaining the metadata.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("contact", Order = 6)]
    [JsonProperty("contact", Order = 6)]
    public ObservableCollection<CI_ResponsibleParty_Type>? Contact {
      get => _contact;
      set => SetProperty(ref _contact, value);
    }

    #endregion

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_MaintenanceInformation_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_MaintenanceInformation_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(MD_MaintenanceInformation_Type? other) {
      int result;

      return
        (other is null) ? 1 :
        (result = MaintenanceAndUpdateFrequency?.CompareTo(other.MaintenanceAndUpdateFrequency) ?? 1) != 0 ? result :
        (result = DateOfNextUpdate?.CompareTo(other.DateOfNextUpdate) ?? 1) != 0 ? result :
        //(result = UserDefinedMaintenanceFrequency?.CompareTo(other.UserDefinedMaintenanceFrequency) ?? 1) != 0 ? result : // TODO: Implement!
        (result = UpdateScope?.Count.CompareTo(other.UpdateScope?.Count ?? 0) ?? 1) != 0 ? result :
        (result = UpdateScopeDescription?.Count.CompareTo(
          other.UpdateScopeDescription?.Count ?? 0
        ) ?? 1) != 0 ? result :
        (result = MaintenanceNote?.Count.CompareTo(other.MaintenanceNote?.Count ?? 0) ?? 1) != 0 ? result :
        Contact?.Count.CompareTo(other.Contact?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="MD_MaintenanceInformation_Type"/>
    /// is equal to the current <see cref="MD_MaintenanceInformation_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="MD_MaintenanceInformation_Type"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.
    /// </returns>
    public bool Equals(MD_MaintenanceInformation_Type? other) {
      return other != null &&
         Equals(MaintenanceAndUpdateFrequency, other.MaintenanceAndUpdateFrequency) &&
         Equals(DateOfNextUpdate, other.DateOfNextUpdate) &&
         Equals(UserDefinedMaintenanceFrequency, other.UserDefinedMaintenanceFrequency) &&
         UpdateScope.SequenceEqualOrdered(other.UpdateScope) &&
         UpdateScopeDescription.SequenceEqualOrdered(other.UpdateScopeDescription) &&
         MaintenanceNote.SequenceEqualOrdered(other.MaintenanceNote) &&
         Contact.SequenceEqualOrdered(other.Contact);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/>
    /// is equal to the current <see cref="MD_MaintenanceInformation_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) =>
      Equals(obj as MD_MaintenanceInformation_Type);

    /// <summary>
    /// Gets the hash code for the <see cref="MD_MaintenanceInformation_Type"/> using <see cref="NdshHashCode"/>.
    /// This will also order collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(MaintenanceAndUpdateFrequency);
      hash.Add(DateOfNextUpdate);
      hash.Add(UserDefinedMaintenanceFrequency);

      foreach (MD_ScopeCode_CodeList scope in UpdateScope.SafeOrderBy()) {
        hash.Add(scope);
      }

      foreach (MD_ScopeDescription_Type scopeDescription in UpdateScopeDescription.SafeOrderBy()) {
        hash.Add(scopeDescription);
      }

      foreach (CharacterString note in MaintenanceNote.SafeOrderBy()) {
        hash.Add(note);
      }

      foreach (CI_ResponsibleParty_Type responsibleParty in Contact.SafeOrderBy()) {
        hash.Add(responsibleParty);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
