
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/12/2022, 20:54, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Systems;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coverage;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Dictionary;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature.Dynamic;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Aggregates;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Complexes;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Grids;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Observation;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.Topology;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Units;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.ValueObjects;
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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Base
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
  [XmlInclude(typeof(ArrayType))]
  [XmlInclude(typeof(AbstractTopologyType))]
  [XmlInclude(typeof(TopoComplexType))]
  [XmlInclude(typeof(TopoVolumeType))]
  [XmlInclude(typeof(TopoSurfaceType))]
  [XmlInclude(typeof(TopoCurveType))]
  [XmlInclude(typeof(TopoPointType))]
  [XmlInclude(typeof(AbstractTopoPrimitiveType))]
  [XmlInclude(typeof(TopoSolidType))]
  [XmlInclude(typeof(NodeType))]
  [XmlInclude(typeof(EdgeType))]
  [XmlInclude(typeof(FaceType))]
  [XmlInclude(typeof(CompositeValueType))]
  [XmlInclude(typeof(ValueArrayType))]
  [XmlInclude(typeof(AbstractTimeSliceType))]
  [XmlInclude(typeof(MovingObjectStatusType))]
  [XmlInclude(typeof(AbstractFeatureType))]
  [XmlInclude(typeof(ObservationType))]
  [XmlInclude(typeof(DirectedObservationType))]
  [XmlInclude(typeof(DirectedObservationAtDistanceType))]
  [XmlInclude(typeof(AbstractCoverageType))]
  [XmlInclude(typeof(AbstractContinuousCoverageType))]
  [XmlInclude(typeof(AbstractDiscreteCoverageType))]
  [XmlInclude(typeof(RectifiedGridCoverageType))]
  [XmlInclude(typeof(GridCoverageType))]
  [XmlInclude(typeof(MultiSolidCoverageType))]
  [XmlInclude(typeof(MultiSurfaceCoverageType))]
  [XmlInclude(typeof(MultiCurveCoverageType))]
  [XmlInclude(typeof(MultiPointCoverageType))]
  [XmlInclude(typeof(DynamicFeatureType))]
  [XmlInclude(typeof(DynamicFeatureCollectionType))]
  [XmlInclude(typeof(AbstractFeatureCollectionType))]
  [XmlInclude(typeof(FeatureCollectionType))]
  [XmlInclude(typeof(BoundedFeatureType))]
  [XmlInclude(typeof(AbstractTimeObjectType))]
  [XmlInclude(typeof(AbstractTimeComplexType))]
  [XmlInclude(typeof(TimeTopologyComplexType))]
  [XmlInclude(typeof(AbstractTimePrimitiveType))]
  [XmlInclude(typeof(AbstractTimeTopologyPrimitiveType))]
  [XmlInclude(typeof(TimeEdgeType))]
  [XmlInclude(typeof(TimeNodeType))]
  [XmlInclude(typeof(AbstractTimeGeometricPrimitiveType))]
  [XmlInclude(typeof(TimePeriodType))]
  [XmlInclude(typeof(TimeInstantType))]
  [XmlInclude(typeof(AbstractGeometryType))]
  [XmlInclude(typeof(GridType))]
  [XmlInclude(typeof(RectifiedGridType))]
  [XmlInclude(typeof(GeometricComplexType))]
  [XmlInclude(typeof(AbstractGeometricAggregateType))]
  [XmlInclude(typeof(MultiSolidType))]
  [XmlInclude(typeof(MultiSurfaceType))]
  [XmlInclude(typeof(MultiCurveType))]
  [XmlInclude(typeof(MultiPointType))]
  [XmlInclude(typeof(MultiGeometryType))]
  [XmlInclude(typeof(AbstractGeometricPrimitiveType))]
  [XmlInclude(typeof(AbstractSolidType))]
  [XmlInclude(typeof(CompositeSolidType))]
  [XmlInclude(typeof(SolidType))]
  [XmlInclude(typeof(AbstractSurfaceType))]
  [XmlInclude(typeof(CompositeSurfaceType))]
  [XmlInclude(typeof(OrientableSurfaceType))]
  [XmlInclude(typeof(SurfaceType))]
  [XmlInclude(typeof(TriangulatedSurfaceType))]
  [XmlInclude(typeof(TinType))]
  [XmlInclude(typeof(PolyhedralSurfaceType))]
  [XmlInclude(typeof(PolygonType))]
  [XmlInclude(typeof(AbstractCurveType))]
  [XmlInclude(typeof(CompositeCurveType))]
  [XmlInclude(typeof(OrientableCurveType))]
  [XmlInclude(typeof(CurveType))]
  [XmlInclude(typeof(LineStringType))]
  [XmlInclude(typeof(PointType))]
  [XmlInclude(typeof(DefinitionBaseType))]
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
  [XmlInclude(typeof(BagType))]
  [Serializable]
  [XmlType("AbstractGMLType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGMLType")]
  public abstract class AbstractGMLType : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractGMLType"/>.
    /// </summary>
    public AbstractGMLType() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gml", "http://www.opengis.net/gml");

      _metaDataProperty  = default; //  new List<MetaDataPropertyType>();
      _description  = default; //  new StringOrRefType();
      _descriptionReference  = default; //  new ReferenceType();
      _identifier  = default; //  new CodeWithAuthorityType();
      _name  = default; //  new List<CodeType>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<MetaDataPropertyType> _metaDataProperty;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("metaDataProperty", Order = 0)]
    [JsonProperty("metaDataProperty", Order = 0)]
    public List<MetaDataPropertyType> MetaDataProperty {
      get {
        return _metaDataProperty;
      }
      set {
        if (_metaDataProperty == value) {
          return;
        }
        if (_metaDataProperty == null || _metaDataProperty.Equals(value) != true) {
          _metaDataProperty = value;
          OnPropertyChanged();
        }
      }
    }

    private StringOrRefType _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 1)]
    [JsonProperty("description", Order = 1)]
    public StringOrRefType Description {
      get {
        return _description;
      }
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || _description.Equals(value) != true) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private ReferenceType _descriptionReference;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("descriptionReference", Order = 2)]
    [JsonProperty("descriptionReference", Order = 2)]
    public ReferenceType DescriptionReference {
      get {
        return _descriptionReference;
      }
      set {
        if (_descriptionReference == value) {
          return;
        }
        if (_descriptionReference == null || _descriptionReference.Equals(value) != true) {
          _descriptionReference = value;
          OnPropertyChanged();
        }
      }
    }

    private CodeWithAuthorityType _identifier;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("identifier", Order = 3)]
    [JsonProperty("identifier", Order = 3)]
    public CodeWithAuthorityType Identifier {
      get {
        return _identifier;
      }
      set {
        if (_identifier == value) {
          return;
        }
        if (_identifier == null || _identifier.Equals(value) != true) {
          _identifier = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CodeType> _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 4)]
    [JsonProperty("name", Order = 4)]
    public List<CodeType> Name {
      get {
        return _name;
      }
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || _name.Equals(value) != true) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("id", DataType = "ID", Form = XmlSchemaForm.Qualified)]
    [JsonProperty("id")]
    [JsonRequired()] // TODO: Check out if the JsonRequired Attribute should be here.
    [Required] // TODO: Check out if the Required Attribute should be here.
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}