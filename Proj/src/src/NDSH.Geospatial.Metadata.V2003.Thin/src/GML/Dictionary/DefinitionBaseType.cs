
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 19:48, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Units;
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Dictionary
{

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(ClAlternativeExpression_Type))] // GMX
  [XmlInclude(typeof(CodeAlternativeExpression_Type))] // GMX
  [XmlInclude(typeof(CodeDefinition_Type))] // GMX
  [XmlInclude(typeof(CodeListDictionary_Type))] // GMX
  [XmlInclude(typeof(CoordinateSystemAlt_Type))] // GMX
  [XmlInclude(typeof(CoordinateSystemAxisAlt_Type))] // GMX
  [XmlInclude(typeof(CrsAlt_Type))] // GMX
  [XmlInclude(typeof(DatumAlt_Type))] // GMX
  [XmlInclude(typeof(EllipsoidAlt_Type))] // GMX
  [XmlInclude(typeof(ML_AffineCS_Type))] // GMX
  [XmlInclude(typeof(ML_BaseUnit_Type))] // GMX
  [XmlInclude(typeof(ML_CartesianCS_Type))] // GMX
  [XmlInclude(typeof(ML_CodeDefinition_Type))] // GMX
  [XmlInclude(typeof(ML_CodeListDictionary_Type))] // GMX
  [XmlInclude(typeof(ML_CompoundCRS_Type))] // GMX
  [XmlInclude(typeof(ML_ConcatenatedOperation_Type))] // GMX
  [XmlInclude(typeof(ML_ConventionalUnit_Type))] // GMX
  [XmlInclude(typeof(ML_Conversion_Type))] // GMX
  [XmlInclude(typeof(ML_CoordinateSystemAxis_Type))] // GMX
  [XmlInclude(typeof(ML_CylindricalCS_Type))] // GMX
  [XmlInclude(typeof(ML_DerivedCRS_Type))] // GMX
  [XmlInclude(typeof(ML_DerivedUnit_Type))] // GMX
  [XmlInclude(typeof(ML_Ellipsoid_Type))] // GMX
  [XmlInclude(typeof(ML_EllipsoidalCS_Type))] // GMX
  [XmlInclude(typeof(ML_EngineeringCRS_Type))] // GMX
  [XmlInclude(typeof(ML_EngineeringDatum_Type))] // GMX
  [XmlInclude(typeof(ML_GeodeticCRS_Type))] // GMX
  [XmlInclude(typeof(ML_GeodeticDatum_Type))] // GMX
  [XmlInclude(typeof(ML_ImageCRS_Type))] // GMX
  [XmlInclude(typeof(ML_ImageDatum_Type))] // GMX
  [XmlInclude(typeof(ML_LinearCS_Type))] // GMX
  [XmlInclude(typeof(ML_OperationMethod_Type))] // GMX
  [XmlInclude(typeof(ML_OperationParameter_Type))] // GMX
  [XmlInclude(typeof(ML_OperationParameterGroup_Type))] // GMX
  [XmlInclude(typeof(ML_PassThroughOperation_Type))] // GMX
  [XmlInclude(typeof(ML_PolarCS_Type))] // GMX
  [XmlInclude(typeof(ML_PrimeMeridian_Type))] // GMX
  [XmlInclude(typeof(ML_ProjectedCRS_Type))] // GMX
  [XmlInclude(typeof(ML_SphericalCS_Type))] // GMX
  [XmlInclude(typeof(ML_TemporalCRS_Type))] // GMX
  [XmlInclude(typeof(ML_TemporalDatum_Type))] // GMX
  [XmlInclude(typeof(ML_TimeCS_Type))] // GMX
  [XmlInclude(typeof(ML_Transformation_Type))] // GMX
  [XmlInclude(typeof(ML_UnitDefinition_Type))] // GMX
  [XmlInclude(typeof(ML_UserDefinedCS_Type))] // GMX
  [XmlInclude(typeof(ML_VerticalCRS_Type))] // GMX
  [XmlInclude(typeof(ML_VerticalCS_Type))] // GMX
  [XmlInclude(typeof(ML_VerticalDatum_Type))] // GMX
  [XmlInclude(typeof(OperationAlt_Type))] // GMX
  [XmlInclude(typeof(OperationMethodAlt_Type))] // GMX
  [XmlInclude(typeof(OperationParameterAlt_Type))] // GMX
  [XmlInclude(typeof(PrimeMeridianAlt_Type))] // GMX
  [XmlInclude(typeof(UomAlternativeExpression_Type))] // GMX
  [XmlInclude(typeof(DefinitionType))]
  [XmlInclude(typeof(TimeOrdinalEraType))]
  [XmlInclude(typeof(TimeCalendarEraType))]
  [XmlInclude(typeof(TimeReferenceSystemType))]
  [XmlInclude(typeof(TimeOrdinalReferenceSystemType))]
  [XmlInclude(typeof(TimeClockType))]
  [XmlInclude(typeof(TimeCalendarType))]
  [XmlInclude(typeof(TimeCoordinateSystemType))]
  [XmlInclude(typeof(IdentifiedObjectType))]
  [XmlInclude(typeof(EllipsoidType))]
  [XmlInclude(typeof(PrimeMeridianType))]
  [XmlInclude(typeof(AbstractDatumType))]
  [XmlInclude(typeof(TemporalDatumBaseType))]
  [XmlInclude(typeof(TemporalDatumType))]
  [XmlInclude(typeof(VerticalDatumType))]
  [XmlInclude(typeof(ImageDatumType))]
  [XmlInclude(typeof(EngineeringDatumType))]
  [XmlInclude(typeof(GeodeticDatumType))]
  [XmlInclude(typeof(CoordinateSystemAxisType))]
  [XmlInclude(typeof(AbstractCoordinateSystemType))]
  [XmlInclude(typeof(ObliqueCartesianCSType))]
  [XmlInclude(typeof(AffineCSType))]
  [XmlInclude(typeof(CylindricalCSType))]
  [XmlInclude(typeof(PolarCSType))]
  [XmlInclude(typeof(SphericalCSType))]
  [XmlInclude(typeof(UserDefinedCSType))]
  [XmlInclude(typeof(LinearCSType))]
  [XmlInclude(typeof(TemporalCSType))]
  [XmlInclude(typeof(TimeCSType))]
  [XmlInclude(typeof(VerticalCSType))]
  [XmlInclude(typeof(CartesianCSType))]
  [XmlInclude(typeof(EllipsoidalCSType))]
  [XmlInclude(typeof(AbstractGeneralOperationParameterType))]
  [XmlInclude(typeof(OperationParameterGroupType))]
  [XmlInclude(typeof(OperationParameterType))]
  [XmlInclude(typeof(OperationMethodType))]
  [XmlInclude(typeof(AbstractCoordinateOperationType))]
  [XmlInclude(typeof(PassThroughOperationType))]
  [XmlInclude(typeof(ConcatenatedOperationType))]
  [XmlInclude(typeof(AbstractGeneralTransformationType))]
  [XmlInclude(typeof(TransformationType))]
  [XmlInclude(typeof(AbstractGeneralConversionType))]
  [XmlInclude(typeof(ConversionType))]
  [XmlInclude(typeof(AbstractCRSType))]
  [XmlInclude(typeof(GeocentricCRSType))]
  [XmlInclude(typeof(TemporalCRSType))]
  [XmlInclude(typeof(ImageCRSType))]
  [XmlInclude(typeof(EngineeringCRSType))]
  [XmlInclude(typeof(VerticalCRSType))]
  [XmlInclude(typeof(CompoundCRSType))]
  [XmlInclude(typeof(GeographicCRSType))]
  [XmlInclude(typeof(GeodeticCRSType))]
  [XmlInclude(typeof(AbstractGeneralDerivedCRSType))]
  [XmlInclude(typeof(DerivedCRSType))]
  [XmlInclude(typeof(ProjectedCRSType))]
  [XmlInclude(typeof(UnitDefinitionType))]
  [XmlInclude(typeof(ConventionalUnitType))]
  [XmlInclude(typeof(DerivedUnitType))]
  [XmlInclude(typeof(BaseUnitType))]
  [XmlInclude(typeof(DefinitionProxyType))]
  [XmlInclude(typeof(DictionaryType))]
  [Serializable]
  [XmlType("DefinitionBaseType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DefinitionBaseType")]
  public class DefinitionBaseType : AbstractGMLType
  {

  }

}
