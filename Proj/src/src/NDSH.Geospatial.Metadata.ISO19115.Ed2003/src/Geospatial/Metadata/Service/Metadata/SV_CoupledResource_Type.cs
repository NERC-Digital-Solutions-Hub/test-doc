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
// XSD               : /2005/srv/serviceMetadata.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="SV_CoupledResource_Type">
//   <xs:complexContent>
//     <xs:extension base="gco:AbstractObject_Type">
//       <xs:sequence>
//         <xs:element name="operationName" type="gco:CharacterString_PropertyType"/>
//         <xs:element name="identifier" type="gco:CharacterString_PropertyType"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="SV_CoupledResource" type="srv:SV_CoupledResource_Type"/>
// <xs:complexType name="SV_CoupledResource_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="srv:SV_CoupledResource"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;

using NDSH.Hashing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Service.Metadata {

  [Serializable]
  //[XmlType("SV_CoupledResource", Namespace = "http://www.isotc211.org/2005/srv")]
  //[XmlRoot("SV_CoupledResource", Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
  [JsonObject("SV_CoupledResource")]
  public class SV_CoupledResource_Type : MetadataObject, IComparable<SV_CoupledResource_Type>, IEquatable<SV_CoupledResource_Type> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_CoupledResource_Type"/>
    /// </summary>
    public SV_CoupledResource_Type() {
      _operationName = default;
      _identifier = default;
    }

    #endregion

    #region Public Properties

    private CharacterString _operationName;

    /// <summary>
    /// Name of the service operation.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("operationName", Order = 0)]
    [JsonProperty("operationName", Order = 0)]
    public CharacterString OperationName {
      get => _operationName;
      set => SetProperty(ref _operationName, value);
    }

    private CharacterString _identifier;

    /// <summary>
    /// Name of the identifier of a given tightly coupled dataset.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlElement("identifier", Order = 1)]
    [JsonProperty("identifier", Order = 1)]
    public CharacterString Identifier {
      get => _identifier;
      set => SetProperty(ref _identifier, value);
    }

    #endregion

    #region IComparable Interface

    /// <summary>
    /// Compares this instance to another <see cref="SV_CoupledResource_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="SV_CoupledResource_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public int CompareTo(SV_CoupledResource_Type? other) {

      int result;

      return
        (other is null) ? 1 :
        (result = OperationName?.CompareTo(other.OperationName) ?? 1) != 0 ? result :
        Identifier?.CompareTo(other.Identifier) ?? 1;
    }

    #endregion

    #region IEquatable Interface

    /// <summary>
    /// Determines whether the <see cref="SV_CoupledResource_Type"/> is equal to the current <see cref="SV_CoupledResource_Type"/>.
    /// </summary>
    /// <param name="other">The <see cref="SV_CoupledResource_Type"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.</returns>
    public bool Equals(SV_CoupledResource_Type? other) {
      return other != null &&
         Equals(OperationName, other.OperationName) &&
         Equals(Identifier, other.Identifier);
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="SV_CoupledResource_Type"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare.</param>
    /// <returns><see langword="true"/> if equal to <paramref name="obj"/>; <see langword="false"/> if not.</returns>
    public override bool Equals(object? obj) {
      return Equals(obj as SV_CoupledResource_Type);
    }

    /// <summary>
    /// Gets the hash code for the <see cref="SV_CoupledResource_Type"/> using <see cref="NdshHashCode"/>.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() {
      NdshHashCode hash = new();

      hash.Add(OperationName);
      hash.Add(Identifier);

      return hash.ToHashCode();
    }

    #endregion

  }

}
