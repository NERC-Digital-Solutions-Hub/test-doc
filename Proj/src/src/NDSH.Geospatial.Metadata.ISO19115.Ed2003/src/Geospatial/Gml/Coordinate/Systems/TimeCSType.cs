
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
// <element name="TimeCS" type="gml:TimeCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <documentation>
//       gml:TimeCS is a one-dimensional coordinate system containing a time axis,
//       used to describe the temporal position of a point in the specified time units from a specified time origin. 
//       A TimeCS shall have one gml:axis property element.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="TimeCSType">
//   <complexContent>
//     <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="TimeCSPropertyType">
//  <annotation>
//     <documentation>
//       gml:TimeCSPropertyType is a property type for association roles to a time coordinate system,
//        either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeCS"/>
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
  /// The <see cref="TimeCSType"/> is a one-dimensional coordinate system containing a time axis,
  /// used to describe the temporal position of a point in the specified time units from a specified time origin.
  /// A <see cref="TimeCSType"/> shall have one gml:axis property element.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>TimeCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("TimeCSType", WrapperName = "TimeCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_TimeCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCSType")]
  public class TimeCSType : AbstractCoordinateSystemType {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="TimeCSType">time coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
