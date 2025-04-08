
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 27/12/2022, @gisvlasta
// History           : 10/03/2025, @gisvlasta - Changed inheritance, implemented specific interfaced, improved code,
//                      and added extensive documentation.
//                   : 14/03/2025, @gisvlasta - Corrected the IStandardObjectProperties interface implementation,
//                      added an overloaded constructor, updated JsonProperty attributes, added IsoTypeAttribute,
//                      and added Id property validation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : AbstractCRSType ->
//                       IdentifiedObjectType ->
//                         DefinitionType ->
//                           DefinitionBaseType ->
//                             AbstractGMLType ->  [substitutes: AbstractObject]
//                               AbstractObject ->
//                                 ObservableDbEntity ->
//                                   ObservableModel ->
//                                     Model
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attribute name="id" type="ID">
//   <annotation>
//     <documentation>
//       The attribute gml:id supports provision of a handle for the XML element representing a GML Object.
//       Its use is mandatory for all GML objects. It is of XML type ID, so is constrained to be unique
//       in the XML document within which it occurs.
//     </documentation>
//   </annotation>
// </attribute>
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
// <complexType name="AbstractGMLType" abstract="true">
//   <sequence>
//     <group ref="gml:StandardObjectProperties"/>
//   </sequence>
//   <attribute ref="gml:id" use="required"/>
// </complexType>
// 
// <element name="AbstractGML" type="gml:AbstractGMLType" abstract="true" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>
//       The abstract element gml:AbstractGML is “any GML object having identity”.
//       It acts as the head of an XML Schema substitution group, which may include any element which is a GML feature,
//       or other object, with identity. This is used as a variable in content models in GML core and
//       application schemas. It is effectively an abstract superclass for all GML objects.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from AbstractGMLType to Gml.

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
  //[XmlInclude(typeof(ArrayType))]
  //[XmlInclude(typeof(AbstractTopologyType))]
  //[XmlInclude(typeof(TopoComplexType))]
  //[XmlInclude(typeof(TopoVolumeType))]
  //[XmlInclude(typeof(TopoSurfaceType))]
  //[XmlInclude(typeof(TopoCurveType))]
  //[XmlInclude(typeof(TopoPointType))]
  //[XmlInclude(typeof(AbstractTopoPrimitiveType))]
  //[XmlInclude(typeof(TopoSolidType))]
  //[XmlInclude(typeof(NodeType))]
  //[XmlInclude(typeof(EdgeType))]
  //[XmlInclude(typeof(FaceType))]
  //[XmlInclude(typeof(CompositeValueType))]
  //[XmlInclude(typeof(ValueArrayType))]
  //[XmlInclude(typeof(AbstractTimeSliceType))]
  //[XmlInclude(typeof(MovingObjectStatusType))]
  //[XmlInclude(typeof(AbstractFeatureType))]
  //[XmlInclude(typeof(ObservationType))]
  //[XmlInclude(typeof(DirectedObservationType))]
  //[XmlInclude(typeof(DirectedObservationAtDistanceType))]
  //[XmlInclude(typeof(AbstractCoverageType))]
  //[XmlInclude(typeof(AbstractContinuousCoverageType))]
  //[XmlInclude(typeof(AbstractDiscreteCoverageType))]
  //[XmlInclude(typeof(RectifiedGridCoverageType))]
  //[XmlInclude(typeof(GridCoverageType))]
  //[XmlInclude(typeof(MultiSolidCoverageType))]
  //[XmlInclude(typeof(MultiSurfaceCoverageType))]
  //[XmlInclude(typeof(MultiCurveCoverageType))]
  //[XmlInclude(typeof(MultiPointCoverageType))]
  //[XmlInclude(typeof(DynamicFeatureType))]
  //[XmlInclude(typeof(DynamicFeatureCollectionType))]
  //[XmlInclude(typeof(AbstractFeatureCollectionType))]
  //[XmlInclude(typeof(FeatureCollectionType))]
  //[XmlInclude(typeof(BoundedFeatureType))]
  //[XmlInclude(typeof(AbstractTimeObjectType))]
  //[XmlInclude(typeof(AbstractTimeComplexType))]
  //[XmlInclude(typeof(TimeTopologyComplexType))]
  //[XmlInclude(typeof(AbstractTimePrimitiveType))]
  //[XmlInclude(typeof(AbstractTimeTopologyPrimitiveType))]
  //[XmlInclude(typeof(TimeEdgeType))]
  //[XmlInclude(typeof(TimeNodeType))]
  //[XmlInclude(typeof(AbstractTimeGeometricPrimitiveType))]
  //[XmlInclude(typeof(TimePeriodType))]
  //[XmlInclude(typeof(TimeInstantType))]
  //[XmlInclude(typeof(AbstractGeometryType))]
  //[XmlInclude(typeof(GridType))]
  //[XmlInclude(typeof(RectifiedGridType))]
  //[XmlInclude(typeof(GeometricComplexType))]
  //[XmlInclude(typeof(AbstractGeometricAggregateType))]
  //[XmlInclude(typeof(MultiSolidType))]
  //[XmlInclude(typeof(MultiSurfaceType))]
  //[XmlInclude(typeof(MultiCurveType))]
  //[XmlInclude(typeof(MultiPointType))]
  //[XmlInclude(typeof(MultiGeometryType))]
  //[XmlInclude(typeof(AbstractGeometricPrimitiveType))]
  //[XmlInclude(typeof(AbstractSolidType))]
  //[XmlInclude(typeof(CompositeSolidType))]
  //[XmlInclude(typeof(SolidType))]
  //[XmlInclude(typeof(AbstractSurfaceType))]
  //[XmlInclude(typeof(CompositeSurfaceType))]
  //[XmlInclude(typeof(OrientableSurfaceType))]
  //[XmlInclude(typeof(SurfaceType))]
  //[XmlInclude(typeof(TriangulatedSurfaceType))]
  //[XmlInclude(typeof(TinType))]
  //[XmlInclude(typeof(PolyhedralSurfaceType))]
  //[XmlInclude(typeof(PolygonType))]
  //[XmlInclude(typeof(AbstractCurveType))]
  //[XmlInclude(typeof(CompositeCurveType))]
  //[XmlInclude(typeof(OrientableCurveType))]
  //[XmlInclude(typeof(CurveType))]
  //[XmlInclude(typeof(LineStringType))]
  //[XmlInclude(typeof(PointType))]
  //[XmlInclude(typeof(DefinitionBaseType))]
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
  //[XmlInclude(typeof(BagType))]
  #endregion

  /// <summary>
  /// The <see cref="AbstractGMLType"/> is any GML object having identity.
  /// It includes objects that are GML features, or other objects, with identity.
  /// It is effectively an abstract superclass for all GML objects.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractGMLType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [IsoType("AbstractGMLType", IsAbstract = true)]
  //[XmlType("AbstractGMLType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGMLType")]
  public abstract class AbstractGMLType : GmlObject, IStandardObjectProperties, IId {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractGMLType"/>.
    /// </summary>
    public AbstractGMLType() {

    }

    /// <summary>
    /// Initializes the <see cref="AbstractGMLType"/>.
    /// </summary>
    /// <param name="id">The unique ID of the <see cref="AbstractGMLType"/> object.</param>
    public AbstractGMLType(string id) {
      Id = id;
    }

    #endregion

    #region IStandardObjectProperties Interface

    private ObservableCollection<MetaDataPropertyType>? _metaDataProperty;

    /// <summary>
    /// Gets/Sets the <see cref="ObservableCollection{MetaDataPropertyType}">collection of metadata properties</see>
    /// associated with the object.
    /// </summary>
    /// <remarks>
    /// The <see cref="MetaDataProperty"/> is used to link metadata to a GML object. 
    /// It follows the <see cref="MetaDataPropertyType"/> content model, which allows for 
    /// association with metadata described by any XML Schema. This property does not 
    /// inherently imply ownership of the metadata, but ownership can be asserted using 
    /// the <see cref="IOwnership"/>.
    /// </remarks>
    //[XmlElement("metaDataProperty", Order = 0)]
    [JsonProperty("metaDataProperty", Order = 1, NullValueHandling = NullValueHandling.Ignore)]
    public ObservableCollection<MetaDataPropertyType>? MetaDataProperty {
      get => _metaDataProperty;
      set => SetProperty(ref _metaDataProperty, value);
    }

    private StringOrRefType? _description;

    /// <summary>
    /// Gets/Sets the text description of the object.
    /// </summary>
    /// <remarks>
    /// <see cref="Description"/> uses <see cref="StringOrRefType"/> as its content model,
    /// so it may contain a simple text string content, or carry a reference to an external description.
    /// The use of <see cref="Description"/> to reference an external description has been deprecated and
    /// replaced by the <see cref="DescriptionReference"/> property.
    /// </remarks>
    //[XmlElement("description", Order = 1)]
    [JsonProperty("description", Order = 2, NullValueHandling = NullValueHandling.Ignore)]
    [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")] // RESOURCE
    public StringOrRefType? Description {
      get => _description;
      set => SetProperty(ref _description, value);
    }

    private ReferenceType? _descriptionReference;

    /// <summary>
    /// Gets/Sets the remote text description of the object.
    /// </summary>
    /// <remarks>
    /// The <c>xlink:href</c> attribute of the <c>gml:descriptionReference</c>
    /// property references the external description.
    /// </remarks>
    //[XmlElement("descriptionReference", Order = 2)]
    [JsonProperty("descriptionReference", Order = 3, NullValueHandling = NullValueHandling.Ignore)]
    public ReferenceType? DescriptionReference {
      get => _descriptionReference;
      set => SetProperty(ref _descriptionReference, value);
    }

    private CodeWithAuthorityType? _identifier;

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
    //[XmlElement("identifier", Order = 3)]
    [JsonProperty("identifier", Order = 4, NullValueHandling = NullValueHandling.Ignore)]
    public CodeWithAuthorityType? Identifier {
      get => _identifier;
      set => SetProperty(ref _identifier, value);
    }

    private ObservableCollection<CodeType>? _name;

    /// <summary>
    /// Gets/Sets the special identifier that is often assigned to an object by the maintaining authority 
    /// with the intention that it is used in references to the object. For such cases, the codeSpace
    /// shall be provided. That identifier is usually unique either globally or within an application domain.
    /// <c>gml:identifier</c> is a pre-defined property for such identifiers.
    /// </summary>
    //[XmlElement("name", Order = 4)]
    [JsonProperty("name", Order = 5, NullValueHandling = NullValueHandling.Ignore)]
    public ObservableCollection<CodeType>? Name {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    #endregion

    #region IId Interface

    private string _id;

    /// <summary>
    /// Gets/Sets the unique identifier for the GML object.
    /// </summary>
    /// <remarks>
    /// The <see cref="Id"/> attribute provides a handle for the XML element representing a GML object.
    /// It is of XML type <c>ID</c>, meaning it must be unique within the XML document where it occurs.
    /// <br></br>
    /// The use of this attribute is <b>mandatory</b> for all GML objects,
    /// ensuring uniqueness and facilitating reference-based associations.
    /// </remarks>
    /// <value>
    /// A unique <see cref="string"/> identifier constrained to be <b>document-wide unique</b> in XML.
    /// </value>
    /// <exception cref="ArgumentNullException">
    /// Thrown when attempting to set the <see cref="Id"/> property to <c>null</c>.
    /// </exception>
    //[XmlAttribute("id", DataType = "ID", Form = XmlSchemaForm.Qualified)]
    [JsonProperty("id", Order = 0)]
    [JsonRequired()] // TODO: Check out if the JsonRequired Attribute should be here.
    // RESOURCE
    [Required(AllowEmptyStrings = false, ErrorMessage = "The Id is required and cannot be empty.")] // TODO: Check out if the Required Attribute should be here.
    public required string Id {
      get => _id;
      set {
        // Ensure it follows XML ID rules.
        if (!XmlValidator.IsValidXmlId(value)) {
          throw new ArgumentException(
            $"Invalid XML ID: {value}. Must start with a letter and contain only valid characters.", nameof(value)
          ); // RESOURCE
        }
        SetProperty(ref _id, value);
      }
    }

    #endregion

  }

}
