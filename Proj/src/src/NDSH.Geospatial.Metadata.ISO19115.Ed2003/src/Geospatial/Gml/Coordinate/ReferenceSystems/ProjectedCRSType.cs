
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 25/03/2025, @gisvlasta
// History           : 30/03/2025, @gisvlasta - Changed the override of the TypeAssociation property
//                                              inherited from AbstractCRSType.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateReferenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="baseGeodeticCRS" type="gml:GeodeticCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:baseGeodeticCRS is an association role to the geodetic coordinate reference system
//       used by this projected CRS.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="baseGeographicCRS" type="gml:GeographicCRSPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="cartesianCS" type="gml:CartesianCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:cartesianCS is an association role to the Cartesian coordinate system used by this CRS.
//     </documentation>
//   </annotation>
// </element>
// <element name="usesCartesianCS" type="gml:CartesianCSPropertyType" substitutionGroup="gml:cartesianCS">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="ProjectedCRS" type="gml:ProjectedCRSType" substitutionGroup="gml:AbstractGeneralDerivedCRS">
//   <annotation>
//     <documentation>
//       gml:ProjectedCRS is a 2D coordinate reference system used to approximate the shape of the earth
//       on a planar surface, but in such a way that the distortion that is inherent to the approximation
//       is carefully controlled and known. Distortion correction is commonly applied to calculated bearings
//       and distances to produce values that are a close match to actual field values.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="ProjectedCRSType">
//   <complexContent>
//     <extension base="gml:AbstractGeneralDerivedCRSType">
//       <sequence>
//         <choice>
//           <element ref="gml:baseGeodeticCRS"/>
//           <element ref="gml:baseGeographicCRS"/>
//         </choice>
//         <element ref="gml:cartesianCS"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
//
// <complexType name="ProjectedCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:ProjectedCRSPropertyType is a property type for association roles
//       to a projected coordinate reference system, either referencing or
//       containing the definition of that reference system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:ProjectedCRS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// 
// <element name="projectedCRSRef" type="gml:ProjectedCRSPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Coordinate.Systems;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.ReferenceSystems {

  /// <summary>
  /// The <see cref="ProjectedCRSType"/> is a 2D coordinate reference system used to approximate
  /// the shape of the earth on a planar surface, but in such a way that the distortion that is inherent
  /// to the approximation is carefully controlled and known. Distortion correction is commonly applied
  /// to calculated bearings and distances to produce values that are a close match to actual field values.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>ProjectedCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_ProjectedCRS_Type))] // GMX
  [IsoType("ProjectedCRSType", WrapperName = "ProjectedCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ProjectedCRSType")]
  public class ProjectedCRSType : AbstractGeneralDerivedCRSType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ProjectedCRSType"/>.
    /// </summary>
    public ProjectedCRSType() {

    }

    #endregion

    #region Public Properties

    private IProjectedCoordinateReferenceSystem _projectedCoordinateReferenceSystem;

    /// <summary>
    /// Gets/Sets the <see cref="IProjectedCoordinateReferenceSystem"/>.
    /// </summary>
    /// <remarks>
    /// The <see cref="IProjectedCoordinateReferenceSystem"/> can be either
    /// a <see cref="GeodeticCRSType"/> or a <see cref="GeographicCRSType"/>.
    /// </remarks>
    //[XmlElement("baseGeodeticCRS", typeof(GeodeticCRSPropertyType), Order = 0)]
    //[XmlElement("baseGeographicCRS", typeof(GeographicCRSPropertyType), Order = 0)]
    public IProjectedCoordinateReferenceSystem ProjectedCoordinateReferenceSystem {
      get => _projectedCoordinateReferenceSystem;
      set => SetProperty(ref _projectedCoordinateReferenceSystem, value);
    }

    private CartesianCSType _cartesianCS;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="CartesianCSType"/> used by this coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 1)]
    [JsonProperty("cartesianCS", Order = 1)]
    public CartesianCSType CartesianCS {
      get => _cartesianCS;
      set => SetProperty(ref _cartesianCS, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="ProjectedCRSType">projected coordinate reference system</see>.
    /// </summary>
    public override TypeAssociationMetadata? TypeAssociation {
      get => _typeAssociationMetadata;
      set {
        _typeAssociationMetadata = value switch {
          null => null,
          TypeAssociationMetadata.Association => value,
          TypeAssociationMetadata.Reference => throw new InvalidOperationException(
            $"{nameof(ReferenceEntity)} is not allowed in this context. Only {nameof(AssociationEntity)} is supported." // RESOURCE
          ),
          TypeAssociationMetadata.NilReason => throw new InvalidOperationException(
            $"{nameof(NilReasonEntity)} is not allowed in this context. Only {nameof(AssociationEntity)} is supported." // RESOURCE
          ),
          _ => throw new ArgumentException(
            $"Unsupported subtype of {nameof(TypeAssociationMetadata)}: {value.GetType().Name}" // RESOURCE
          ),
        };
      }
    }

    #endregion

  }

}
