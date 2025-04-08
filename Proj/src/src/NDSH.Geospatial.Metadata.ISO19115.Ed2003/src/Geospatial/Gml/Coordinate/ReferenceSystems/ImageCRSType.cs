
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
// XSD               : /2005/gml/coordinateSystems.xsd
//                     /2005/gml/coordinateReferenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
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
// <element name="affineCS" type="gml:AffineCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:affineCS is an association role to the affine coordinate system used by this CRS.
//     </documentation>
//   </annotation>
// </element>
// <element name="usesAffineCS" type="gml:AffineCSPropertyType" substitutionGroup="gml:affineCS">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="usesObliqueCartesianCS" type="gml:ObliqueCartesianCSPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="imageDatum" type="gml:ImageDatumPropertyType">
//   <annotation>
//     <documentation>gml:imageDatum is an association role to the image datum used by this CRS.</documentation>
//   </annotation>
// </element>
// <element name="usesImageDatum" type="gml:ImageDatumPropertyType" substitutionGroup="gml:imageDatum">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="ImageCRS" type="gml:ImageCRSType" substitutionGroup="gml:AbstractSingleCRS">
//   <annotation>
//     <documentation>
//       gml:ImageCRS is an engineering coordinate reference system applied to locations in images.
//       Image coordinate reference systems are treated as a separate sub-type because the
//       definition of the associated image datum contains two attributes not relevant
//       to other engineering datums.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="ImageCRSType">
//   <complexContent>
//     <extension base="gml:AbstractCRSType">
//       <sequence>
//         <choice>
//           <element ref="gml:cartesianCS"/>
//           <element ref="gml:affineCS"/>
//           <element ref="gml:usesObliqueCartesianCS"/>
//         </choice>
//         <element ref="gml:imageDatum"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="ImageCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:ImageCRSPropertyType is a property type for association roles to an image
//       coordinate reference system, either referencing or containing the definition
//       of that reference system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:ImageCRS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Coordinate.Datums;
using NDSH.Geospatial.Gml.Coordinate.Systems;
using NDSH.Geospatial.Gml.ReferenceSystems;
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
  /// The <see cref="ImageCRSType"/> is an engineering coordinate reference system applied to locations in images.
  /// Image coordinate reference systems are treated as a separate sub-type because the definition of the associated
  /// image datum contains two attributes not relevant to other engineering datums.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>ImageCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_ImageCRS_Type))] // GMX
  [IsoType("ImageCRSType", WrapperName = "ImageCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ImageCRSType")]
  public class ImageCRSType : AbstractCRSType, ISingleCRS {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ImageCRSType"/>.
    /// </summary>
    public ImageCRSType() {

    }

    #endregion

    #region Public Properties

    private IImageCoordinateSystem _imageCoordinateSystem;

    /// <summary>
    /// Gets/Sets the <see cref="IImageCoordinateSystem"/> associated with this coordinate reference system.
    /// </summary>
    //[XmlElement("affineCS", typeof(AffineCSPropertyType), Order = 0)]
    //[XmlElement("cartesianCS", typeof(CartesianCSPropertyType), Order = 0)]
    //[XmlElement("usesObliqueCartesianCS", typeof(ObliqueCartesianCSPropertyType), Order = 0)]
    public IImageCoordinateSystem CoordinateSystem {
      get => _imageCoordinateSystem;
      set => SetProperty(ref _imageCoordinateSystem, value);
    }

    private ImageDatumType _imageDatum;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="ImageDatumType"/> used by this coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 1)]
    [JsonProperty("imageDatum", Order = 1)]
    public ImageDatumType ImageDatum {
      get => _imageDatum;
      set => SetProperty(ref _imageDatum, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="ImageCRSType">image coordinate reference system</see>.
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
