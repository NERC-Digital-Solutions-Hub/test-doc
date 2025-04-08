
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/datums.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="pixelInCell" type="gml:CodeWithAuthorityType">
//   <annotation>
//     <documentation>
//       gml:pixelInCell is a specification of the way an image grid is associated with the image data attributes.
//       The required codeSpace attribute shall reference a source of information specifying the values and
//       meanings of all the allowed string values for this property.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="ImageDatum" type="gml:ImageDatumType" substitutionGroup="gml:AbstractDatum">
//   <annotation>
//     <documentation>
//       gml:ImageDatum defines the origin of an image coordinate reference system,
//       and is used in a local context only. For an image datum, the anchor definition is usually either
//       the centre of the image or the corner of the image. For more information, see ISO 19111 B.3.5.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="ImageDatumType">
//   <complexContent>
//     <extension base="gml:AbstractDatumType">
//       <sequence>
//         <element ref="gml:pixelInCell"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="ImageDatumPropertyType">
//   <annotation>
//     <documentation>
//       gml:ImageDatumPropertyType is a property type for association roles to an image datum,
//       either referencing or containing the definition of that datum.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:ImageDatum"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  ///   <para>
  ///     The <see cref="ImageDatumType"/> defines the origin of an image coordinate reference system,
  ///     and is used in a local context only. For an image datum, the anchor definition is usually either
  ///     the centre of the image or the corner of the image.
  ///   </para>
  ///   <para>For more information, see ISO 19111 B.3.5.</para>
  /// </summary>
  /// <remarks>
  /// Maps to: <c>ImageDatumType</c> ( /2005/gml/datums.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_ImageDatum_Type))] // GMX
  [IsoType("ImageDatumType", WrapperName = "ImageDatumPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ImageDatumType")]
  public class ImageDatumType : AbstractDatumType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ImageDatumType"/>.
    /// </summary>
    public ImageDatumType() {
      _pixelInCell = new CodeWithAuthorityType();
    }

    #endregion

    #region Public Properties

    private CodeWithAuthorityType _pixelInCell;

    /// <summary>
    /// The <see cref="PixelInCell"/> is a specification of the way an image grid is associated with the
    /// image data attributes. The required <see cref="CodeWithAuthorityType.CodeSpace">CodeSpace</see> property
    /// (<c>codeSpace</c> attribute) shall reference a source of information specifying the values and
    /// meanings of all the allowed string values for this property.
    /// </summary>
    //[XmlElement(Order = 0)]
    [JsonProperty("pixelInCell", Order = 0)]
    public CodeWithAuthorityType PixelInCell {
      get => _pixelInCell;
      set => SetProperty(ref _pixelInCell, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a <see cref="ImageDatumType"/>.
    /// </summary>
    /// <remarks>
    /// Only <see cref="TypeAssociationMetadata.Association">Associations</see> are allowed.
    /// <see cref="TypeAssociationMetadata.Reference">References</see> and
    /// <see cref="TypeAssociationMetadata.NilReason">Nil Reasons</see> are explicitly disallowed in this context.
    /// </remarks>
    /// <exception cref="InvalidOperationException">
    /// Thrown when an <see cref="AssociationEntity"/> is used, which is not allowed.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Thrown when an unsupported subtype of <see cref="TypeAssociationMetadata"/> is provided.
    /// </exception>
    public override TypeAssociationMetadata? TypeAssociation {
      get => _typeAssociationMetadata;
      set {
        _typeAssociationMetadata = value switch {
          null => null,
          TypeAssociationMetadata.Association => value,
          TypeAssociationMetadata.Reference => throw new InvalidOperationException(
            $"{nameof(AssociationEntity)} is not allowed in this context." // RESOURCE
          ),
          TypeAssociationMetadata.NilReason => throw new InvalidOperationException(
            $"{nameof(AssociationEntity)} is not allowed in this context." // RESOURCE
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
