
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 10/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/referenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="IdentifiedObjectType" abstract="true">
//   <annotation>
//     <documentation>
//       gml:IdentifiedObjectType provides identification properties of a CRS-related object.
//       In gml:DefinitionType, the gml:identifier element shall be the primary name by which this
//       object is identified, encoding the "name" attribute in the UML model.
//       Zero or more of the gml:name elements can be an unordered set of "identifiers",
//       encoding the "identifier" attribute in the UML model.
//       Each of these gml:name elements can reference elsewhere the object's defining information or be
//       an identifier by which this object can be referenced.
//       Zero or more other gml:name elements can be an unordered set of "alias" alternative names by which this CRS
//       related object is identified, encoding the "alias" attributes in the UML model.
//       An object may have several aliases, typically used in different contexts.
//       The context for an alias is indicated by the value of its (optional) codeSpace attribute.
//       Any needed version information shall be included in the codeSpace attribute of a
//       gml:identifier and gml:name elements.
//       In this use, the gml:remarks element in the gml:DefinitionType shall contain comments
//       on or information about this object, including data source information.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:DefinitionType"/>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Dictionary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.ReferenceSystems {

  #region XmlIncludes
  //[XmlInclude(typeof(CoordinateSystemAlt_Type))] // GMX
  //[XmlInclude(typeof(CoordinateSystemAxisAlt_Type))] // GMX
  //[XmlInclude(typeof(CrsAlt_Type))] // GMX
  //[XmlInclude(typeof(DatumAlt_Type))] // GMX
  //[XmlInclude(typeof(EllipsoidAlt_Type))] // GMX
  //[XmlInclude(typeof(ML_AffineCS_Type))] // GMX
  //[XmlInclude(typeof(ML_CartesianCS_Type))] // GMX
  //[XmlInclude(typeof(ML_CompoundCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_ConcatenatedOperation_Type))] // GMX
  //[XmlInclude(typeof(ML_Conversion_Type))] // GMX
  //[XmlInclude(typeof(ML_CoordinateSystemAxis_Type))] // GMX
  //[XmlInclude(typeof(ML_CylindricalCS_Type))] // GMX
  //[XmlInclude(typeof(ML_DerivedCRS_Type))] // GMX
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
  //[XmlInclude(typeof(ML_UserDefinedCS_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalCS_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalDatum_Type))] // GMX
  //[XmlInclude(typeof(OperationAlt_Type))] // GMX
  //[XmlInclude(typeof(OperationMethodAlt_Type))] // GMX
  //[XmlInclude(typeof(OperationParameterAlt_Type))] // GMX
  //[XmlInclude(typeof(PrimeMeridianAlt_Type))] // GMX
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
  #endregion

  /// <summary>
  /// The <see cref="IdentifiedObjectType"/> provides identification properties of a <b>CRS-related</b> object.
  /// In <see cref="DefinitionType"/>, the <see cref="AbstractGMLType.Identifier">Identifier</see>
  /// shall be the primary name by which this object is identified, encoding the
  /// <see cref="AbstractGMLType.Name">Name</see> in the UML model.
  /// Zero or more of the <see cref="AbstractGMLType.Name">Name</see> elements can be an
  /// unordered set of <see cref="AbstractGMLType.Identifier">Identifiers</see>,
  /// encoding the <see cref="AbstractGMLType.Identifier">Identifier</see> attribute in the UML model.
  /// Each of these <see cref="AbstractGMLType.Name">Name</see> elements can reference elsewhere
  /// the object's defining information or be an <see cref="AbstractGMLType.Identifier">Identifier</see>
  /// by which this object can be referenced. Zero or more other <see cref="AbstractGMLType.Name">Name</see>
  /// elements can be an unordered set of "alias" alternative names by which this CRS related object is identified,
  /// encoding the "alias" attributes in the UML model. An object may have several aliases,
  /// typically used in different contexts. The context for an alias is indicated by the value
  /// of its (optional) <c>codeSpace</c> attribute. Any needed version information shall be included
  /// in the <c>codeSpace</c> attribute of a <see cref="AbstractGMLType.Identifier">Identifier</see> and
  /// <see cref="AbstractGMLType.Name">Name</see> elements. In this use,
  /// the <see cref="DefinitionType.Remarks">Remarks</see> element shall contain
  /// comments on or information about this object, including data source information.
  /// </summary>
  [IsoType("IdentifiedObjectType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("IdentifiedObjectType")]
  public abstract class IdentifiedObjectType : DefinitionType {

  }

}
