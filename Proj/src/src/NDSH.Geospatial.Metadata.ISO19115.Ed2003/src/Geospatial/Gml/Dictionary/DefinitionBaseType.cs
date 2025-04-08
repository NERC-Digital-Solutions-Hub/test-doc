
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// History           : 17/03/2025, @gisvlasta - Provided a new implementation of the Identifier property,
//                                               and updated documentation and header.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : The StandardObjectProperties defines a nullable (minOccurs="0") gml:identifier
//                     The DefinitionBaseType defines non-nullable gml:identifier
//                     Therefore the DefinitionBaseType must implement a new Identifier property (overriding the
//                     inherited one).
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
//                     /2005/gml/dictionary.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="metaDataProperty" type="gml:MetaDataPropertyType"></element>
// <element name="description" type="gml:StringOrRefType"></element>
// <element name="descriptionReference" type="gml:ReferenceType"></element>
// <element name="name" type="gml:CodeType"></element>
// <element name="identifier" type="gml:CodeWithAuthorityType"></element>
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
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Dictionary {

  // WARNING: Rename from DefinitionBaseType to DefinitionBase.

  #region XmlIncludes
  //[XmlInclude(typeof(ClAlternativeExpression_Type))] // GMX
  //[XmlInclude(typeof(CodeAlternativeExpression_Type))] // GMX
  //[XmlInclude(typeof(CodeDefinition_Type))] // GMX
  //[XmlInclude(typeof(CodeListDictionary_Type))] // GMX
  //[XmlInclude(typeof(CoordinateSystemAlt_Type))] // GMX
  //[XmlInclude(typeof(CoordinateSystemAxisAlt_Type))] // GMX
  //[XmlInclude(typeof(CrsAlt_Type))] // GMX
  //[XmlInclude(typeof(DatumAlt_Type))] // GMX
  //[XmlInclude(typeof(EllipsoidAlt_Type))] // GMX
  //[XmlInclude(typeof(ML_AffineCS_Type))] // GMX
  //[XmlInclude(typeof(ML_BaseUnit_Type))] // GMX
  //[XmlInclude(typeof(ML_CartesianCS_Type))] // GMX
  //[XmlInclude(typeof(ML_CodeDefinition_Type))] // GMX
  //[XmlInclude(typeof(ML_CodeListDictionary_Type))] // GMX
  //[XmlInclude(typeof(ML_CompoundCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_ConcatenatedOperation_Type))] // GMX
  //[XmlInclude(typeof(ML_ConventionalUnit_Type))] // GMX
  //[XmlInclude(typeof(ML_Conversion_Type))] // GMX
  //[XmlInclude(typeof(ML_CoordinateSystemAxis_Type))] // GMX
  //[XmlInclude(typeof(ML_CylindricalCS_Type))] // GMX
  //[XmlInclude(typeof(ML_DerivedCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_DerivedUnit_Type))] // GMX
  //[XmlInclude(typeof(ML_Ellipsoid_Type))] // GMX
  //[XmlInclude(typeof(ML_EllipsoidalCS_Type))] // GMX
  //[XmlInclude(typeof(ML_EngineeringCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_EngineeringDatum_Type))] // GMX
  //[XmlInclude(typeof(ML_GeodeticCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_GeodeticDatum_Type))] // GMX
  //[XmlInclude(typeof(ML_ImageCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_ImageDatum_Type))] // GMX
  //[XmlInclude(typeof(ML_LinearCS_Type))] // GMX
  //[XmlInclude(typeof(ML_OperationMethod_Type))] // GMX
  //[XmlInclude(typeof(ML_OperationParameter_Type))] // GMX
  //[XmlInclude(typeof(ML_OperationParameterGroup_Type))] // GMX
  //[XmlInclude(typeof(ML_PassThroughOperation_Type))] // GMX
  //[XmlInclude(typeof(ML_PolarCS_Type))] // GMX
  //[XmlInclude(typeof(ML_PrimeMeridian_Type))] // GMX
  //[XmlInclude(typeof(ML_ProjectedCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_SphericalCS_Type))] // GMX
  //[XmlInclude(typeof(ML_TemporalCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_TemporalDatum_Type))] // GMX
  //[XmlInclude(typeof(ML_TimeCS_Type))] // GMX
  //[XmlInclude(typeof(ML_Transformation_Type))] // GMX
  //[XmlInclude(typeof(ML_UnitDefinition_Type))] // GMX
  //[XmlInclude(typeof(ML_UserDefinedCS_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalCS_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalDatum_Type))] // GMX
  //[XmlInclude(typeof(OperationAlt_Type))] // GMX
  //[XmlInclude(typeof(OperationMethodAlt_Type))] // GMX
  //[XmlInclude(typeof(OperationParameterAlt_Type))] // GMX
  //[XmlInclude(typeof(PrimeMeridianAlt_Type))] // GMX
  //[XmlInclude(typeof(UomAlternativeExpression_Type))] // GMX
  //[XmlInclude(typeof(DefinitionType))]
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
  /// Represents the base type for definitions in GML.
  /// This class serves as a restriction of <see cref="AbstractGMLType"/>,
  /// implementing the <see cref="IStandardObjectProperties"/> interface.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     This type enforces the presence of an <see cref="Identifier">Identifier</see>
  ///     and allows additional metadata and descriptive properties.
  ///   </para>
  ///   <para>Maps to: <c>DefinitionBaseType</c> ( /2005/gml/gmlBase.xsd )</para>
  /// </remarks>
  [IsoType("DefinitionBaseType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("DefinitionBaseType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DefinitionBaseType")]
  public class DefinitionBaseType : AbstractGMLType {

    #region Public Properties

    private CodeWithAuthorityType _identifier = new();

    /// <summary>
    /// Gets/Sets the label or identifier for the object, commonly a descriptive name.
    /// </summary>
    /// <remarks>
    /// An object may have several names, typically assigned by different authorities.
    /// <c>gml:name</c> uses the <c>gml:CodeType</c> content model. The authority for a name
    /// is indicated by the value of its (optional) codeSpace attribute. The name may or may not be unique,
    /// as determined by the rules of the organization responsible for the codeSpace.
    /// In common usage there will be one name per authority, so a processing application
    /// may select the name from its preferred codeSpace.
    /// </remarks>
    /// <example>
    /// Example of a valid identifier:
    /// <code>
    /// var definition = new DefinitionBaseType {
    ///   Identifier = new CodeWithAuthorityType {
    ///     Code = "EPSG:4326",
    ///     Authority = "EPSG"
    ///   }
    /// };
    /// </code>
    /// </example>
    [Required()]
    [JsonRequired()]
    public new required CodeWithAuthorityType Identifier {
      get => _identifier;
      set => SetProperty(ref _identifier, value);
    }

    #endregion

  }

}
