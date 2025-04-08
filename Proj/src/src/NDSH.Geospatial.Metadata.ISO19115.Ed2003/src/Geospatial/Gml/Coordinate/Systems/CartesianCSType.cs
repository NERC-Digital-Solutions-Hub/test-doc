
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/03/2025, @gisvlasta
// History           : 25/03/2025, @gisvlasta - Added IGeocentricCoordinateSystem and IImageCoordinateSystem interfaces.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="CartesianCS" type="gml:CartesianCSType" substitutionGroup="gml:AbstractCoordinateSystem">
// 	<annotation>
// 		<documentation>
//      gml:CartesianCS is a 1-, 2-, or 3-dimensional coordinate system. In the 1-dimensional case, 
//      it contains a single straight coordinate axis. In the 2- and 3-dimensional cases gives the 
//      position of points relative to orthogonal straight axes. In the multi-dimensional case, 
//      all axes shall have the same length unit of measure. A CartesianCS shall have one, 
//      two, or three gml:axis property elements.
//    </documentation>
// 	</annotation>
// </element>
// 
// <complexType name="CartesianCSType">
// 	<complexContent>
// 		<extension base="gml:AbstractCoordinateSystemType"/>
// 	</complexContent>
// </complexType>
// 
// <complexType name="CartesianCSPropertyType">
// 	<annotation>
// 		<documentation>
// 		  gml:CartesianCSPropertyType is a property type for association roles to a Cartesian coordinate system,
//      either referencing or containing the definition of that coordinate system.
//    </documentation>
// 	</annotation>
// 	<sequence minOccurs="0">
// 		<element ref="gml:CartesianCS"/>
// 	</sequence>
// 	<attributeGroup ref="gml:AssociationAttributeGroup"/>
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
  /// The <see cref="CartesianCSType"/> is a 1-, 2-, or 3-dimensional coordinate system.
  /// <list type="bullet">
  ///   <item>In the 1-dimensional case, it contains a single straight coordinate axis.</item>
  ///   <item>
  ///     In the 2- and 3-dimensional cases gives the position of points relative to orthogonal straight axes.
  ///   In the multi-dimensional case, all axes shall have the same length unit of measure.
  ///   </item>
  /// </list>
  /// A <see cref="CartesianCSType"/>  shall have one, two, or three gml:axis property elements.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>CartesianCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("CartesianCSType", WrapperName = "CartesianCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_CartesianCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CartesianCSType")]
  public class CartesianCSType : AbstractCoordinateSystemType,
    IGeocentricCoordinateSystem,
    IGeodeticCoordinateSystem,
    IImageCoordinateSystem {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="CartesianCSType">Cartesian coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
