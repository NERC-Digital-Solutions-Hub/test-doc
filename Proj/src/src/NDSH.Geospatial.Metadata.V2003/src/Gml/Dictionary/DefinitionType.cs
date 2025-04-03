
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 19:43, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Operations;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Gml.Temporal.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Gml.Units;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.Codelist;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.Datums;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Dictionary {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(AbstractCoordinateOperationType))]
  [XmlInclude(typeof(AbstractCoordinateSystemType))]
  [XmlInclude(typeof(AbstractCRSType))]
  [XmlInclude(typeof(AbstractDatumType))]
  [XmlInclude(typeof(AbstractGeneralConversionType))]
  [XmlInclude(typeof(AbstractGeneralDerivedCRSType))]
  [XmlInclude(typeof(AbstractGeneralOperationParameterType))]
  [XmlInclude(typeof(AbstractGeneralTransformationType))]
  [XmlInclude(typeof(AffineCSType))]
  [XmlInclude(typeof(BaseUnitType))]
  [XmlInclude(typeof(CartesianCSType))]
  [XmlInclude(typeof(ClAlternativeExpression_Type))]
  [XmlInclude(typeof(CodeAlternativeExpression_Type))]
  [XmlInclude(typeof(CodeDefinition_Type))]
  [XmlInclude(typeof(CodeListDictionary_Type))]
  [XmlInclude(typeof(CompoundCRSType))]
  [XmlInclude(typeof(ConcatenatedOperationType))]
  [XmlInclude(typeof(ConventionalUnitType))]
  [XmlInclude(typeof(ConversionType))]
  [XmlInclude(typeof(CoordinateSystemAlt_Type))]
  [XmlInclude(typeof(CoordinateSystemAxisAlt_Type))]
  [XmlInclude(typeof(CoordinateSystemAxisType))]
  [XmlInclude(typeof(CrsAlt_Type))]
  [XmlInclude(typeof(CylindricalCSType))]
  [XmlInclude(typeof(DatumAlt_Type))]
  [XmlInclude(typeof(DefinitionProxyType))]
  [XmlInclude(typeof(DerivedCRSType))]
  [XmlInclude(typeof(DerivedUnitType))]
  [XmlInclude(typeof(DictionaryType))]
  [XmlInclude(typeof(EllipsoidalCSType))]
  [XmlInclude(typeof(EllipsoidAlt_Type))]
  [XmlInclude(typeof(EllipsoidType))]
  [XmlInclude(typeof(EngineeringCRSType))]
  [XmlInclude(typeof(EngineeringDatumType))]
  [XmlInclude(typeof(GeocentricCRSType))]
  [XmlInclude(typeof(GeodeticCRSType))]
  [XmlInclude(typeof(GeodeticDatumType))]
  [XmlInclude(typeof(GeographicCRSType))]
  [XmlInclude(typeof(IdentifiedObjectType))]
  [XmlInclude(typeof(ImageCRSType))]
  [XmlInclude(typeof(ImageDatumType))]
  [XmlInclude(typeof(LinearCSType))]
  [XmlInclude(typeof(ML_AffineCS_Type))]
  [XmlInclude(typeof(ML_BaseUnit_Type))]
  [XmlInclude(typeof(ML_CartesianCS_Type))]
  [XmlInclude(typeof(ML_CodeDefinition_Type))]
  [XmlInclude(typeof(ML_CodeListDictionary_Type))]
  [XmlInclude(typeof(ML_CompoundCRS_Type))]
  [XmlInclude(typeof(ML_ConcatenatedOperation_Type))]
  [XmlInclude(typeof(ML_ConventionalUnit_Type))]
  [XmlInclude(typeof(ML_Conversion_Type))]
  [XmlInclude(typeof(ML_CoordinateSystemAxis_Type))]
  [XmlInclude(typeof(ML_CylindricalCS_Type))]
  [XmlInclude(typeof(ML_DerivedCRS_Type))]
  [XmlInclude(typeof(ML_DerivedUnit_Type))]
  [XmlInclude(typeof(ML_Ellipsoid_Type))]
  [XmlInclude(typeof(ML_EllipsoidalCS_Type))]
  [XmlInclude(typeof(ML_EngineeringCRS_Type))]
  [XmlInclude(typeof(ML_EngineeringDatum_Type))]
  [XmlInclude(typeof(ML_GeodeticCRS_Type))]
  [XmlInclude(typeof(ML_GeodeticDatum_Type))]
  [XmlInclude(typeof(ML_ImageCRS_Type))]
  [XmlInclude(typeof(ML_ImageDatum_Type))]
  [XmlInclude(typeof(ML_LinearCS_Type))]
  [XmlInclude(typeof(ML_OperationMethod_Type))]
  [XmlInclude(typeof(ML_OperationParameter_Type))]
  [XmlInclude(typeof(ML_OperationParameterGroup_Type))]
  [XmlInclude(typeof(ML_PassThroughOperation_Type))]
  [XmlInclude(typeof(ML_PolarCS_Type))]
  [XmlInclude(typeof(ML_PrimeMeridian_Type))]
  [XmlInclude(typeof(ML_ProjectedCRS_Type))]
  [XmlInclude(typeof(ML_SphericalCS_Type))]
  [XmlInclude(typeof(ML_TemporalCRS_Type))]
  [XmlInclude(typeof(ML_TemporalDatum_Type))]
  [XmlInclude(typeof(ML_TimeCS_Type))]
  [XmlInclude(typeof(ML_Transformation_Type))]
  [XmlInclude(typeof(ML_UnitDefinition_Type))]
  [XmlInclude(typeof(ML_UserDefinedCS_Type))]
  [XmlInclude(typeof(ML_VerticalCRS_Type))]
  [XmlInclude(typeof(ML_VerticalCS_Type))]
  [XmlInclude(typeof(ML_VerticalDatum_Type))]
  [XmlInclude(typeof(ObliqueCartesianCSType))]
  [XmlInclude(typeof(OperationAlt_Type))]
  [XmlInclude(typeof(OperationMethodAlt_Type))]
  [XmlInclude(typeof(OperationMethodType))]
  [XmlInclude(typeof(OperationParameterAlt_Type))]
  [XmlInclude(typeof(OperationParameterGroupType))]
  [XmlInclude(typeof(OperationParameterType))]
  [XmlInclude(typeof(PassThroughOperationType))]
  [XmlInclude(typeof(PolarCSType))]
  [XmlInclude(typeof(PrimeMeridianAlt_Type))]
  [XmlInclude(typeof(PrimeMeridianType))]
  [XmlInclude(typeof(ProjectedCRSType))]
  [XmlInclude(typeof(SphericalCSType))]
  [XmlInclude(typeof(TemporalCRSType))]
  [XmlInclude(typeof(TemporalCSType))]
  [XmlInclude(typeof(TemporalDatumBaseType))]
  [XmlInclude(typeof(TemporalDatumType))]
  [XmlInclude(typeof(TimeCalendarEraType))]
  [XmlInclude(typeof(TimeCalendarType))]
  [XmlInclude(typeof(TimeClockType))]
  [XmlInclude(typeof(TimeCoordinateSystemType))]
  [XmlInclude(typeof(TimeCSType))]
  [XmlInclude(typeof(TimeOrdinalEraType))]
  [XmlInclude(typeof(TimeOrdinalReferenceSystemType))]
  [XmlInclude(typeof(TimeReferenceSystemType))]
  [XmlInclude(typeof(TransformationType))]
  [XmlInclude(typeof(UnitDefinitionType))]
  [XmlInclude(typeof(UomAlternativeExpression_Type))]
  [XmlInclude(typeof(UserDefinedCSType))]
  [XmlInclude(typeof(VerticalCRSType))]
  [XmlInclude(typeof(VerticalCSType))]
  [XmlInclude(typeof(VerticalDatumType))]
  [Serializable]
  [XmlType("DefinitionType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DefinitionType")]
  public class DefinitionType : DefinitionBaseType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DefinitionType"/>.
    /// </summary>
    public DefinitionType() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gml", "http://www.opengis.net/gml");

    }

    #endregion

    #region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private string _remarks;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("remarks", Order = 0)]
    [JsonProperty("remarks", Order = 0)]
    public string Remarks {
      get {
        return _remarks;
      }
      set {
        if (_remarks == value) {
          return;
        }
        if (_remarks == null || _remarks.Equals(value) != true) {
          _remarks = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}


/*
 *  
 
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

 * 
 */
