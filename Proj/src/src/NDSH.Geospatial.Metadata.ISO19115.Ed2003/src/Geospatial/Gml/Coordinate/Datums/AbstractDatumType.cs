
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/02/2023, @gisvlasta
// History           : 18/03/2025, @gisvlasta - Added IsoTypeAttribute, updated code and documentation.
//                   : 25/03/2025, @gisvlasta - Implemented IAssociated interface and updated class documentation.
//                   : 31/03/2025, @gisvlasta - Changed implemented interface from IAssociated to ITypeAssociated and
//                                               updated documentation and header.
//                   : 01/04/2025, @gisvlasta - Marked properties 'AnchorDefinition' and 'RealizationEpoch' as virtual.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/datums.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="domainOfValidity">
//   <annotation>
//     <documentation>
//       The gml:domainOfValidity property implements an association role to an EX_Extent object as
//       encoded in ISO/TS 19139, either referencing or containing the definition of that extent.
//     </documentation>
//   </annotation>
//   <complexType>
//     <sequence minOccurs="0">
//       <element ref="gmd:EX_Extent"/>
//     </sequence>
//     <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   </complexType>
// </element>
// 
// <element name="scope" type="string">
//   <annotation>
//     <documentation>
//       The gml:scope property provides a description of the usage, or limitations of usage,
//       for which this CRS-related object is valid. If unknown, enter "not known".
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="anchorDefinition" type="gml:CodeType">
//   <annotation>
//     <documentation>
//       gml:anchorDefinition is a description, possibly including coordinates, of the definition used to anchor
//       the datum to the Earth. Also known as the "origin", especially for engineering and image datums.
//       The codeSpace attribute may be used to reference a source of more detailed on this point or surface,
//       or on a set of such descriptions.
//       - For a geodetic datum, this point is also known as the fundamental point, which is traditionally the point
//         where the relationship between geoid and ellipsoid is defined. In some cases,
//         the "fundamental point" may consist of a number of points. In those cases,
//         the parameters defining the geoid/ellipsoid relationship have been averaged for these points,
//         and the averages adopted as the datum definition.
//       - For an engineering datum, the anchor definition may be a physical point, or it may be a point
//         with defined coordinates in another CRS.may
//       - For an image datum, the anchor definition is usually either the centre of the image or
//         the corner of the image.
//       - For a temporal datum, this attribute is not defined. Instead of the anchor definition,
//         a temporal datum carries a separate time origin of type DateTime.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="anchorPoint" type="gml:CodeType" substitutionGroup="gml:anchorDefinition">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="realizationEpoch" type="date">
//   <annotation>
//     <documentation>
//       gml:realizationEpoch is the time after which this datum definition is valid.
//       See ISO 19111 Table 32 for details.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="AbstractDatum" type="gml:AbstractDatumType" abstract="true" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       A gml:AbstractDatum specifies the relationship of a coordinate system to the earth,
//       thus creating a coordinate reference system. A datum uses a parameter or set of parameters that determine
//       the location of the origin of the coordinate reference system. Each datum subtype may be associated
//       with only specific types of coordinate systems. This abstract complex type shall not be used, extended,
//       or restricted, in a GML Application Schema, to define a concrete subtype with a meaning equivalent to
//       a concrete subtype specified in this document.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="AbstractDatumType" abstract="true">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:domainOfValidity" minOccurs="0"/>
//         <element ref="gml:scope" maxOccurs="unbounded"/>
//         <element ref="gml:anchorDefinition" minOccurs="0"/>
//         <element ref="gml:realizationEpoch" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="DatumPropertyType">
//   <annotation>
//     <documentation>
//       gml:DatumPropertyType is a property type for association roles to a datum,
//       either referencing or containing the definition of that datum.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractDatum"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata;
using NDSH.Geospatial.Metadata.Extent;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  #region XmlIncludes
  //[XmlInclude(typeof(DatumAlt_Type))] // GMX
  //[XmlInclude(typeof(ML_EngineeringDatum_Type))] // GMX
  //[XmlInclude(typeof(ML_GeodeticDatum_Type))] // GMX
  //[XmlInclude(typeof(ML_ImageDatum_Type))] // GMX
  //[XmlInclude(typeof(ML_TemporalDatum_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalDatum_Type))] // GMX
  //[XmlInclude(typeof(TemporalDatumBaseType))]
  //[XmlInclude(typeof(TemporalDatumType))]
  //[XmlInclude(typeof(VerticalDatumType))]
  //[XmlInclude(typeof(ImageDatumType))]
  //[XmlInclude(typeof(EngineeringDatumType))]
  //[XmlInclude(typeof(GeodeticDatumType))]
  #endregion

  /// <summary>
  /// The <see cref="AbstractDatumType"/> specifies the relationship of a coordinate system to the earth,
  /// thus creating a coordinate reference system. A datum uses a parameter or set of parameters that determine
  /// the location of the origin of the coordinate reference system. Each datum subtype may be associated
  /// with only specific types of coordinate systems. This abstract complex type shall not be used, extended,
  /// or restricted, in a GML Application Schema, to define a concrete subtype with a meaning equivalent to
  /// a concrete subtype specified in this document.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractDatumType</c> ( /2005/gml/datums.xsd )
  /// </remarks>
  [IsoType("AbstractDatumType", WrapperName = "DatumPropertyType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractDatumType")]
  public abstract class AbstractDatumType : IdentifiedObjectType, ITypeAssociated {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractDatumType"/>.
    /// </summary>
    public AbstractDatumType() {
      _domainOfValidity = default;
      _scope = [];
      _anchorDefinition = default;
      _realizationEpoch = default;
    }

    #endregion

    #region Public Properties

    private EX_Extent_Type? _domainOfValidity;

    /// <summary>
    /// Gets/Sets an association role to an <see cref="EX_Extent_Type"/> object as encoded in ISO/TS 19139,
    /// either referencing or containing the definition of that extent.
    /// </summary>
    //[XmlElement("domainOfValidity", Order = 0)]
    [JsonProperty("domainOfValidity", Order = 0)]
    public EX_Extent_Type? DomainOfValidity {
      get => _domainOfValidity;
      set => SetProperty(ref _domainOfValidity, value);
    }

    private ObservableCollection<string> _scope;

    /// <summary>
    /// Gets/Sets the description of the usage, or limitations of usage,
    /// for which this coordinate reference system related object is valid.
    /// </summary>
    /// <remarks>
    /// If unknown, enter "not known".
    /// </remarks>
    // WARNING: Add a validation rule to make sure the behaviour described in remarks is observed.
    //[XmlElement("scope", Order = 1)]
    [JsonProperty("scope", Order = 1)]
    public ObservableCollection<string> Scope {
      get => _scope;
      set => SetProperty(ref _scope, value);
    }

    private CodeType? _anchorDefinition;

    /// <summary>
    ///   <para>
    ///     Gets/Sets the definition of the anchor point used to define the datum.
    ///   </para>
    ///   <para>
    ///     The <see cref="AnchorDefinition"/> is a description, possibly including coordinates,
    ///     of the definition used to anchor the datum to the Earth. Also known as the "origin",
    ///     especially for engineering and image datums. The <see cref="CodeType.CodeSpace">CodeSpace</see> attribute
    ///     may be used to reference a source of more detailed on this point or surface,
    ///     or on a set of such descriptions.
    ///     <list type="bullet">
    ///       <item>
    ///         <term>Geodetic Datum</term>
    ///         <description>
    ///           This point is also known as the fundamental point, which is traditionally the point
    ///           where the relationship between geoid and ellipsoid is defined. In some cases,
    ///           the "fundamental point" may consist of a number of points. In those cases,
    ///           the parameters defining the geoid/ellipsoid relationship have been averaged for these points,
    ///           and the averages adopted as the datum definition.
    ///         </description>
    ///       </item>
    ///       <item>
    ///         <term>Engineering Datum</term>
    ///         <description>
    ///           The anchor definition may be a physical point,
    ///           or it may be a point with defined coordinates in another coordinate reference system.
    ///         </description>
    ///       </item>
    ///       <item>
    ///         <term>Image Datum</term>
    ///         <description>
    ///           The anchor definition is usually either the centre of the image or the corner of the image.
    ///         </description>
    ///       </item>
    ///       <item>
    ///         <term>Temporal Datum</term>
    ///         <description>
    ///           This attribute is not defined. Instead of the anchor definition,
    ///           a temporal datum carries a separate time origin of type DateTime.
    ///         </description>
    ///       </item>
    ///     </list>
    ///   </para>
    /// </summary>
    [JsonProperty("anchorDefinition", Order = 2)]
    public virtual CodeType? AnchorDefinition {
      get => _anchorDefinition;
      set => SetProperty(ref _anchorDefinition, value);
    }

    private DateOnly? _realizationEpoch;

    /// <summary>
    /// Gets/Sets the time after which this datum definition is valid.
    /// </summary>
    /// <remarks>See ISO 19111 Table 32 for details.</remarks>
    //[XmlElement("realizationEpoch", DataType = "date", Order = 3)]
    [JsonProperty("realizationEpoch", Order = 3)]
    public virtual DateOnly? RealizationEpoch {
      get => _realizationEpoch;
      set => SetProperty(ref _realizationEpoch, value);
    }

    #endregion

    #region ITypeAssociated Interface

    /// <summary>
    /// Gets/Sets a <see cref="TypeAssociationMetadata">union association</see>
    /// of <see cref="AssociationEntity"/> or <see cref="ReferenceEntity"/>
    /// to a <see cref="AbstractDatumType">datum</see>.
    /// </summary>
    public abstract TypeAssociationMetadata? TypeAssociation {
      get;
      set;
    }

    #endregion

  }

}
