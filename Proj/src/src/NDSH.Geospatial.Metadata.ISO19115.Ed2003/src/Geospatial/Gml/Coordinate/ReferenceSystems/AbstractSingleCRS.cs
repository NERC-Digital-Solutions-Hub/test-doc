
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 18/03/2025, @gisvlasta
// History           : 25/03/2025, @gisvlasta - Added IsoTypeAttribute, updated code, and documentation.
//                   : 27/03/2025, @gisvlasta - Updated overridden property to reflect the changes in the
//                                               parent class.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateReferenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractSingleCRS" type="gml:AbstractCRSType" abstract="true" substitutionGroup="gml:AbstractCRS">
//   <annotation>
//     <documentation>
//       gml:AbstractSingleCRS implements a coordinate reference system consisting of
//       one coordinate system and one datum (as opposed to a Compound CRS).
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="SingleCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:SingleCRSPropertyType is a property type for association roles to a single coordinate reference system,
//       either referencing or containing the definition of that coordinate reference system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractSingleCRS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.ReferenceSystems {

  /// <summary>
  /// The <see cref="AbstractSingleCRS"/> implements a coordinate reference system consisting of
  /// one coordinate system and one datum (as opposed to a Compound CRS).
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractSingleCRS</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  [IsoType("AbstractSingleCRS", WrapperName = "SingleCRSPropertyType", IsAbstract = true, IsoType = IsoTypes.Element)]
  public abstract class AbstractSingleCRS : AbstractCRSType, ISingleCRS {

    #region Public overrides

    /// <summary>
    /// Gets/Sets a <see cref="TypeAssociationMetadata">union association</see>
    /// of <see cref="AssociationEntity"/> or <see cref="ReferenceEntity"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This property is primarily used to get/set an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="AbstractSingleCRS">single coordinate reference system</see>.
    /// </para>
    /// <para>
    /// The <see cref="AbstractSingleCRS"/> defines a coordinate reference system consisting of
    /// one coordinate system and one datum (as opposed to a Compound CRS).
    /// </para>
    /// </remarks>
    public override abstract TypeAssociationMetadata? TypeAssociation {
      get;
      set;
    }

    #endregion

  }

}
