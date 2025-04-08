
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
// <element name="AffineCS" type="gml:AffineCSType" substitutionGroup="gml:AbstractCoordinateSystem">
//   <annotation>
//     <documentation>
//       gml:AffineCS is a two- or three-dimensional coordinate system with straight axes that
//       are not necessarily orthogonal. An AffineCS shall have two or three gml:axis property elements;
//       the number of property elements shall equal the dimension of the CS.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="AffineCSType">
//   <complexContent>
//     <extension base="gml:AbstractCoordinateSystemType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="AffineCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:AffineCSPropertyType is a property type for association roles to an affine coordinate system,
//       either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AffineCS"/>
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
  /// The <see cref="AffineCSType"/> is a two- or three-dimensional coordinate system with straight axes that
  /// are not necessarily orthogonal. An <see cref="AffineCSType"/> shall have two or three gml:axis property elements;
  /// the number of property elements shall equal the dimension of the coordinate system.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AffineCSType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType("AffineCSType", WrapperName = "AffineCSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlInclude(typeof(ML_AffineCS_Type))] // GMX
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AffineCSType")]
  public class AffineCSType : AbstractCoordinateSystemType, IImageCoordinateSystem {

    private AssociationEntity? _association;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an
    /// <see cref="AffineCSType">affine coordinate system</see>.
    /// </summary>
    public override AssociationEntity? Association {
      get => _association;
      set => SetProperty(ref _association, value);
    }

  }

}
