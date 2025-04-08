
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/03/2025, @gisvlasta
// History           : 25/03/2025, @gisvlasta - Added IImageCoordinateSystem interface.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="ObliqueCartesianCS"
//          type="gml:ObliqueCartesianCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="ObliqueCartesianCSType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="ObliqueCartesianCSPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:ObliqueCartesianCS"/>
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
  /// The <see cref="ObliqueCartesianCSType"/> is a coordinate system that is based
  /// on two straight axes that are not necessarily orthogonal.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The <see cref="ObliqueCartesianCSType"/> extends <see cref="AbstractCoordinateSystemType"/> and
  /// provides the definition of a 2-dimensional coordinate system in which the coordinate axes are not perpendicular.
  /// </para>
  /// <para>
  /// This type was used in earlier versions of GML but is now marked as deprecated in the XML Schema.
  /// It is included for backwards compatibility and support of legacy systems that reference
  /// oblique Cartesian coordinate systems.
  /// </para>
  /// Maps to: <c>ObliqueCartesianCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/coordinateSystems.xsd")]
  [IsoType("ObliqueCartesianCSType", WrapperName = "ObliqueCartesianCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ObliqueCartesianCSType")]
  public class ObliqueCartesianCSType : AbstractCoordinateSystemType, IImageCoordinateSystem {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="ObliqueCartesianCSType">oblique cartesian coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
