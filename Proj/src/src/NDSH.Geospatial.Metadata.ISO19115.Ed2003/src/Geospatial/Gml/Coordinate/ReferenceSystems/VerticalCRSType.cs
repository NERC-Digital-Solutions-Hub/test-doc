
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/03/2025, @gisvlasta
// History           : 18/03/2025, @gisvlasta - Added SetProperty method property setters.
//                   : 25/03/2025, @gisvlasta - Added IsoTypeAttribute and updated documentation.
//                   : 30/03/2025, @gisvlasta - Changed the override of the TypeAssociation property
//                                              inherited from AbstractCRSType.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateSystems.xsd
//                     /2005/gml/dictionary.xsd
//                     /2005/gml/referenceSystems.xsd
//                     /2005/gml/coordinateReferenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="verticalCS" type="gml:VerticalCSPropertyType">
//   <annotation>
//     <documentation>
//       gml:verticalCS is an association role to the vertical coordinate system used by this CRS.
//     </documentation>
//   </annotation>
// </element>
// <element name="usesVerticalCS" type="gml:VerticalCSPropertyType" substitutionGroup="gml:verticalCS">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="verticalDatum" type="gml:VerticalDatumPropertyType">
//   <annotation>
//     <documentation>gml:verticalDatum is an association role to the vertical datum used by this CRS.</documentation>
//   </annotation>
// </element>
// <element name="usesVerticalDatum" type="gml:VerticalDatumPropertyType" substitutionGroup="gml:verticalDatum">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="Definition" type="gml:DefinitionType" substitutionGroup="gml:AbstractGML">
//   <annotation>
//     <documentation>
//       The basic gml:Definition element specifies a definition,
//       which can be included in or referenced by a dictionary.
//       The content model for a generic definition is a derivation from gml:AbstractGMLType.
//       The gml:description property element shall hold the definition if this can be captured in a simple text string,
//       or the gml:descriptionReference property element may carry a link to a description elsewhere.
//       The gml:identifier element shall provide one identifier identifying this definition.
//       The identifier shall be unique within the dictionaries using this definition.
//       The gml:name elements shall provide zero or more terms and synonyms for which this is the definition.
//       The gml:remarks element shall be used to hold additional textual information that is not conceptually
//       part of the definition but is useful in understanding the definition.</documentation>
//   </annotation>
// </element>
// 
// <complexType name="DefinitionBaseType">
//   <complexContent>
//     <restriction base="gml:AbstractGMLType">
//       <sequence>
//         <element ref="gml:metaDataProperty" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:description" minOccurs="0"/>
//         <element ref="gml:descriptionReference" minOccurs="0"/>
//         <element ref="gml:identifier"/>
//         <element ref="gml:name" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//       <attribute ref="gml:id" use="required"/>
//     </restriction>
//   </complexContent>
// </complexType>
// 
// <complexType name="DefinitionType">
//   <complexContent>
//     <extension base="gml:DefinitionBaseType">
//       <sequence>
//         <element ref="gml:remarks" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <element name="AbstractCRS" type="gml:AbstractCRSType" abstract="true" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       gml:AbstractCRS specifies a coordinate reference system which is usually single but may be compound.
//       This abstract complex type shall not be used, extended, or restricted, in a GML Application Schema,
//       to define a concrete subtype with a meaning equivalent to a concrete subtype specified in this document.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="AbstractCRSType" abstract="true">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:domainOfValidity" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:scope" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <element name="AbstractSingleCRS" type="gml:AbstractCRSType" abstract="true" substitutionGroup="gml:AbstractCRS">
//   <annotation>
//     <documentation>
//       gml:AbstractSingleCRS implements a coordinate reference system consisting of
//       one coordinate system and one datum (as opposed to a Compound CRS).
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="VerticalCRS" type="gml:VerticalCRSType" substitutionGroup="gml:AbstractSingleCRS">
//   <annotation>
//     <documentation>
//       gml:VerticalCRS is a 1D coordinate reference system used for recording heights or depths.
//       Vertical CRSs make use of the direction of gravity to define the concept of height or depth,
//       but the relationship with gravity may not be straightforward. By implication,
//       ellipsoidal heights (h) cannot be captured in a vertical coordinate reference system.
//       Ellipsoidal heights cannot exist independently, but only as an inseparable part of
//       a 3D coordinate tuple defined in a geographic 3D coordinate reference system.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="VerticalCRSType">
//   <complexContent>
//     <extension base="gml:AbstractCRSType">
//       <sequence>
//         <element ref="gml:verticalCS"/>
//         <element ref="gml:verticalDatum"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="VerticalCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:VerticalCRSPropertyType is a property type for association roles to a vertical coordinate reference system,
//       either referencing or containing the definition of that reference system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:VerticalCRS"/>
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
  /// The <see cref="VerticalCRSType"/> is a 1D coordinate reference system used for recording heights or depths.
  /// Vertical CRSs make use of the direction of gravity to define the concept of height or depth,
  /// but the relationship with gravity may not be straightforward. By implication,
  /// ellipsoidal heights (h) cannot be captured in a vertical coordinate reference system.
  /// Ellipsoidal heights cannot exist independently, but only as an inseparable part of a 3D coordinate
  /// tuple defined in a geographic 3D coordinate reference system.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>VerticalCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_VerticalCRS_Type))] // GMX
  [IsoType("VerticalCRSType", WrapperName = "VerticalCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VerticalCRSType")]
  public class VerticalCRSType : AbstractCRSType, ISingleCRS {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="VerticalCRSType"/> .
    /// </summary>
    public VerticalCRSType() {

    }

    #endregion

    #region Public Properties

    private VerticalCSType _verticalCS;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="VerticalCSType"/> used by this coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 0)]
    [JsonProperty("verticalCS", Order = 0)]
    public VerticalCSType VerticalCS {
      get => _verticalCS;
      set => SetProperty(ref _verticalCS, value);
    }

    private VerticalDatumType _verticalDatum;

    /// <summary>
    /// Gets/Sets an association role to the <see cref="VerticalDatumType"/> used by this coordinate reference system.
    /// </summary>
    //[XmlElement(Order = 1)]
    [JsonProperty("verticalDatum", Order = 1)]
    public VerticalDatumType VerticalDatum {
      get => _verticalDatum;
      set => SetProperty(ref _verticalDatum, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="VerticalCRSType">vertical coordinate reference system</see>.
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
