#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 14/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/src/serviceMetadata.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="SV_OperationMetadata_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="operationName"
//                     type="gco:CharacterString_PropertyType"/>
//         <xs:element name="DCP"
//                     type="srv:DCPList_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="operationDescription"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="invocationName"
//                     type="gco:CharacterString_PropertyType" minOccurs="0"/>
//         <xs:element name="parameters"
//                     type="srv:SV_Parameter_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="connectPoint"
//                     type="gmd:CI_OnlineResource_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="dependsOn"
//                     type="srv:SV_OperationMetadata_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_OperationMetadata" type="srv:SV_OperationMetadata_Type"/>
// <xs:complexType name="SV_OperationMetadata_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_OperationMetadata"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

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

namespace NDSH.Geospatial.Metadata.Service.Metadata {

  [Serializable]
  //[XmlType("SV_OperationMetadata", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_OperationMetadata", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_OperationMetadata")]
  public class SV_OperationMetadata_Type : MetadataObject, IComparable<SV_OperationMetadata_Type>, IEquatable<SV_OperationMetadata_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationMetadata_Type"/>
    /// </summary>
    public SV_OperationMetadata_Type() {
      _operationName = default; // new CharacterString();
      _DCP = default; // new List<DCPList_PropertyType>();
      _operationDescription = default; // new CharacterString();
      _invocationName = default; // new CharacterString();
      _parameters = default; // new List<SV_Parameter_Type>();"
      _connectPoint = default; // new List<CI_OnlineResource_Type>();
      _dependsOn = default; // new List<SV_OperationMetadata_Type();
    }

    #endregion

    #region Public Properties

    private CharacterString _operationName;

    /// <summary>
    /// A unique identifier for this interface.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("operationName", Order = 0)]
    [JsonProperty("operationName", Order = 0)]
    public CharacterString OperationName {
      get => _operationName;
      set => SetProperty(ref _operationName, value);
    }

    private ObservableCollection<DCPList_CodeList> _DCP;

    /// <summary>
    /// Distributed computing platforms on which the operation has been implemented.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("DCP", Order = 1)]
    [JsonProperty("DCP", Order = 1)]
    public ObservableCollection<DCPList_CodeList> DCP {
      get => _DCP;
      set => SetProperty(ref _DCP, value);
    }

    private CharacterString _operationDescription;

    /// <summary>
    /// Free text description of the intent of the operation and the results of the operation.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("operationDescription", Order = 2)]
    [JsonProperty("operationDescription", Order = 2)]
    public CharacterString OperationDescription {
      get => _operationDescription;
      set => SetProperty(ref _operationDescription, value);
    }

    private CharacterString _invocationName;

    /// <summary>
    /// The name used to invoke this interface within the context of the DCP. The name is identical for all DCPs.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("invocationName", Order = 3)]
    [JsonProperty("invocationName", Order = 3)]
    public CharacterString InvocationName {
      get => _invocationName;
      set => SetProperty(ref _invocationName, value);
    }

    private ObservableCollection<SV_Parameter_Type> _parameters;

    /// <summary>
    /// The parameters that  are required for this interface.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - 1
    //[XmlElement("parameters", Order = 4)]
    [JsonProperty("parameters", Order = 4)]
    public ObservableCollection<SV_Parameter_Type> Parameters {
      get => _parameters;
      set => SetProperty(ref _parameters, value);
    }

    private ObservableCollection<CI_OnlineResource_Type> _connectPoint;

    /// <summary>
    /// Handle for accessing the service interface.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("connectPoint", Order = 5)]
    [JsonProperty("connectPoint", Order = 5)]
    public ObservableCollection<CI_OnlineResource_Type> ConnectPoint {
      get => _connectPoint;
      set => SetProperty(ref _connectPoint, value);
    }

    private ObservableCollection<SV_OperationMetadata_Type> _dependsOn;

    /// <summary>
    /// List of operations that must be completed immediately before current operation is invoked,
    /// structured as a list for capturing alternate predecessor paths and sets for capturing
    /// parallel predecessor paths.
    /// </summary>
    // TODO: OBL - O
    // TODO: CAR - N
    //[XmlElement("dependsOn", Order = 6)]
    [JsonProperty("dependsOn", Order = 6)]
    public ObservableCollection<SV_OperationMetadata_Type> DependsOn {
      get => _dependsOn;
      set => SetProperty(ref _dependsOn, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="SV_OperationMetadata_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="SV_OperationMetadata_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(SV_OperationMetadata_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = OperationName?.CompareTo(other.OperationName) ?? 1) != 0 ? result :
        (result = DCP?.Count.CompareTo(other.DCP?.Count ?? 0) ?? 1) != 0 ? result :
        (result = OperationDescription?.CompareTo(other.OperationDescription) ?? 1) != 0 ? result :
        (result = InvocationName?.CompareTo(other.InvocationName) ?? 1) != 0 ? result :
        (result = Parameters?.Count.CompareTo(other.Parameters?.Count ?? 0) ?? 1) != 0 ? result :
        (result = ConnectPoint?.Count.CompareTo(other.ConnectPoint?.Count ?? 0) ?? 1) != 0 ? result :
        DependsOn?.Count.CompareTo(other.DependsOn?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="SV_OperationMetadata_Type"/> is equal to the current <see cref="SV_OperationMetadata_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="SV_OperationMetadata_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(SV_OperationMetadata_Type? other) {
      return other != null &&
         Equals(OperationName, other.OperationName) &&
         DCP.SequenceEqualOrdered(other.DCP) &&
         Equals(OperationDescription, other.OperationDescription) &&
         Equals(InvocationName, other.InvocationName) &&
         //Parameters.SequenceEqualOrdered(other.Parameters) && // TODO: Implement!
         ConnectPoint.SequenceEqualOrdered(other.ConnectPoint) &&
         DependsOn.SequenceEqualOrdered(other.DependsOn);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="SV_OperationMetadata_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as SV_OperationMetadata_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="SV_OperationMetadata_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(OperationName);

      foreach (DCPList_CodeList dcp in DCP.SafeOrderBy()) {
        hash.Add(dcp);
      }

      hash.Add(OperationDescription);
      hash.Add(InvocationName);

      //foreach (SV_Parameter_Type parameter in Parameters.SafeOrderBy()) {
      //  hash.Add(parameter);
      //} // TODO: Implement!

      foreach (CI_OnlineResource_Type resource in ConnectPoint.SafeOrderBy()) {
        hash.Add(resource);
      }

      foreach (SV_OperationMetadata_Type operation in DependsOn.SafeOrderBy()) {
        hash.Add(operation);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
