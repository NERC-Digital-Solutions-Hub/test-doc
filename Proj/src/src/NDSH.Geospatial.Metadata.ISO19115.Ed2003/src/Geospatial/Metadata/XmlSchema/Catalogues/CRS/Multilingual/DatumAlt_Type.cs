
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/01/2023, @gisvlasta
// History           : 31/03/2025, @gisvlasta - Added IsoTypeAttribute, corrected CodeSpace nullability,
//                                               updated code and documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/crsItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="DatumAlt_Type">
//   <xs:annotation>
//     <xs:documentation>
//       XML attributes constraints:
//         - 1) Id is mandatory
//         - 2) codeSpace (type xsd:anyURI) is mandatory
//     </xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gml:AbstractDatumType">
//       <xs:sequence>
//         <xs:element name="locale" type="gmd:PT_Locale_PropertyType"/>
//       </xs:sequence>
//       <xs:attribute name="codeSpace" type="xs:anyURI" use="required"/>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// 
// <xs:element name="DatumAlt" type="gmx:DatumAlt_Type"/>
// 
// <xs:complexType name="DatumAlt_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:DatumAlt"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml;
using NDSH.Geospatial.Gml.Coordinate.Datums;
using NDSH.Geospatial.Metadata.Localisation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual {

  /// <summary>
  /// Represents an alternative (localized) definition of a geodetic datum,
  /// intended for use in multilingual coordinate reference system catalogs.
  /// This type extends the standard GML <see cref="AbstractDatumType"/>
  /// with additional attributes to support localization, including a locale and
  /// a codeSpace to define the context of the alternative definition.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     XML attributes constraints:
  ///     <list type="number">
  ///       <item>The <see cref="AbstractGMLType.Id">Id</see> is mandatory.</item>
  ///       <item>
  ///         The <see cref="CodeSpace"/> (type <c>xsd:anyURI</c>) is mandatory and
  ///         identifies the namespace of the alternative datum.
  ///       </item>
  ///     </list>
  ///   </para>
  ///   <para>Maps to: <c>DatumAlt_Type</c> ( /2005/gmx/crsItem.xsd )</para>
  /// </remarks>
  [IsoType("DatumAlt_Type", WrapperName = "DatumAlt_PropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("DatumAlt", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("DatumAlt", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("DatumAlt")]
  public class DatumAlt_Type : AbstractDatumType, IAlternative {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DatumAlt_Type"/>.
    /// </summary>
    public DatumAlt_Type() {

    }

    #endregion

    #region IAlternative Interface

    private PT_Locale_Type _locale;

    /// <summary>
    /// Gets/Sets the <see cref="PT_Locale_Type"/> that defines the locale
    /// in which this alternative datum definition is expressed.
    /// </summary>
    //[XmlElement("locale", Order = 0)]
    [JsonProperty("locale", Order = 0)]
    public required PT_Locale_Type Locale {
      get => _locale;
      set => SetProperty(ref _locale, value);
    }

    private string _codeSpace;

    /// <summary>
    /// Gets/Sets the URI identifying the code space that provides the context or
    /// namespace for this alternative datum definition.
    /// </summary>
    /// <remarks>
    ///   <para>This value is required.</para>
    ///   <para>Must be a valid URI (type <c>xsd:anyURI</c> in the XSD schema).</para>
    /// </remarks>
    // WARNING: Add URI validation here.
    //[XmlAttribute("codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    [Required()]
    public required string CodeSpace {
      get => _codeSpace;
      set => SetProperty(ref _codeSpace, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets the association metadata for the current datum alternative.
    /// Only <see cref="TypeAssociationMetadata.Reference">references</see> and
    /// <see cref="TypeAssociationMetadata.NilReason">nil reasons</see> are allowed.
    /// <see cref="<see cref="TypeAssociationMetadata.Association">Associations</see>
    /// are explicitly disallowed in this context.
    /// </summary>
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
          TypeAssociationMetadata.Association => throw new InvalidOperationException(
            $"{nameof(AssociationEntity)} is not allowed in this context." // RESOURCE
          ),
          TypeAssociationMetadata.Reference => value,
          TypeAssociationMetadata.NilReason => value,
          _ => throw new ArgumentException(
            $"Unsupported subtype of {nameof(TypeAssociationMetadata)}: {value.GetType().Name}" // RESOURCE
          ),
        };
      }
    }

    #endregion

  }

}
