
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/03/2025, @gisvlasta
// History           : 25/03/2025, @gisvlasta - Added IGeocentricCoordinateSystem.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="SphericalCS" type="gml:SphericalCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <documentation>
//       gml:SphericalCS is a three-dimensional coordinate system with one distance measured from the origin and
//       two angular coordinates. A SphericalCS shall have three gml:axis property elements.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="SphericalCSType">
//   <complexContent>
//     <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="SphericalCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:SphericalCSPropertyType is property type for association roles to a spherical coordinate system, 
//       either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:SphericalCS"/>
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
  /// The <see cref="SphericalCSType"/> is a three-dimensional coordinate system
  /// with one distance measured from the origin and two angular coordinates.
  /// A <see cref="SphericalCSType"/>  shall have three gml:axis property elements.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>SphericalCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("SphericalCSType", WrapperName = "SphericalCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_SphericalCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SphericalCSType")]
  public class SphericalCSType : AbstractCoordinateSystemType, IGeocentricCoordinateSystem, IGeodeticCoordinateSystem {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="SphericalCSType">spherical coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
