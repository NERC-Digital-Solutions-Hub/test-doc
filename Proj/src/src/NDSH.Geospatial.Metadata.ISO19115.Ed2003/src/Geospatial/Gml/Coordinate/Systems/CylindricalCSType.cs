
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="CylindricalCS" type="gml:CylindricalCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <documentation>
//       gml:CylindricalCS is a three-dimensional coordinate system consisting of a polar coordinate system
//       extended by a straight coordinate axis perpendicular to the plane spanned by the polar coordinate system. 
//       A CylindricalCS shall have three gml:axis property elements.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="CylindricalCSType">
//   <complexContent>
//     <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="CylindricalCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:CylindricalCSPropertyType is a property type for association roles to a cylindrical coordinate system, 
//       either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:CylindricalCS"/>
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
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Systems {

  /// <summary>
  /// The <see cref="CylindricalCSType"/> is a three-dimensional coordinate system consisting of a
  /// polar coordinate system extended by a straight coordinate axis perpendicular to the plane
  /// spanned by the polar coordinate system.
  /// A <see cref="CylindricalCSType"/> shall have three gml:axis property elements.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>CylindricalCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("CylindricalCSType", WrapperName = "CylindricalCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_CylindricalCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CylindricalCSType")]
  public class CylindricalCSType : AbstractCoordinateSystemType {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="CylindricalCSType">cylindrical coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
