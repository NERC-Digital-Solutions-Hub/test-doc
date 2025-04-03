using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.Metadata.V2003 {

  /// <summary>
  /// 
  /// </summary>
  internal class Hierarchy {

    public string Lala = "The Hierarchy of Objects";

    /* XSD files
     * --applicationSchema      ->    ApplicationSchema
     * --citation               ->    Common.Citation
     * --constraints            ->    Constraint
     * --content                ->    Content
     * --dataQuality            ->    DataQuality
     * --distribution           ->    Distribution
     * --extent                 ->    Common.Extent
     * freeText
     * gmd
     * --identification         ->    Identification
     * --maintenance            ->    Maintenance
     * --metadataApplication    ->    Application
     * --metadataEntity         ->    EntitySet
     * --metadataExtension      ->    Extension
     * --portrayalCatalogue     ->    PortrayalCatalogue
     * --referenceSystem        ->    ReferenceSystem
     * --spatialRepresentation  ->    SpatialRepresentation
     */

    /* ISO 19115 UML model
     * 
     * Metadata application information
     *   --DS_Aggregate
     *   --DS_DataSet
     *   --DS_Initiative
     *   --DS_OtherAggregate
     *   --DS_Platform
     *   --DS_ProductionSeries
     *   --DS_Sensor
     *   --DS_Series
     *   --DS_StereoMate
     *   
     * Metadata  entity set information
     *   MD_Metadata
     *   
     * Identification information
     *   --DS_Association
     *   --DS_AssociationTypeCode
     *   --MD_AggregateInformation
     *   --MD_BrowseGraphic
     *   --MD_CharacterSetCode
     *   --MD_DataIdentification
     *   --MD_Identification
     *   --MD_Keywords
     *   --MD_KewywordTypeCode
     *   --MD_ProgressCode
     *   --MD_RepresentativeFraction
     *   --MD_Resolution
     *   --MD_SpatialRepresentationTypeCode
     *   --MD_Usage
     *   --MD_TopicCategoryCode
     *   
     * ConstraintInformation
     *   MD_ClassificationCode
     *   MD_Constraints
     *   MD_LegalConstraints
     *   MD_RestrictionCode
     *   MD_SecurityConstraints
     *   
     * Data quality information
     *   DQ_AbsoluteExternalPosition
     *   DQ_AccuracyOFATimeMeasurement
     *   DQ_Completeness
     *   DQ_CompletenessCommission
     *   DQ_CompletenessOmission
     *   DQ_ConformanceResult
     *   DQ_DataQuality
     *   DQ_DomainConsistency
     *   DQ_Element
     *   DQ_EvaluationMethodTypeCode
     *   DQ_FormatConsistency
     *   DQ_GriddedDataPositionalAccuracy
     *   DQ_LogicalConsistency
     *   DQ_NonQuantitativeAttributeAccuracy
     *   DQ_QuantitativeResult
     *   DQ_RelativeInternalPositionalAccuracy
     *   DQ_Result
     *   DQ_Scope
     *   DQ_TemporalAccuracy
     *   DQ_TempralConsistency
     *   DQ_TemporalValidity
     *   DQ_ThematicAccuracy
     *   DQ_ThematicClassificationCorrectness
     *   DQ_TopologicalConsistency
     *   LI_Lineage
     *   LI_ProcessStep
     *   LI_Source
     *   
     * Maintenance information
     *   MD_MaintenanceFrequencyCode
     *   MD_MaintenanceInformation
     *   MD_ScopeCode
     *   MD_ScopeDescription
     *   
     * Spatial representation information
     *   MD_CellGeometryCode
     *   MD_Dimension
     *   MD_DimensionNameTypeCode
     *   MD_GeometricObjects
     *   MD_GeometricObjectsTypeCode
     *   MD_Georectified
     *   MD_Georeferenceable
     *   MD_GridSpatialRepresentation
     *   MD_SpatialRepresentation
     *   MD_TopologyLevelCode
     *   MD_VectorSpatialRepresentation
     *   MD_PixelOrientationCode
     *   
     * Reference system information
     *   MD_Identifier
     *   MD_referenceSystem
     *   RS_Identifier
     *   
     * Content information
     *   MD_Band
     *   MD_ContentInformation
     *   MD_CoverageContentTypeCode
     *   MD_CoverageDescription
     *   MD_FeatureCatalogueDescription
     *   MD_ImageDescription
     *   MD_ImagingConditionCode
     *   MD_RangeDimension
     *   
     * Portrayal cataloguue information
     *   MD_PortrayalCatalogueReference
     *   
     * Distribution information
     *   MD_DigitalTransferOptions
     *   MD_Distribution
     *   MD_DistributionUnits
     *   MD_Distributor
     *   MD_Format
     *   MD_Medium
     *   MD_MediumFormatCode
     *   MD_MediumNameCode
     *   MD_StandardOrderProcess
     *   
     * Metadata extension information
     *   MD_DatatypeCode
     *   MD_extendedElementInformation
     *   MD_MetadataExtensionInformation
     *   MD_ObligationCode
     *   
     * Application schema information
     *   --MD_applicationSchemaInformation
     *   
     * Extent information
     *   EX_BoundingPolygon
     *   EX_Extent
     *   EX_GeographicBoundingBox
     *   EX_GeographicDescription
     *   EX_GeographicExtent
     *   EX_SpatialTemporalExtent
     *   EX_TemporalExtent
     *   EX_VerticalExtent
     *
     * Citation and responsible party
     *   CI_Address
     *   CI_Citation
     *   CI_Contact
     *   CI_Date
     *   CI_DateTypeCode
     *   CI_OnLineFunctionCode
     *   CI_PresentationFormCode
     *   CI_RepsonsilbeParty
     *   CI_RoleCode
     *   CI_Series
     *   CI_Telephone
     *   URL
     *   
     */

    /* ISO TS 19103 UML model
     * 
     * BasicTypes
     *   Derived
     *     Units of Measure
     *       --Angle                 [GML\Measures\AngleType]    [Common \Angle_PropertyType]
     *       AngularVelocity
     *       --Area                  [GML\Measures\AreaType]
     *       Currency
     *       --Distance                                          [Common \Distance_PropertyType]
     *       --Length                [GML\Measures\LengthType]   [Common \Length_PropertyType]
     *       --Measure               [GML\Measures\MeasureType]  [Common \Measure_PropertyType]
     *       MeasureType
     *       --Scale                 [GML\Measures\ScaleType]    [Common \Scale_PropertyType]
     *       StandardUnits
     *       SubUnitsPerUnit
     *       Time
     *       --UnitOfMeasure
     *       UnitsList
     *       --UomAngle
     *       UomAngularVelocity
     *       --UomArea
     *       UomCurrency
     *       --UomLength
     *       --UomScale
     *       --UomTime
     *       --UomVelocity
     *       --UomVolume
     *       UomWeight
     *       Velocity
     *       Volume                  [GML\Measures\VolumeType]
     *       Weight
     *       
     *   Implementation
     *     Collections
     *       Bag
     *       CircularSequence
     *       Code
     *       CodeList
     *       Collection
     *       Dictionary
     *       Dictionary<MemberName, TypeName>
     *       KeyType
     *       KeyValuePair
     *       Sequence
     *       Set
     *       T
     *       ValueType
     *       TransfiniteSet
     *       
     *     Names
     *       GenericName
     *       LocalName
     *       MemberName
     *       NameSpace
     *       NULL
     *       Reference
     *       ScopedName
     *       TypeName
     *       void
     *       
     *     Records and Class Metadata
     *       Any
     *       ClassTypeDescriptor
     *       OperationType
     *       Record
     *       RecordSchema
     *       RecordType
     *       Schema
     *       Type
     *       
     *   Primitive
     *     Date and Time
     *       ClockTime
     *       Date
     *       DatePrecision
     *       DateTime
     *       
     *     Enumerations
     *       Bit
     *       Digit
     *       Sign
     *       
     *     Multiplicities
     *       Multiplicity
     *       MultiplicityRange
     *       
     *     Numerics
     *       Decimal
     *       Integer
     *       Number
     *       Real
     *       UnlimitedInteger
     *       Vector
     *       
     *     Text
     *       Character
     *       CharacterSetCode
     *       CharacterString
     *       OCL
     *       Sequence<Character>
     *       
     *     Truth
     *       ContinuousTruth
     *       DiscreteTruth
     *       Probability
     *       Truth
     *       --Boolean
     *       Logical
     * 
     */


    /*
     *     ISO 19115 -  2005                        ISO 19136 - PropertyTypes                               ISO 19136 - Types
     * --------------------------------------------------------------------------------------------------------------------------------------------
     */
    /* Application Schema
     *     MD_ApplicationSchemaInformation          [MD_ApplicationSchemaInformation_PropertyType]          [MD_ApplicationSchemaInformation_Type]
     */
    /* Common
     *     Citation
               CI_Address                           [CI_Address_PropertyType]                               [CI_AddressType]
               CI_Citation                          [CI_Citation_PropertyType]                              [CI_Citation_Type]
               CI_Contact                           [CI_Contact_PropertyType]                               [CI_Contact_Type]
               CI_Date                              [CI_Date_PropertyType]                                  [CI_Date_Type]
               CI_DateTypeCode                      [CI_DateTypeCode_PropertyType]
               CI_DateTypeCodeValue
               CI_OnLineFunctionCode                [CI_OnLineFunctionCode_PropertyType]
               CI_OnLineFunctionCodeValue
               CI_OnlineResource                    [CI_OnlineResource_PropertyType]                        [CI_OnlineResource_Type]
               CI_PresentationFormCode              [CI_PresentationFormCode_PropertyType]
               CI_PresentationFormCodeValue
               CI_ResponsibleParty                  [CI_ResponsibleParty_PropertyType]                      [CI_ResponsibleParty_Type]
               CI_RoleCode                          [CI_RoleCode_PropertyType]
               CI_RoleCodeValue
               CI_Series                            [CI_Series_PropertyType]                                [CI_Series_Type]
               CI_Telephone                         [CI_Telephone_PropertyType]                             [CI_Telephone_Type]

           Extent
               EX_BoundingPolygon                   [EX_BoundingPolygon_PropertyType]                       [EX_BoundingPolygon_Type]
               EX_Extent                            [EX_Extent_PropertyType]                                [EX_Extent_Type]
               EX_ExtentTypeCode
               EX_ExtentTypeCodeValue
               EX_GeographicBoundingBox             [EX_GeographicBoundingBox_PropertyType]                 [EX_GeographicBoundingBox_Type]
               EX_GeographicDescription             [EX_GeographicDescription_PropertyType]                 [EX_GeographicDescription_Type]
               EX_GeographicExtent                  [EX_GeographicExtent_PropertyType]                      [AbstractEX_GeographicExtent_Type]
               EX_SpatialTemporalExtent             [EX_SpatialTemporalExtent_PropertyType]                 [EX_SpatialTemporalExtent_Type]
               EX_TemporalExtent                    [EX_TemporalExtent_PropertyType]                        [EX_TemporalExtent_Type]
               EX_VerticalExtent                    [EX_VerticalExtent_PropertyType]                        [EX_VerticalExtent_Type]
               Parent_EX_GeographicExtent
               Parent_EX_TemporalExtent
               SC_VerticalDatum

           SpatialSchema
               +GM_Object                           [GM_Object_PropertyType]
               +GM_Point                            [GM_Point_PropertyType]
               GM_Polygon
     *
     */
    /* ConceptualSchema
     *     Derived
     *         Measure
     *             Angle                                                                                    [AngleType] (GML Measures)
     *             AngularVelocity
     *             Area                                                                                     [AreaType] (GML Measures)
     *             Currency
     *             Distance                         [Distance_PropertyType]
     *                                                                                                      [GridLengthType] (GML Measures)
     *             Length                                                                                   [LengthType] (GML Measures)
     *             Measure                          [Measure_PropertyType]                                  [MeasureType] (GML Measures)
     *             MeasureType
     *             MeasureTypeValue
     *             Scale                                                                                    [ScaleType] (GML Measures)
     *                                                                                                      [SpeedType] (GML Measures)
     *             Time                                                                                     [TimeType] (GML Measures)
     *             Velocity
     *             Volume                                                                                   [VolumeType] (GML Measures)
     *             Weight
     *         UnitsOfMeasure
     *             StandardUnits
     *             StandardUnitsValue
     *             UnitOfMeasure
     *             UnitsList
     *             UnitsListValue
     *             UomAngle                         [UomAngle_PropertyType]
     *             UomArea                          [UomArea_PropertyType]
     *             UomCurrency
     *             UomLength                        [UomLength_PropertyType]
     *             UomScale                         [UomScale_PropertyType]
     *             UomTime                          [UomTime_PropertyType]
     *             UomVelocity                      [UomVelocity_PropertyType]
     *             UomVolume                        [UomVolume_PropertyType]
     *             UomWeight
     *     Implementation
     *         Collections
     *             Set
     *         Names
     *             GenericName
     *             LocalName
     *             MemberName                       [MemberName_PropertyType]                               [MemberName_Type]
     *             NameSpace
     *             ScopedName
     *             TypeName                         [TypeName_PropertyType]                                 [TypeName_Type]
     *         Records
     *             ArrayOfRecord
     *             AttributeName
     *             AttributeType
     *             Record
     *             RecordType
     *     Primitive
     *         Enumerations
     *             Bit
     *             BitValue
     *             Digit
     *             DigitValue
     *             Sign
     *             SignValue
     *         Numerics
     *                                              [Real_PropertyType]
     *             Value
     *             ValueChoiceType
     *         Text
     *             CharacterString                  [CharacterString_PropertyType]
     *         Time
     *             TM_PeriodDuration
     *         Truth
     *             Boolean                          [Boolean_PropertyType]                                  [Boolean]
     *             BooleanValue
     *             Logical
     *             LogicalValue
     *             Probability
     */
    /* Constraint
     *     MD_ClassificationCode                    [MD_ClassificationCode_PropertyType]
     *     MD_ClassificationCodeValue    
     *     MD_Constraints                           [MD_Constraints_PropertyType]                           [MD_Constraints_Type]
     *     MD_LegalConstraints                      [MD_LegalConstraints_PropertyType]                      [MD_LegalConstraints_Type]
     *     MD_RestrictionCode                       [MD_RestrictionCode_PropertyType]
     *     MD_RestrictionCodeValue
     *     MD_SecurityConstraints                   [MD_SecurityConstraints_PropertyType]                   [MD_SecurityConstraints_Type]
     *     Parent_MD_Constraints
     */
    /* Content
     *     ComplianceCode
     *     ComplianceCodeValue
     *     MD_Band                                  [MD_Band_PropertyType]                                  [MD_Band_Type]
     *     MD_ContentInformation                    [MD_ContentInformation_PropertyType]                    [AbstractMD_ContentInformation_Type]
     *     MD_CoverageContentTypeCode               [MD_CoverageContentTypeCode_PropertyType]
     *     MD_CoverageContentTypeCodeValue
     *     MD_CoverageDescription                   [MD_CoverageDescription_PropertyType]                   [MD_CoverageDescription_Type]
     *     MD_FeatureCatalogueDescription           [MD_FeatureCatalogueDescription_PropertyType]           [MD_FeatureCatalogueDescription_Type]
     *     MD_ImageDescription                      [MD_ImageDescription_PropertyType]                      [MD_ImageDescription_Type]
     *     MD_ImagingConditionCode                  [MD_ImagingConditionCode_PropertyType]
     *     MD_ImagingConditionCodeValue
     *     MD_RangeDimension                        [MD_RangeDimension_PropertyType]                        [MD_RangeDimension_Type]
     *     Parent_MD_RangeDimension
     */
    /* DataQuality
     *     DQ_AbsoluteExternalPositionalAccuracy    [DQ_AbsoluteExternalPositionalAccuracy_PropertyType]    [DQ_AbsoluteExternalPositionalAccuracy_Type]
     *     DQ_AccuracyOfATimeMeasurement            [DQ_AccuracyOfATimeMeasurement_PropertyType]            [DQ_AccuracyOfATimeMeasurement_Type]
     *     DQ_Completeness                          [DQ_Completeness_PropertyType]                          [AbstractDQ_Completeness_Type]
     *     DQ_CompletenessCommission                [DQ_CompletenessCommission_PropertyType]                [DQ_CompletenessCommission_Type]
     *     DQ_CompletenessOmission                  [DQ_CompletenessOmission_PropertyType]                  [DQ_CompletenessOmission_Type]
     *     DQ_ConceptualConsistency                 [DQ_ConceptualConsistency_PropertyType]                 [DQ_ConceptualConsistency_Type]
     *     DQ_ConformanceResult                     [DQ_ConformanceResult_PropertyType]                     [DQ_ConformanceResult_Type]
     *     DQ_DataQuality                           [DQ_DataQuality_PropertyType]                           [DQ_DataQuality_Type]
     *     DQ_DomainConsistency                     [DQ_DomainConsistency_PropertyType]                     [DQ_DomainConsistency_Type]
     *     DQ_Element                               [DQ_Element_PropertyType]                               [AbstractDQ_Element_Type]
     *     DQ_EvaluationMethodTypeCode              [DQ_EvaluationMethodTypeCode_PropertyType]
     *     DQ_EvaluationMethodTypeCodeValue
     *     DQ_FormatConsistency                     [DQ_FormatConsistency_PropertyType]                     [DQ_FormatConsistency_Type]
     *     DQ_GriddedDataPositionalAccuracy         [DQ_GriddedDataPositionalAccuracy_PropertyType]         [DQ_GriddedDataPositionalAccuracy_Type]
     *     DQ_LogicalConsistency                    [DQ_LogicalConsistency_PropertyType]                    [AbstractDQ_LogicalConsistency_Type]
     *     DQ_NonQuantitativeAttributeAccuracy      [DQ_NonQuantitativeAttributeAccuracy_PropertyType]      [DQ_NonQuantitativeAttributeAccuracy_Type]
     *     DQ_PositionalAccuracy                    [DQ_PositionalAccuracy_PropertyType]                    [AbstractDQ_PositionalAccuracy_Type]
     *     DQ_QuantitativeAttributeAccuracy         [DQ_QuantitativeAttributeAccuracy_PropertyType]         [DQ_QuantitativeAttributeAccuracy_Type]
     *     DQ_QuantitativeResult                    [DQ_QuantitativeResult_PropertyType]                    [DQ_QuantitativeResult_Type]
     *     DQ_RelativeInternalPositionalAccuracy    [DQ_RelativeInternalPositionalAccuracy_PropertyType]    [DQ_RelativeInternalPositionalAccuracy_Type]
     *     DQ_Result                                [DQ_Result_PropertyType]                                [AbstractDQ_Result_Type]
     *     DQ_Scope                                 [DQ_Scope_PropertyType]                                 [DQ_Scope_Type]
     *     DQ_TemporalAccuracy                      [DQ_TemporalAccuracy_PropertyType]                      [AbstractDQ_TemporalAccuracy_Type]
     *     DQ_TemporalConsistency                   [DQ_TemporalConsistency_PropertyType]                   [DQ_TemporalConsistency_Type]
     *     DQ_TemporalValidity                      [DQ_TemporalValidity_PropertyType]                      [DQ_TemporalValidity_Type]
     *     DQ_ThematicAccuracy                      [DQ_ThematicAccuracy_PropertyType]                      [AbstractDQ_ThematicAccuracy_Type]
     *     DQ_ThematicClassificationCorrectness     [DQ_ThematicClassificationCorrectness_PropertyType]     [DQ_ThematicClassificationCorrectness_Type]
     *     DQ_TopologicalConsistency                [DQ_TopologicalConsistency_PropertyType]                [DQ_TopologicalConsistency_Type]
     *     LI_Lineage                               [LI_Lineage_PropertyType]                               [LI_Lineage_Type]
     *     LI_ProcessStep                           [LI_ProcessStep_PropertyType]                           [LI_ProcessStep_Type]
     *     LI_Source                                [LI_Source_PropertyType]                                [LI_Source_Type]
     *     Parent_DQ_Element
     *     
     */
    /* Distribution
     *     MD_DigitalTransferOptions                [MD_DigitalTransferOptions_PropertyType]                [MD_DigitalTransferOptions_Type]
     *     MD_Distribution                          [MD_Distribution_PropertyType]                          [MD_Distribution_Type]
     *                                              [MD_DistributionUnits_PropertyType]
     *     MD_Distributor                           [MD_Distributor_PropertyType]                           [MD_Distributor_Type]
     *     MD_Format                                [MD_Format_PropertyType]                                [MD_Format_Type]
     *     MD_Medium                                [MD_Medium_PropertyType]                                [MD_Medium_Type]
     *     MD_MediumFormatCode                      [MD_MediumFormatCode_PropertyType]
     *     MD_MediumFormatCodeValue
     *     MD_MediumNameCode                        [MD_MediumNameCode_PropertyType]
     *     MD_MediumNameCodeValue
     *     MD_StandardOrderProcess                  [MD_StandardOrderProcess_PropertyType]                  [MD_StandardOrderProcess_Type]
     */
    /* EntitySet
     *     EntityBase{T}
     *     MD_Metadata                              [MD_Metadata_PropertyType]                              [MD_Metadata_Type]
     *     MD_MetadataSet
     */
    /* Extension
     *     MD_DataTypeCode                          [MD_DatatypeCode_PropertyType]
     *     MD_DatatypeCodeValue
     *     MD_ExtendedElementInformation            [MD_ExtendedElementInformation_PropertyType]            [MD_ExtendedElementInformation_Type]
     *     MD_MetadataExtensionInformation          [MD_MetadataExtensionInformation_PropertyType]          [MD_MetadataExtensionInformation_Type]
     *     MD_ObligationCode                        [MD_ObligationCode_PropertyType]                        [MD_ObligationCode_Type]
     *     MD_ObligationCodeValue
     */
    /* Identification
     *                                              [DS_Association_PropertyType]                           [DS_Association_Type]
     *     DS_AssociationTypeCode                   [DS_AssociationTypeCode_PropertyType]
     *     DS_AssociationTypeCodeValue
     *     DS_InitiativeTypeCode                    [DS_InitiativeTypeCode_PropertyType]
     *     DS_InitiativeTypeCodeValue
     *     MD_AggregateInformation                  [MD_AggregateInformation_PropertyType]                  [MD_AggregateInformation_Type]
     *     MD_BrowseGraphic                         [MD_BrowseGraphic_PropertyType]                         [MD_BrowseGraphic_Type]
     *     MD_CharacterSetCode                      [MD_CharacterSetCode_PropertyType]
     *     MD_CharacterSetCodeValue
     *     MD_DataIdentification                    [MD_DataIdentification_PropertyType]                    [MD_DataIdentification_Type]
     *     MD_Identification                        [MD_Identification_PropertyType]                        [AbstractMD_Identification_Type]
     *     MD_Keywords                              [MD_Keywords_PropertyType]                              [MD_Keywords_Type]
     *     MD_KeywordTypeCode                       [MD_KeywordTypeCode_PropertyType]
     *     MD_KeywordTypeCodeValue
     *     MD_ProgressCode                          [MD_ProgressCode_PropertyType]
     *     MD_ProgressCodeValue
     *     MD_RepresetantiveFraction                [MD_RepresentativeFraction_PropertyType]                [MD_RepresentativeFraction_Type]
     *     MD_Resolution                            [MD_Resolution_PropertyType]                            [MD_Resolution_Type]
     *     MD_SpatialRepresentationTypeCode         [MD_SpatialRepresentationTypeCode_PropertyType]
     *     MD_SpatialRepresentationTypeCodeValue
     *     MD_TopicCategoryCode                     [MD_TopicCategoryCode_PropertyType]                     [MD_TopicCategoryCode_Type]
     *     MD_TopicCategoryCodeValue
     *     MD_Usage                                 [MD_Usage_PropertyType]                                 [MD_Usage_Type]
     *     Parent_MD_Identification
     */
    /* Maintenance
     *     MD_MaintenanceFrequencyCode              [MD_MaintenanceFrequencyCode_PropertyType]
     *     MD_MaintenanceFrequencyCodeValue
     *     MD_MaintenanceInformation                [MD_MaintenanceInformation_PropertyType]                [MD_MaintenanceInformation_Type]
     *     MD_ScopeCode                             [MD_ScopeCode_PropertyType]
     *     MD_ScopeCodeValue
     *     MD_ScopeDescription                      [MD_ScopeDescription_PropertyType]                      [MD_ScopeDescription_Type]
     */
    /* Other
     *     Feature
     *         Cataloguing
     *             FC_RoleType
     *             FC_RoleTypeValue
     *         Model
     *             GF_AssociationRole
     *             GF_AssociationType
     *             GF_AttributeType
     *             GF_Constraint
     *             GF_FeatureType
     *             GF_PropertyType
     *             
     *         AttributeName
     *         attributes
     *         attributeType
     *         FC_AssociationRole
     *         FC_Binding
     *         FC_BoundFeatureAttribute
     *         FC_Constraint
     *         FC_DefinitionReference
     *         FC_DefinitionSource
     *         FC_FeatureAssociation
     *         FC_FeatureAttribute
     *         FC_FeatureCatalogue
     *         FC_FeatureOperation
     *         FC_FeatureType
     *         FC_InheritanceRelation
     *         FC_ListedValue
     *         FC_PropertyType
     *         FC_RoleType
     *         FC_RoleTypeValue
     *         featureCatalogueInfo
     *         featureTypes
     *         Multiplicity
     *         MultiplicityRange
     */
    /* PortrayalCatalogue
     *     MD_PortrayalCatalogueReference           [MD_PortrayalCatalogueReference_PropertyType]           [MD_PortrayalCatalogueReference_Type]
     */
    /* ReferenceSystem
     *     ---- Move this line to another namesapce     MD_CRS                                   [SC_CRS_PropertyType]                                   [AbstractCRSType] ----
     *     MD_EllipsoidParameters
     *     MD_Identifier                            [MD_Identifier_PropertyType]                            [MD_Identifier_Type]
     *     MD_ObliqueLineAzimuth
     *     MD_ObliqueLinePoint
     *     MD_ProjectionParameters
     *     MD_ReferenceSystem                       [MD_ReferenceSystem_PropertyType]                       [MD_ReferenceSystem_Type]
     *     Parent_MD_Identifier
     *     Parent_MD_ReferenceSystem
     *     RS_Identifier                            [RS_Identifier_PropertyType]                            [RS_Identifier_Type]
     *     RS_ReferenceSystem                       [RS_ReferenceSystem_PropertyType]                       [AbstractRS_ReferenceSystem_Type]
     */
    /* Service
     *     Model
     *         aSV_Client
     *         aSV_IntelligentUser
     *         aSV_Interface
     *         aSV_InterfaceSpecification
     *         aSV_MsgOperation
     *         aSV_ObjOperation
     *         aSV_Operation
     *         aSV_ParameterSpecification
     *         aSV_PlatformNeutralServiceSpecification
     *         aSV_PlatformSpecificServiceSpecification
     *         aSV_Service
     *         aSV_ServiceSpecification
     *         aSV_ServiceType
     *         SV_Message
     *         SV_MessageUse
     *         SV_MessageUseValue
     *         SV_OperationModel
     *         SV_OperationModelValue
     *         SV_OperationSpecification
     *         SV_Port
     *         SV_PortSpecification
     *     
     *     DCPList
     *     DCPListValue
     *     DistinguishedName
     *     SV_CoupledResource
     *     SV_CouplingType
     *     SV_CouplingTypeValue
     *     SV_OperationChain
     *     SV_OperationChainMetadata
     *     SV_OperationMetadata
     *     SV_Parameter
     *     SV_ParameterDirection
     *     SV_ParameterDirectionValue
     *     SV_ServiceIdentification                 [MD_ServiceIdentification_PropertyType]                 [MD_ServiceIdentification_Type]
     *     SV_ServiceProvider
     */
    /* SpatialRepresentation
     *     MD_CellGeometryCode                      [MD_CellGeometryCode_PropertyType]
     *     MD_CellGeometryCodeValue
     *     MD_Dimension                             [MD_Dimension_PropertyType]                             [MD_Dimension_Type]
     *     MD_DimensionNameTypeCode                 [MD_DimensionNameTypeCode_PropertyType]
     *     MD_DimensionNameTypeCodeValue
     *     MD_GeometricObjects                      [MD_GeometricObjects_PropertyType]                      [MD_GeometricObjects_Type]
     *     MD_GeometricObjectTypeCode               [MD_GeometricObjectTypeCode_PropertyType]
     *     MD_GeometricObjectTypeCodeValue
     *     MD_Georectified                          [MD_Georectified_PropertyType]                          [MD_Georectified_Type]
     *     MD_Georeferenceable                      [MD_Georeferenceable_PropertyType]                      [MD_Georeferenceable_Type]
     *     MD_GridSpatialRepresentation             [MD_GridSpatialRepresentation_PropertyType]             [MD_GridSpatialRepresentation_Type]
     *     MD_PixelOrientationCode                  [MD_PixelOrientationCode_PropertyType]                  ??
     *     MD_PixelOrientationCodeValue                                                                     [MD_PixelOrientationCode_Type]
     *     MD_SpatialRepresentation                 [MD_SpatialRepresentation_PropertyType]                 [AbstractMD_SpatialRepresentation_Type]
     *     MD_TopologyLevelCode                     [MD_TopologyLevelCode_PropertyType]
     *     MD_TopologyLevelCodeValue
     *     MD_VectorSpatialRepresentation           [MD_VectorSpatialRepresentation_PropertyType]           [MD_VectorSpatialRepresentation_Type]
     */

    /*
     * LaguageCode
     * LanguageCodeValue
     * 
     * Model??
     * 
     */

  }

}
