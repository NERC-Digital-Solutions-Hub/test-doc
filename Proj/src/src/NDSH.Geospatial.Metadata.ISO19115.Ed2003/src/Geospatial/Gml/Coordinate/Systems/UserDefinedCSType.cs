
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/03/2025, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="UserDefinedCS" type="gml:UserDefinedCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <documentation>
//       gml:UserDefinedCS is a two- or three-dimensional coordinate system that consists of any combination of
//       coordinate axes not covered by any other coordinate system type. A UserDefinedCS shall have two or
//       three gml:axis property elements; the number of property elements shall equal the dimension of the CS.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="UserDefinedCSType">
//   <complexContent>
//     <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="UserDefinedCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:UserDefinedCSPropertyType is a property type for association roles to a user-defined coordinate system, 
//       either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:UserDefinedCS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Systems {

  /// <summary>
  /// The <see cref="UserDefinedCSType"/> is a two- or three-dimensional coordinate system that
  /// consists of any combination of coordinate axes not covered by any other coordinate system type.
  /// A <see cref="UserDefinedCSType"/> shall have two or  three gml:axis property elements;
  /// the number of property elements shall equal the dimension of the coordinate system.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>UserDefinedCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("UserDefinedCSType", WrapperName = "UserDefinedCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_UserDefinedCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("UserDefinedCSType")]
  public class UserDefinedCSType : AbstractCoordinateSystemType {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="UserDefinedCSType">user-defined coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
