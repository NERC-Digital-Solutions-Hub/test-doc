
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// History           : 17/03/2025, @gisvlasta - Added IsoTypeAttribute, updated code, documentation, and header.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : DefinitionType ->  [substitutes: AbstractGML]
//                       DefinitionBaseType ->
//                         AbstractGMLType ->
//                           AbstractObject ->
//                             ObservableDbEntity ->
//                               ObservableModel ->
//                                 Model
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
//                     /2005/gml/dictionary.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="metaDataProperty" type="gml:MetaDataPropertyType"></element>
// <element name="description" type="gml:StringOrRefType"></element>
// <element name="descriptionReference" type="gml:ReferenceType"></element>
// <element name="identifier" type="gml:CodeWithAuthorityType"></element>
// <element name="name" type="gml:CodeType"></element>
// 
// <group name="StandardObjectProperties">
//   <sequence>
//     <element ref="gml:metaDataProperty" minOccurs="0" maxOccurs="unbounded"/>
//     <element ref="gml:description" minOccurs="0"/>
//     <element ref="gml:descriptionReference" minOccurs="0"/>
//     <element ref="gml:identifier" minOccurs="0"/>
//     <element ref="gml:name" minOccurs="0" maxOccurs="unbounded"/>
//   </sequence>
// </group>
// 
// <element name="Definition" type="gml:DefinitionType" substitutionGroup="gml:AbstractGML">
//   <annotation>
//     <documentation>
//       The basic gml:Definition element specifies a definition, which can be included in or
//       referenced by a dictionary. The content model for a generic definition is a derivation
//       from gml:AbstractGMLType.
//       The gml:description property element shall hold the definition if this can be captured in a simple text string,
//       or the gml:descriptionReference property element may carry a link to a description elsewhere.
//       The gml:identifier element shall provide one identifier identifying this definition.
//       The identifier shall be unique within the dictionaries using this definition.
//       The gml:name elements shall provide zero or more terms and synonyms for which this is the definition.
//       The gml:remarks element shall be used to hold additional textual information that is not conceptually part
//       of the definition but is useful in understanding the definition.
//     </documentation>
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
// <element name="remarks" type="string"/>
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
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Dictionary {

  // WARNING: Rename from DefinitionType to Definition.

  #region XmlIncludes
  //[XmlInclude(typeof(AbstractCoordinateOperationType))]
  //[XmlInclude(typeof(AbstractCoordinateSystemType))]
  //[XmlInclude(typeof(AbstractCRSType))]
  //[XmlInclude(typeof(AbstractDatumType))]
  //[XmlInclude(typeof(AbstractGeneralConversionType))]
  //[XmlInclude(typeof(AbstractGeneralDerivedCRSType))]
  //[XmlInclude(typeof(AbstractGeneralOperationParameterType))]
  //[XmlInclude(typeof(AbstractGeneralTransformationType))]
  //[XmlInclude(typeof(AffineCSType))]
  //[XmlInclude(typeof(BaseUnitType))]
  //[XmlInclude(typeof(CartesianCSType))]
  //[XmlInclude(typeof(ClAlternativeExpression_Type))]
  //[XmlInclude(typeof(CodeAlternativeExpression_Type))]
  //[XmlInclude(typeof(CodeDefinition_Type))]
  //[XmlInclude(typeof(CodeListDictionary_Type))]
  //[XmlInclude(typeof(CompoundCRSType))]
  //[XmlInclude(typeof(ConcatenatedOperationType))]
  //[XmlInclude(typeof(ConventionalUnitType))]
  //[XmlInclude(typeof(ConversionType))]
  //[XmlInclude(typeof(CoordinateSystemAlt_Type))]
  //[XmlInclude(typeof(CoordinateSystemAxisAlt_Type))]
  //[XmlInclude(typeof(CoordinateSystemAxisType))]
  //[XmlInclude(typeof(CrsAlt_Type))]
  //[XmlInclude(typeof(CylindricalCSType))]
  //[XmlInclude(typeof(DatumAlt_Type))]
  //[XmlInclude(typeof(DefinitionProxyType))]
  //[XmlInclude(typeof(DerivedCRSType))]
  //[XmlInclude(typeof(DerivedUnitType))]
  //[XmlInclude(typeof(DictionaryType))]
  //[XmlInclude(typeof(EllipsoidalCSType))]
  //[XmlInclude(typeof(EllipsoidAlt_Type))]
  //[XmlInclude(typeof(EllipsoidType))]
  //[XmlInclude(typeof(EngineeringCRSType))]
  //[XmlInclude(typeof(EngineeringDatumType))]
  //[XmlInclude(typeof(GeocentricCRSType))]
  //[XmlInclude(typeof(GeodeticCRSType))]
  //[XmlInclude(typeof(GeodeticDatumType))]
  //[XmlInclude(typeof(GeographicCRSType))]
  //[XmlInclude(typeof(IdentifiedObjectType))]
  //[XmlInclude(typeof(ImageCRSType))]
  //[XmlInclude(typeof(ImageDatumType))]
  //[XmlInclude(typeof(LinearCSType))]
  //[XmlInclude(typeof(ML_AffineCS_Type))]
  //[XmlInclude(typeof(ML_BaseUnit_Type))]
  //[XmlInclude(typeof(ML_CartesianCS_Type))]
  //[XmlInclude(typeof(ML_CodeDefinition_Type))]
  //[XmlInclude(typeof(ML_CodeListDictionary_Type))]
  //[XmlInclude(typeof(ML_CompoundCRS_Type))]
  //[XmlInclude(typeof(ML_ConcatenatedOperation_Type))]
  //[XmlInclude(typeof(ML_ConventionalUnit_Type))]
  //[XmlInclude(typeof(ML_Conversion_Type))]
  //[XmlInclude(typeof(ML_CoordinateSystemAxis_Type))]
  //[XmlInclude(typeof(ML_CylindricalCS_Type))]
  //[XmlInclude(typeof(ML_DerivedCRS_Type))]
  //[XmlInclude(typeof(ML_DerivedUnit_Type))]
  //[XmlInclude(typeof(ML_Ellipsoid_Type))]
  //[XmlInclude(typeof(ML_EllipsoidalCS_Type))]
  //[XmlInclude(typeof(ML_EngineeringCRS_Type))]
  //[XmlInclude(typeof(ML_EngineeringDatum_Type))]
  //[XmlInclude(typeof(ML_GeodeticCRS_Type))]
  //[XmlInclude(typeof(ML_GeodeticDatum_Type))]
  //[XmlInclude(typeof(ML_ImageCRS_Type))]
  //[XmlInclude(typeof(ML_ImageDatum_Type))]
  //[XmlInclude(typeof(ML_LinearCS_Type))]
  //[XmlInclude(typeof(ML_OperationMethod_Type))]
  //[XmlInclude(typeof(ML_OperationParameter_Type))]
  //[XmlInclude(typeof(ML_OperationParameterGroup_Type))]
  //[XmlInclude(typeof(ML_PassThroughOperation_Type))]
  //[XmlInclude(typeof(ML_PolarCS_Type))]
  //[XmlInclude(typeof(ML_PrimeMeridian_Type))]
  //[XmlInclude(typeof(ML_ProjectedCRS_Type))]
  //[XmlInclude(typeof(ML_SphericalCS_Type))]
  //[XmlInclude(typeof(ML_TemporalCRS_Type))]
  //[XmlInclude(typeof(ML_TemporalDatum_Type))]
  //[XmlInclude(typeof(ML_TimeCS_Type))]
  //[XmlInclude(typeof(ML_Transformation_Type))]
  //[XmlInclude(typeof(ML_UnitDefinition_Type))]
  //[XmlInclude(typeof(ML_UserDefinedCS_Type))]
  //[XmlInclude(typeof(ML_VerticalCRS_Type))]
  //[XmlInclude(typeof(ML_VerticalCS_Type))]
  //[XmlInclude(typeof(ML_VerticalDatum_Type))]
  //[XmlInclude(typeof(ObliqueCartesianCSType))]
  //[XmlInclude(typeof(OperationAlt_Type))]
  //[XmlInclude(typeof(OperationMethodAlt_Type))]
  //[XmlInclude(typeof(OperationMethodType))]
  //[XmlInclude(typeof(OperationParameterAlt_Type))]
  //[XmlInclude(typeof(OperationParameterGroupType))]
  //[XmlInclude(typeof(OperationParameterType))]
  //[XmlInclude(typeof(PassThroughOperationType))]
  //[XmlInclude(typeof(PolarCSType))]
  //[XmlInclude(typeof(PrimeMeridianAlt_Type))]
  //[XmlInclude(typeof(PrimeMeridianType))]
  //[XmlInclude(typeof(ProjectedCRSType))]
  //[XmlInclude(typeof(SphericalCSType))]
  //[XmlInclude(typeof(TemporalCRSType))]
  //[XmlInclude(typeof(TemporalCSType))]
  //[XmlInclude(typeof(TemporalDatumBaseType))]
  //[XmlInclude(typeof(TemporalDatumType))]
  //[XmlInclude(typeof(TimeCalendarEraType))]
  //[XmlInclude(typeof(TimeCalendarType))]
  //[XmlInclude(typeof(TimeClockType))]
  //[XmlInclude(typeof(TimeCoordinateSystemType))]
  //[XmlInclude(typeof(TimeCSType))]
  //[XmlInclude(typeof(TimeOrdinalEraType))]
  //[XmlInclude(typeof(TimeOrdinalReferenceSystemType))]
  //[XmlInclude(typeof(TimeReferenceSystemType))]
  //[XmlInclude(typeof(TransformationType))]
  //[XmlInclude(typeof(UnitDefinitionType))]
  //[XmlInclude(typeof(UomAlternativeExpression_Type))]
  //[XmlInclude(typeof(UserDefinedCSType))]
  //[XmlInclude(typeof(VerticalCRSType))]
  //[XmlInclude(typeof(VerticalCSType))]
  //[XmlInclude(typeof(VerticalDatumType))]
  #endregion

  #region Extra XmlIncludes
  //[XmlInclude(typeof(TimeOrdinalEraType))]
  //[XmlInclude(typeof(TimeCalendarEraType))]
  //[XmlInclude(typeof(TimeReferenceSystemType))]
  //[XmlInclude(typeof(TimeOrdinalReferenceSystemType))]
  //[XmlInclude(typeof(TimeClockType))]
  //[XmlInclude(typeof(TimeCalendarType))]
  //[XmlInclude(typeof(TimeCoordinateSystemType))]
  //[XmlInclude(typeof(IdentifiedObjectType))]
  //[XmlInclude(typeof(EllipsoidType))]
  //[XmlInclude(typeof(PrimeMeridianType))]
  //[XmlInclude(typeof(AbstractDatumType))]
  //[XmlInclude(typeof(TemporalDatumBaseType))]
  //[XmlInclude(typeof(TemporalDatumType))]
  //[XmlInclude(typeof(VerticalDatumType))]
  //[XmlInclude(typeof(ImageDatumType))]
  //[XmlInclude(typeof(EngineeringDatumType))]
  //[XmlInclude(typeof(GeodeticDatumType))]
  //[XmlInclude(typeof(CoordinateSystemAxisType))]
  //[XmlInclude(typeof(AbstractCoordinateSystemType))]
  //[XmlInclude(typeof(ObliqueCartesianCSType))]
  //[XmlInclude(typeof(AffineCSType))]
  //[XmlInclude(typeof(CylindricalCSType))]
  //[XmlInclude(typeof(PolarCSType))]
  //[XmlInclude(typeof(SphericalCSType))]
  //[XmlInclude(typeof(UserDefinedCSType))]
  //[XmlInclude(typeof(LinearCSType))]
  //[XmlInclude(typeof(TemporalCSType))]
  //[XmlInclude(typeof(TimeCSType))]
  //[XmlInclude(typeof(VerticalCSType))]
  //[XmlInclude(typeof(CartesianCSType))]
  //[XmlInclude(typeof(EllipsoidalCSType))]
  //[XmlInclude(typeof(AbstractGeneralOperationParameterType))]
  //[XmlInclude(typeof(OperationParameterGroupType))]
  //[XmlInclude(typeof(OperationParameterType))]
  //[XmlInclude(typeof(OperationMethodType))]
  //[XmlInclude(typeof(AbstractCoordinateOperationType))]
  //[XmlInclude(typeof(PassThroughOperationType))]
  //[XmlInclude(typeof(ConcatenatedOperationType))]
  //[XmlInclude(typeof(AbstractGeneralTransformationType))]
  //[XmlInclude(typeof(TransformationType))]
  //[XmlInclude(typeof(AbstractGeneralConversionType))]
  //[XmlInclude(typeof(ConversionType))]
  //[XmlInclude(typeof(AbstractCRSType))]
  //[XmlInclude(typeof(GeocentricCRSType))]
  //[XmlInclude(typeof(TemporalCRSType))]
  //[XmlInclude(typeof(ImageCRSType))]
  //[XmlInclude(typeof(EngineeringCRSType))]
  //[XmlInclude(typeof(VerticalCRSType))]
  //[XmlInclude(typeof(CompoundCRSType))]
  //[XmlInclude(typeof(GeographicCRSType))]
  //[XmlInclude(typeof(GeodeticCRSType))]
  //[XmlInclude(typeof(AbstractGeneralDerivedCRSType))]
  //[XmlInclude(typeof(DerivedCRSType))]
  //[XmlInclude(typeof(ProjectedCRSType))]
  //[XmlInclude(typeof(UnitDefinitionType))]
  //[XmlInclude(typeof(ConventionalUnitType))]
  //[XmlInclude(typeof(DerivedUnitType))]
  //[XmlInclude(typeof(BaseUnitType))]
  //[XmlInclude(typeof(DefinitionProxyType))]
  //[XmlInclude(typeof(DictionaryType))]
  #endregion

  /// <summary>
  ///   <para>
  ///     The <see cref="DefinitionType"/> specifies a definition, which can be included
  ///     in or referenced by a dictionary. The content model for a generic definition
  ///     is a derivation from <see cref="AbstractGMLType"/>.
  ///   </para>
  ///   <para>
  ///     <list type="bullet">
  ///       <item>
  ///         The <see cref="AbstractGMLType.Description">Description</see> property
  ///         shall hold the definition if this can be captured in a simple text string.
  ///       </item>
  ///       <item>
  ///         The <see cref="AbstractGMLType.DescriptionReference">DescriptionReference</see>
  ///         property may carry a link to a description elsewhere.
  ///       </item>
  ///       <item>
  ///         The <see cref="DefinitionBaseType.Identifier">Identifier</see>
  ///         property shall provide one identifier identifying this definition.
  ///       </item>
  ///       <item>
  ///         The <see cref="DefinitionBaseType.Identifier">Identifier</see>
  ///         property shall be unique within the dictionaries using this definition.
  ///       </item>
  ///       <item>
  ///         The <see cref="AbstractGMLType.Name">Name</see> property shall provide
  ///         zero or more terms and synonyms for which this is the definition.
  ///       </item>
  ///     </list>
  ///   </para>
  ///   <para>
  ///     The <see cref="Remarks">Remarks</see> property shall be used to hold additional textual information
  ///     that is not conceptually part of the definition but is useful in understanding the definition.
  ///   </para>
  /// </summary>
  [IsoType("DefinitionType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("DefinitionType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DefinitionType")]
  public class DefinitionType : DefinitionBaseType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DefinitionType"/>.
    /// </summary>
    public DefinitionType() {

    }

    #endregion

    #region Public Properties

    private string? _remarks;

    /// <summary>
    /// Provides additional textual information that is not conceptually part of the definition
    /// but is useful for understanding it.
    /// </summary>
    /// <remarks>
    ///   <list type="bullet">
    ///     <item>
    ///       The <see cref="Remarks">Remarks</see> property can be used to store
    ///       notes, clarifications, or usage guidelines related to this definition.
    ///     </item>
    ///     <item>
    ///       Unlike the <b>description</b>, which provides a formal definition,
    ///       <b>remarks</b> are meant to provide <b>supporting</b> or <b>contextual information</b>.
    ///     </item>
    ///   </list>
    /// </remarks>
    /// <example>
    /// Example of setting remarks for a GML Definition:
    /// <code>
    /// var definition = new DefinitionType {
    ///   Identifier = new CodeWithAuthorityType {
    ///     Code = "EPSG:4326",
    ///     Authority = "EPSG"
    ///   },
    ///   Remarks = "Commonly used for WGS 84 coordinate reference system."
    /// };
    /// </code>
    /// </example>
    //[XmlElement("remarks", Order = 0)]
    [JsonProperty("remarks", Order = 0)]
    public string? Remarks {
      get => _remarks;
      set => SetProperty(ref _remarks, value);
    }

    #endregion

  }

}
