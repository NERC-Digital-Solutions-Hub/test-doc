
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
// <element name="LinearCS" type="gml:LinearCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <documentation>
//       gml:LinearCS is a one-dimensional coordinate system that consists of the points that lie on
//       the single axis described. The associated coordinate is the distance – with or without offset – from the
//       specified datum to the point along the axis. A LinearCS shall have one gml:axis property element.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="LinearCSType">
//   <complexContent>
//     <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="LinearCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:LinearCSPropertyType is a property type for association roles to a linear coordinate system, 
//       either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:LinearCS"/>
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
  /// The <see cref="LinearCSType"/> is a one-dimensional coordinate system that consists
  /// of the points that lie on  the single axis described. The associated coordinate is
  /// the distance – with or without offset – from the specified datum to the point along the axis.
  /// A <see cref="LinearCSType"/> shall have one gml:axis property element.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>LinearCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("LinearCSType", WrapperName = "LinearCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_LinearCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("LinearCSType")]
  public class LinearCSType : AbstractCoordinateSystemType {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="LinearCSType">linear coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
