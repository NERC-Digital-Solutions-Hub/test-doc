
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
// <element name="PolarCS" type="gml:PolarCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <documentation>
//       gml:PolarCS is a two-dimensional coordinate system in which position is specified by the distance from
//       the origin and the angle between the line from the origin to a point and a reference direction.
//       A PolarCS shall have two gml:axis property elements.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="PolarCSType">
//   <complexContent>
//     <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="PolarCSPropertyType">
//   <annotation>
//     <documentation>gml:PolarCSPropertyType is a property type for association roles to a polar coordinate system, 
//       either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:PolarCS"/>
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
  /// The <see cref="PolarCSType"/> is a two-dimensional coordinate system in which position is specified by
  /// the distance from the origin and the angle between the line from the origin to a point and a reference direction.
  /// A <see cref="PolarCSType"/> shall have two gml:axis property elements.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>PolarCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("PolarCSType", WrapperName = "PolarCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_PolarCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PolarCSType")]
  public class PolarCSType : AbstractCoordinateSystemType {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="PolarCSType">polar coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
