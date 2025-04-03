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
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="LI_ProcessStep_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="description" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="rationale" type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="dateTime" type="gco:DateTime_PropertyType" minOccurs="0"/>
//         <xs:element name="processor" type="gmd:CI_ResponsibleParty_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="source" type="gmd:LI_Source_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="LI_ProcessStep" type="gmd:LI_ProcessStep_Type"/>
// <xs:complexType name="LI_ProcessStep_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:LI_ProcessStep"/>
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

namespace NDSH.Geospatial.Metadata.DataQuality.Lineage {

  //[XmlInclude(typeof(LE_ProcessStep_Type))]
  [Serializable]
  //[XmlType("LI_ProcessStep", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("LI_ProcessStep", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("LI_ProcessStep")]
  public class LI_ProcessStep_Type : MetadataObject, IComparable<LI_ProcessStep_Type>, IEquatable<LI_ProcessStep_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_ProcessStep_Type"/>.
    /// </summary>
    public LI_ProcessStep_Type() {
      _description = default; //  new CharacterString();
      _rationale = default; //  new CharacterString();
      _dateTime = default; //  new DateTime_PropertyType();
      _processor = default; //  new List<CI_ResponsibleParty_Type>();
      _source = default; //  new List<LI_Source_Type>();
    }

    #endregion

    #region Public Properties

    private CharacterString _description;

    /// <summary>
    /// Description of the event, including related parameters or tolerances.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString Description {
      get => _description;
      set => SetProperty(ref _description, value);
    }

    private CharacterString? _rationale;

    /// <summary>
    /// Requirement or purpose for the process step.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("rationale", Order = 1)]
    [JsonProperty("rationale", Order = 1)]
    public CharacterString? Rationale {
      get => _rationale;
      set => SetProperty(ref _rationale, value);
    }

    private DateTimeDbEntity? _dateTime;

    /// <summary>
    /// Date and time or range of date and time on or over which the process step occurred.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("dateTime", Order = 2)]
    [JsonProperty("dateTime", Order = 2)]
    public DateTimeDbEntity? DateTime {
      get => _dateTime;
      set => SetProperty(ref _dateTime, value);
    }

    private ObservableCollection<CI_ResponsibleParty_Type>? _processor;

    /// <summary>
    /// Identification of, and means of communication with, person(s) and organization(s) asociated with the process step.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("processor", Order = 3)]
    [JsonProperty("processor", Order = 3)]
    public ObservableCollection<CI_ResponsibleParty_Type>? Processor {
      get => _processor;
      set => SetProperty(ref _processor, value);
    }

    private ObservableCollection<LI_Source_Type>? _source;

    /// <summary>
    /// Information about the source data used in creating the data specified by the scope.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("source", Order = 4)]
    [JsonProperty("source", Order = 4)]
    public ObservableCollection<LI_Source_Type>? Source {
      get => _source;
      set => SetProperty(ref _source, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="LI_ProcessStep_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="LI_ProcessStep_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(LI_ProcessStep_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = Description?.CompareTo(other.Description) ?? 1) != 0 ? result :
        (result = Rationale?.CompareTo(other.Rationale) ?? 1) != 0 ? result :
        (result = DateTime?.CompareTo(other.DateTime) ?? 1) != 0 ? result :
        (result = Processor?.Count.CompareTo(other.Processor?.Count ?? 0) ?? 1) != 0 ? result :
        Source?.Count.CompareTo(other.Source?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="LI_ProcessStep_Type"/> is equal to the current <see cref="LI_ProcessStep_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="LI_ProcessStep_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(LI_ProcessStep_Type? other) {
      return other != null &&
         Equals(Description, other.Description) &&
         Equals(Rationale, other.Rationale) &&
         Equals(DateTime, other.DateTime) &&
         Processor.SequenceEqualOrdered(other.Processor) &&
         Source.SequenceEqualOrdered(other.Source);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="LI_ProcessStep_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as LI_ProcessStep_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="LI_ProcessStep_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(Description);
      hash.Add(Rationale);
      hash.Add(DateTime);

      foreach (CI_ResponsibleParty_Type processor in Processor.SafeOrderBy()) {
        hash.Add(processor);
      }

      foreach (LI_Source_Type source in Source.SafeOrderBy()) {
        hash.Add(source);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
