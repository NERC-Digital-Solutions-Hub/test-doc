
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
// <element name="EllipsoidalCS" type="gml:EllipsoidalCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <documentation>
//       gml:EllipsoidalCS is a two- or three-dimensional coordinate system in which position is specified
//       by geodetic latitude, geodetic longitude, and (in the three-dimensional case) ellipsoidal height.
//       An EllipsoidalCS shall have two or three gml:axis property elements;
//       the number of associations shall equal the dimension of the CS.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="EllipsoidalCSType">
//   <complexContent>
//   <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="EllipsoidalCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:EllipsoidalCSPropertyType is a property type for association roles to an ellipsoidal coordinate system, 
//       either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//   <element ref="gml:EllipsoidalCS"/>
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
  /// The <see cref="EllipsoidalCSType"/> is a two- or three-dimensional coordinate system in which position
  /// is specified by geodetic latitude, geodetic longitude, and (in the three-dimensional case) ellipsoidal height.
  /// An <see cref="EllipsoidalCSType"/> shall have two or three gml:axis property elements;
  /// the number of associations shall equal the dimension of the CS.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>EllipsoidalCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("EllipsoidalCSType", WrapperName = "EllipsoidalCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_EllipsoidalCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EllipsoidalCSType")]
  public class EllipsoidalCSType : AbstractCoordinateSystemType, IGeodeticCoordinateSystem {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="EllipsoidalCSType">ellipsoidal coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
