
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// History           : 05/03/2025, @gisvlasta - Reworked the entire class and introduced new properties whose
//                                              purpose is to allow only one of the class's properties to
//                                              have a value.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : This class is an exception to the rule. It does not inherit from `IdentifiableObject`
//                      (xsd: `AbstractObject_Type`). Classes whose properties are of this type
//                      are not decorated with property metadata instances of type `ReferencedObject`;
//                      instead they are decorated with instances of `NilReasonEntity`.
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
//                     /2005/gmd/maintenance.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:attributeGroup name="ObjectReference">
//   <xs:attributeGroup ref="xlink:simpleLink"/>
//   <xs:attribute name="uuidref" type="xs:string"/>
// </xs:attributeGroup>
// <xs:attribute name="nilReason" type="gml:NilReasonType"/>
// <xs:complexType name="ObjectReference_PropertyType">
//   <xs:sequence/>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
//
// <xs:complexType name="MD_ScopeDescription_Type">
//   <xs:choice>
//     <xs:element name="attributes" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="features" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="featureInstances" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="attributeInstances" type="gco:ObjectReference_PropertyType" maxOccurs="unbounded"/>
//     <xs:element name="dataset" type="gco:CharacterString_PropertyType"/>
//     <xs:element name="other" type="gco:CharacterString_PropertyType"/>
//   </xs:choice>
// </xs:complexType>
// <xs:element name="MD_ScopeDescription" type="gmd:MD_ScopeDescription_Type"/>
// <xs:complexType name="MD_ScopeDescription_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_ScopeDescription"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Maintenance {

  /// <summary>
  /// Description of the class of information covered by the information.
  /// </summary>
  /// <remarks>
  /// This class does not inherit from <see cref="MetadataObject"/> (xsd: AbstractObject_Type).
  /// Classes whose properties are of this type are not decorated with property metadata instances of type
  /// <see cref="ReferenceEntity"/>; instead they are decorated with instances of <see cref="NilReasonEntity"/>.
  /// </remarks>
  //[XmlType("MD_ScopeDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("MD_ScopeDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_ScopeDescription")]
  public abstract class MD_ScopeDescription_Type : ObservableDbEntity,
    IComparable<MD_ScopeDescription_Type>,
    IEquatable<MD_ScopeDescription_Type> {

    #region IComparable<T> Interface

    /// <summary>
    /// Compares this instance to another <see cref="MD_ScopeDescription_Type"/> instance.
    /// <br></br>
    /// The two instances are considered <b>Equal</b> if their properties are <b>Equal</b>.
    /// </summary>
    /// <param name="other">The other <see cref="MD_ScopeDescription_Type"/>.</param>
    /// <returns>
    /// An <see cref="int"/> showing the result of the comparison.
    /// <list type="bullet">
    /// <item><term>0</term> if the instances are equal.</item>
    /// <item><term>1</term> if the instances are not equal.</item>
    /// </list>
    /// </returns>
    public abstract int CompareTo(MD_ScopeDescription_Type? other);

    #endregion

    #region IEquatable<T> Interface

    /// <summary>
    /// Determines whether the <see cref="MD_ScopeDescription_Type"/> is equal to the current
    /// <see cref="MD_ScopeDescription_Type"/>. This will order collections before comparing them.
    /// </summary>
    /// <param name="other">The <see cref="MD_ScopeDescription_Type"/> to compare.</param>
    /// <returns>
    /// <see langword="true"/> if equal to <paramref name="other"/>; <see langword="false"/> if not.
    /// </returns>
    public abstract bool Equals(MD_ScopeDescription_Type? other);

    #endregion

  }

}
