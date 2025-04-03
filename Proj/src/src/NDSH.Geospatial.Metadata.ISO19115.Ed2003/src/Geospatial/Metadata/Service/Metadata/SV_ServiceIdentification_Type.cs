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
// XSD               : /2005/srv/serviceMetadata.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="SV_ServiceIdentification_Type">
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractMD_Identification_Type">
//       <xs:sequence>
//         <xs:element name="serviceType"
//                     type="gco:GenericName_PropertyType"/>
//         <xs:element name="serviceTypeVersion"
//                     type="gco:CharacterString_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="accessProperties"
//                     type="gmd:MD_StandardOrderProcess_PropertyType" minOccurs="0"/>
//         <xs:element name="restrictions"
//                     type="gmd:MD_Constraints_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="keywords"
//                     type="gmd:MD_Keywords_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="extent"
//                     type="gmd:EX_Extent_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="couplingType"
//                     type="srv:SV_CouplingType_PropertyType"/>
//         <xs:element name="coupledResource"
//                     type="srv:SV_CoupledResource_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <xs:element name="containsOperations"
//                     type="srv:SV_OperationMetadata_PropertyType" maxOccurs="unbounded"/>
//         <xs:element name="operatesOn"
//                     type="gmd:MD_DataIdentification_PropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_ServiceIdentification"
//             type="srv:SV_ServiceIdentification_Type" substitutionGroup="gmd:AbstractMD_Identification"/>
// <xs:complexType name="SV_ServiceIdentification_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_ServiceIdentification"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Constraint;
using NDSH.Geospatial.Metadata.Distribution;
using NDSH.Geospatial.Metadata.Extent;
using NDSH.Geospatial.Metadata.Identification;
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

  /// <summary>
  /// See 19119 for further info.
  /// </summary>
  // WARNING: Add Documentation from 19119.
  [Serializable]
  //[XmlType("SV_ServiceIdentification", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_ServiceIdentification", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_ServiceIdentification")]
  public class SV_ServiceIdentification_Type : AbstractMD_Identification_Type, IComparable<SV_ServiceIdentification_Type>, IEquatable<SV_ServiceIdentification_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_ServiceIdentification_Type"/>
    /// </summary>
    public SV_ServiceIdentification_Type() {
      _serviceType = default; // new GenericName_PropertyType();
      _serviceTypeVersion = default; // new List<CharacterString>();
      _accessProperties = default; // new MD_StandardOrderProcess_Type();
      _restrictions = default; // new List<MD_Constraints_Type>();
      _keywords = default; // new List<MD_Keywords_Type>();
      _extent = default; // new List<EX_Extent_Type>();
      _couplingType = default; // new SV_CouplingType_PropertyType();
      _coupledResource = default; // new List<SV_CoupledResource_Type>();
      _containsOperations = default; // new List<SV_OperationMetadata_Type>();
      _operatesOn = default; // new List<MD_DataIdentification_Type>();
    }

    #endregion

    #region Public Properties

    private GenericName _serviceType;

    //[XmlElement("serviceType", Order = 0)]
    [JsonProperty("serviceType", Order = 0)]
    public GenericName ServiceType {
      get => _serviceType;
      set => SetProperty(ref _serviceType, value);
    }

    private ObservableCollection<CharacterString> _serviceTypeVersion;

    //[XmlElement("serviceTypeVersion", Order = 1)]
    [JsonProperty("serviceTypeVersion", Order = 1)]
    public ObservableCollection<CharacterString> ServiceTypeVersion {
      get => _serviceTypeVersion;
      set => SetProperty(ref _serviceTypeVersion, value);
    }

    private MD_StandardOrderProcess_Type _accessProperties;

    //[XmlElement("accessProperties", Order = 2)]
    [JsonProperty("accessProperties", Order = 2)]
    public MD_StandardOrderProcess_Type AccessProperties {
      get => _accessProperties;
      set => SetProperty(ref _accessProperties, value);
    }

    private ObservableCollection<MD_Constraints_Type> _restrictions;

    //[XmlElement("restrictions", Order = 3)]
    [JsonProperty("restrictions", Order = 3)]
    public ObservableCollection<MD_Constraints_Type> Restrictions {
      get => _restrictions;
      set => SetProperty(ref _restrictions, value);
    }

    private ObservableCollection<MD_Keywords_Type> _keywords;

    //[XmlElement("keywords", Order = 4)]
    [JsonProperty("keywords", Order = 4)]
    public ObservableCollection<MD_Keywords_Type> Keywords {
      get => _keywords;
      set => SetProperty(ref _keywords, value);
    }

    private ObservableCollection<EX_Extent_Type> _extent;

    //[XmlElement("extent", Order = 5)]
    [JsonProperty("extent", Order = 5)]
    public ObservableCollection<EX_Extent_Type> Extent {
      get => _extent;
      set => SetProperty(ref _extent, value);
    }

    private SV_CouplingType_CodeList _couplingType;

    //[XmlElement("couplingType", Order = 6)]
    [JsonProperty("couplingType", Order = 6)]
    public SV_CouplingType_CodeList CouplingType {
      get => _couplingType;
      set => SetProperty(ref _couplingType, value);
    }

    private ObservableCollection<SV_CoupledResource_Type> _coupledResource;

    //[XmlElement("coupledResource", Order = 7)]
    [JsonProperty("coupledResource", Order = 7)]
    public ObservableCollection<SV_CoupledResource_Type> CoupledResource {
      get => _coupledResource;
      set => SetProperty(ref _coupledResource, value);
    }

    private ObservableCollection<SV_OperationMetadata_Type> _containsOperations;

    //[XmlElement("containsOperations", Order = 8)]
    [JsonProperty("containsOperations", Order = 8)]
    public ObservableCollection<SV_OperationMetadata_Type> ContainsOperations {
      get => _containsOperations;
      set => SetProperty(ref _containsOperations, value);
    }

    private ObservableCollection<MD_DataIdentification_Type> _operatesOn;

    //[XmlElement("operatesOn", Order = 9)]
    [JsonProperty("operatesOn", Order = 9)]
    // WARNING: When serialized, this is encoded with an xLink; This is to avoid circular references.
    // Example:
    // xlink:title="Digital Geological Map Data of Great Britain 50k (DiGMapGB-50) - artificial ground layer" xlink:href="https://metadata.bgs.ac.uk/geonetwork/srv/eng/csw?SERVICE=CSW0=GetRecordById0=full0=http://www.isotc211.org/2005/gmd0=9df8df52-d7d1-37a8-e044-0003ba9b0d980=2.0.2&amp;" uuidref="9df8df52-d7d1-37a8-e044-0003ba9b0d98"
    public ObservableCollection<MD_DataIdentification_Type> OperatesOn {
      get => _operatesOn;
      set => SetProperty(ref _operatesOn, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="SV_ServiceIdentification_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="SV_ServiceIdentification_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(SV_ServiceIdentification_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = ServiceType?.CompareTo(other.ServiceType) ?? 1) != 0 ? result :
        (result = ServiceTypeVersion?.Count.CompareTo(other.ServiceTypeVersion?.Count ?? 0) ?? 1) != 0 ? result :
        (result = AccessProperties?.CompareTo(other.AccessProperties) ?? 1) != 0 ? result :
        (result = Restrictions?.Count.CompareTo(other.Restrictions?.Count ?? 0) ?? 1) != 0 ? result :
        (result = Keywords?.Count.CompareTo(other.Keywords?.Count ?? 0) ?? 1) != 0 ? result :
        (result = Extent?.Count.CompareTo(other.Extent?.Count ?? 0) ?? 1) != 0 ? result :
        (result = CouplingType?.CompareTo(other.CouplingType) ?? 1) != 0 ? result :
        (result = CoupledResource?.Count.CompareTo(other.CoupledResource?.Count ?? 0) ?? 1) != 0 ? result :
        (result = ContainsOperations?.Count.CompareTo(other.ContainsOperations?.Count ?? 0) ?? 1) != 0 ? result :
        OperatesOn?.Count.CompareTo(other.OperatesOn?.Count ?? 0) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="SV_ServiceIdentification_Type"/> is equal to the current <see cref="SV_ServiceIdentification_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="SV_ServiceIdentification_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(SV_ServiceIdentification_Type? other) {
      return other != null &&
         Equals(ServiceType, other.ServiceType) &&
         ServiceTypeVersion.SequenceEqualOrdered(other.ServiceTypeVersion) &&
         Equals(AccessProperties, other.AccessProperties) &&
         Restrictions.SequenceEqualOrdered(other.Restrictions) &&
         Keywords.SequenceEqualOrdered(other.Keywords) &&
         Extent.SequenceEqualOrdered(other.Extent) &&
         Equals(CouplingType, other.CouplingType) &&
         CoupledResource.SequenceEqualOrdered(other.CoupledResource) &&
         ContainsOperations.SequenceEqualOrdered(other.ContainsOperations) &&
         OperatesOn.SequenceEqualOrdered(other.OperatesOn);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="SV_ServiceIdentification_Type"/>.
    /// This will order collections before comparing them.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as SV_ServiceIdentification_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="SV_ServiceIdentification_Type"/> using <see cref="NdshHashCode"/>. This will also order 
    /// collections before hashing them.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(ServiceType);

      foreach (CharacterString version in ServiceTypeVersion.SafeOrderBy()) {
        hash.Add(version);
      }

      hash.Add(AccessProperties);

      foreach (MD_Constraints_Type restriction in Restrictions.SafeOrderBy()) {
        hash.Add(restriction);
      }

      foreach (MD_Keywords_Type keyword in Keywords.SafeOrderBy()) {
        hash.Add(keyword);
      }

      foreach (EX_Extent_Type extent in Extent.SafeOrderBy()) {
        hash.Add(extent);
      }

      hash.Add(CouplingType);

      foreach (SV_CoupledResource_Type resource in CoupledResource.SafeOrderBy()) {
        hash.Add(resource);
      }

      foreach (SV_OperationMetadata_Type operation in ContainsOperations.SafeOrderBy()) {
        hash.Add(operation);
      }

      foreach (MD_DataIdentification_Type data in OperatesOn.SafeOrderBy()) {
        hash.Add(data);
      }

      return hash.ToHashCode();
    }

    #endregion

  }

}
