
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
// <element name="VerticalCS" type="gml:VerticalCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <documentation>
//       gml:VerticalCS is a one-dimensional coordinate system used to record the heights or depths of points.
//       Such a coordinate system is usually dependent on the Earth's gravity field,
//       perhaps loosely as when atmospheric pressure is the basis for the vertical coordinate system axis.
//       A VerticalCS shall have one gml:axis property element.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="VerticalCSType">
//   <complexContent>
//     <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="VerticalCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:VerticalCSPropertyType is a property type for association roles to a vertical coordinate system,
//       either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:VerticalCS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
//
// <element name="verticalCSRef" type="gml:VerticalCSPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
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
  /// The <see cref="VerticalCSType"/> is a one-dimensional coordinate system used to record the heights or
  /// depths of points. Such a coordinate system is usually dependent on the Earth's gravity field,
  /// perhaps loosely as when atmospheric pressure is the basis for the vertical coordinate system axis.
  /// A <see cref="VerticalCSType"/> shall have one gml:axis property element.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>VerticalCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("VerticalCSType", WrapperName = "VerticalCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_VerticalCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VerticalCSType")]
  public class VerticalCSType : AbstractCoordinateSystemType {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="VerticalCSType">vertical coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
