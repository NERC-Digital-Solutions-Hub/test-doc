
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 18/03/2025, @gisvlasta
// History           : 26/03/2025, @gisvlasta - Added Association property override, added IsoTypeAttribute,
//                                              updated documentation and header.
//                   : 01/04/2025, @gisvlasta - Changed TypeAssociation override.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/datums.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="VerticalDatum" type="gml:VerticalDatumType" substitutionGroup="gml:AbstractDatum">
//   <annotation>
//     <documentation>
//       gml:VerticalDatum is a textual description and/or a set of parameters identifying a particular
//       reference level surface used as a zero-height surface, including its position with respect to the Earth
//       for any of the height types recognized by this International Standard.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="VerticalDatumType">
//   <complexContent>
//     <extension base="gml:AbstractDatumType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="VerticalDatumPropertyType">
//   <annotation>
//     <documentation>
//       gml:VerticalDatumPropertyType is property type for association roles to a vertical datum,
//       either referencing or containing the definition of that datum.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:VerticalDatum"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// 
// <element name="verticalDatumRef" type="gml:VerticalDatumPropertyType">
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

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// The <see cref="VerticalDatumType"/> is a textual description and/or a set of parameters identifying a particular
  /// reference level surface used as a zero-height surface, including its position with respect to the Earth
  /// for any of the height types recognized by this International Standard.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>VerticalDatumType</c> ( /2005/gml/datums.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_VerticalDatum_Type))] // GMX
  [IsoType("VerticalDatumType", WrapperName = "VerticalDatumPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VerticalDatumType")]
  public class VerticalDatumType : AbstractDatumType {

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a <see cref="VerticalDatumType"/>.
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
