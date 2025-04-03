
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 26/03/2025, @gisvlasta
// History           : 31/03/2025, @gisvlasta - Changed TypeAssociation override.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/datums.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="EngineeringDatum" type="gml:EngineeringDatumType" substitutionGroup="gml:AbstractDatum">
//   <annotation>
//     <documentation>
//       gml:EngineeringDatum defines the origin of an engineering coordinate reference system,
//       and is used in a region around that origin. This origin may be fixed with respect to the earth
//       (such as a defined point at a construction site), or be a defined point on a moving vehicle
//       (such as on a ship or satellite).
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="EngineeringDatumType">
//   <complexContent>
//     <extension base="gml:AbstractDatumType"/>
//   </complexContent>
// </complexType>
// 
// <complexType name="EngineeringDatumPropertyType">
//   <annotation>
//     <documentation>
//       gml:EngineeringDatumPropertyType is a property type for association roles to an engineering datum,
//       either referencing or containing the definition of that datum.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:EngineeringDatum"/>
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

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// The <see cref="EngineeringDatumType"/> defines the origin of an engineering coordinate reference system,
  /// and is used in a region around that origin. This origin may be fixed with respect to the earth
  /// (such as a defined point at a construction site), or be a defined point on a moving vehicle
  /// (such as on a ship or satellite).
  /// </summary>
  /// <remarks>
  /// Maps to: <c>EngineeringDatumType</c> ( /2005/gml/datums.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_EngineeringDatum_Type))] // GMX
  [IsoType("EngineeringDatumType", WrapperName = "EngineeringDatumPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EngineeringDatumType")]
  public class EngineeringDatumType : AbstractDatumType {

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to an <see cref="EngineeringDatumType"/>.
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
