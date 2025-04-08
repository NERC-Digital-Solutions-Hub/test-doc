using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.Metadata.V2003 {

  /// <summary>
  /// 
  /// </summary>
  public class TODO {

    public string Aim = "The aim is to make it work";

    /* Regular Expressions
     * --------------------------------------------------------------------------------
     * Match: OnPropertyChanged\(\"[a-zA-Z0-9]+\"\);
     * Match Line breaks: [\r\n|\r|\n]
     * Match: OnPropertyChanged\(\"[a-zA-Z0-9]+\"\);
     * Match Line breaks: [\r\n|\r|\n]
     */

    /* TODO
     * --------------------------------------------------------------------------------
     * TODO: Clean up the code in this file.
     * TODO: {Assembly Wide} JSON Enum Serialization [https://stackoverflow.com/questions/2441290/javascriptserializer-json-serialization-of-enum-as-string]
     * TODO: {Assembly Wide} Modernize PropertyChanged
     * TODO: {Assembly Wide} Check for missing id and uuid properties.
     * TODO: {Assembly Wide} id Property Documentation
     * TODO: {Assembly Wide} uuid Property Documentation
     * TODO: {Assembly Wide} Provide namespaces [XmlNamespaceDeclarations()]public XmlSerializerNamespaces xmlns;
     * TODO: {Assembly Wide} NO Constructor
     * TODO: {Assembly Wide} CS0472 Warning: The result of the expression is always 'false' since a value of type bool is never equal to 'null' of type 'bool?'
     * TODO: {Assembly Wide} Provide Title in Headers.
     * TODO: {Assembly Wide} Remove [DebuggerStepThrough] Attribute
     * TODO: {Assembly Wide} Several Properties are not part of the GMD namespace but are imported / included form other namespaces. Should an explicit namespace added in the XmlElement Attribute attached to these properties? (Example: 
     * TODO: {Assembly Wide} Boolean variable (perhaps needs to become bool)
     * TODO: {Assembly Wide} Boolean Checks seem to be problematic (null values)
     * TODO: {Assembly Wide} DateTime - What do we do with initialization and Checks?
     * TODO: {Assembly Wide} Do all properties in the specification PDF are present in the XSD? It seems that MD_ScopeDescription is incorrect.
     * TODO: {Assembly Wide} Check if OnPropertyChanged("  has a hardcoded attribute name.
     * TODO: {Assembly Wide} Check if missing XmlRoot.
     * TODO: {Assembly Wide} Check constructors and initialization of variables.
     * TODO: {Assembly Wide} Check if the use of [XmlElement("", Order = N)], [XmlElement(Order = N, ElementName = "")] or  is consistent.
     * TODO: {Assembly Wide} Check if [JsonProperty( is consistent, Do we use Order as well???
     * TODO: {Assembly Wide} Check the summary of all constructors.
     * TODO: {Assembly Wide} Check if constructors exist for all types, property types.
     * TODO: {Assembly Wide} Check the location of [Serializable] attribute.
     * TODO: {Assembly Wide} Check all XmlElement, XmlAttribute, XmlText etc.
     * TODO: {Assembly Wide} Check if XmlType, XmlRoot and JsonObject have the same Name inside the attributes definition.
     * TODO: {Assembly Wide} ObjectReference_PropertyType is used to define the necessary properties of PropertyType objects (UuidRef, NilReason). However some PropertyType objects (for example, CharacterString_PropertyType) has only NilReason. This is implemented only using the interface rather than an abstract class. Should we have two different abstract classes there? (ObjectReference_PropertyType, and a new one with only NilReason) ???
     * TODO: {Assembly Wide} Check all [XmlInclude]
     * TODO: {Assembly Wide} Compare [XmlType], [XmlRoot], [JsonObject]
     * TODO: {Assembly Wide} Make sure that Boolean is actually the Truth.Boolean Type. Compare with the initially generated code.
     * TODO: {Assembly Wide} If Boolean is Truth.Boolean then use the following using: using Boolean = NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Truth.Boolean;
     * TODO: {Assembly Wide} Check if all assembly namespaces are mapped correctly to those of XSD. for example Real_PropertyType is in ConceptualSchema.Primitive.Numerics but it has an http://www.isotc211.org/2005/gco XSD namespace. Does that make sense?
     * TODO: {Assembly Wide} Check every class regarding its inheritance!!!
     * TODO: {Assembly Wide} Make sure this is correct everywhere: xmlns.Add("xxx", "http://www.opengis.net/xxx");
     * TODO: {Assembly Wide} Check the inheritance of object. xmlns = new XmlSerializerNamespaces(); xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx"); and similar should not be added deep down the inheritance hieracrchy.
     * TODO: {Assembly Wide} Make sure all [XmlIncludes are placed correctly in the abstract classes. Also compare gmd with gmx.
     * TODO: {Assembly Wide} Perhaps all enumerations can have an anonymous XmlType??? - (for example: [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/1999/xlink")] // TODO: Should this have a TypeName???)
     * TODO: {Assembly Wide} Make sure all Abstract classes have the correct includes!
     * TODO: {Assembly Wide} Compare all the gmd and gmx classes
     * TODO: {Assembly Wide} Find all 'deprecated' annotations in XSD files and mark the associated Class, Property, Method implementations as obsolete using the [ObsoleteAttribute].
     * TODO: {Assembly Wide} Check if all [JsonProperty attributes have been added properly!
     * TODO: {Assembly Wide} Check all classes in Features.Model. Make sure setters are correct, add OnPropertyChanged(), check inheritence. All Xml / Json decoration Attributes
     * TODO: {Assembly Wide} Check that all [XmlInclude](s) have been addded correctly to all of the members in an inheritance hierarchy.
     * TODO: {Assembly Wide} Provide a message in all [Obsolete] attributes.
     * 
     * TODO: {NOW} - Change implementation of RecordType_TypeActuate /  RecordType_TypeShow / RecoredType_PropertyType / RecordType_Type - Find out what is the Record_PropertyType
     * TODO: {NOW} - Make all the following classes consistent. ObjectReference_PropertyTpe, RecordType_Type, AssociationRoleType, MetaDataPropertyType, IActuate, AnchorType
     * TODO: {GML} - Check all GML classes and their corresponding XSD definitions.
     * TODO: {Assembly Wide} Make sure that all [XmlInclude s have been included in the files.
     * 
     * TODO: {Service Folder} Is the namespace GMD???
     * TODO: {Service Folder} Initialization - Make sure it is correct by reading the documentation regarding cardinality and Mandatory !!!
     * TODO: {/Features/Model} Add OnPropertyChanged and Check all Model / [Xml / [Json / Property Logic
     * 
     * TODO: !!! - ISO 19103 - Implement Record Types - Figure 23 !!!
     * 
     * TODO: DANGER !!! - GML valueObjects.xsd could not find implementations for: ComplexType::CategoryExtentType, ComplexType::QuantityExtentType
     * 
     * TODO: Ask Chris to get rid of his folder: Features.test (leaves garbage in the project file).
     * 
     */

    /* Library Progress
     * --------------------------------------------------------------------------------
     * ApplicationSchema +
     * Common
     *   Citation +
     *   Extent +
     *   SpatialSchema +
     * ConceptualSchema -+
     * Constraint +
     * Content +
     * DataQuality
     * Distribution +
     * EntitySet
     * Extension +
     * Identification +
     * Maintenance +
     * Other -+
     * PortrayalCatalogue +
     * ReferenceSystem +
     * Service +
     *   Model -
     * SpatialRepresentation +
     * 
     */

    /* XSD Inheritance
     * --------------------------------------------------------------------------------
     * 
     * + gco = geographic common objects
     * - gfc = geographic feature cataloguing
     * + gmd = geographic metadata
     * - gmi = geographic image metadata
     * + gml = geographic markup language
     * + gmx = geographic xml schema
     * - gplr = 
     * - grg = 
     * + gsr = geographic spatial reference
     * + gss = geographic spatial schema
     * + gts = geographic temporal schema
     * + srv = geographic services
     * 
     * 
     * 
     * gco
     *   basicTypes
     *     gml
     *     xlinks
     *     gcoBase
     *       xlinks
     *       gml
     *       
     *       
     * gml
     *   dynamicFeature
     *     gml
     *     feature
     *       gml
     *       geometryBasic2d
     *         gml
     *         geometryBasic0d1d
     *           gml
     *           measures
     *             gml
     *             units
     *               gml
     *               dictionary
     *                 gml
     *                 gmlBase
     *                   gml
     *                   basicTypes
     *                     gml
     *                   xlink
     *       temporal
     *         gml
     *         gmlBase
     *     direction
     *       gml
     *       geometryBasic0d1d
     *       
     *   topology
     *     gml
     *     geometryComplexes
     *       gml
     *       geometryAggregates
     *         gml
     *         geometryPrimitives
     *           gml
     *           geometryBasic2d
     *     
     *   coverage
     *     gml
     *     feature
     *       gml
     *       geometryBasic2d
     *       temporal
     *     valueObjects
     *       gml
     *       geometryBasic0d1d
     *       temporal
     *     grids
     *       gml
     *       geometryBasic0d1d
     *     geometryAggregates
     *       gml
     *       geometryPrimitives
     *       
     *   coordinateReferenceSystems
     *     gml
     *     coordinateSystems
     *       gml
     *       referenceSystems
     *         gml
     *         geometryBasic2d
     *         temporal
     *     datums
     *       gml
     *       referenceSystems
     *     coordinateOperations
     *       gml
     *       referenceSystems
     *       dataQuality
     *         gml
     *         units
     *   
     *   observation
     *     gml
     *     feature
     *     direction
     *     valueObjects
     *     
     *   defaultStyle
     *     gml
     *     measures
     *     smil20
     *       - [more here]
     *       
     *   temporalReferenceSystems
     *     gml
     *     temporalTopology
     *     dictionary
     *     
     *     
     * gmd
     *   metadataApplication
     *     gco
     *       basicTypes
     *         gml
     *         xlinks
     *         gcoBase
     *           xlinks
     *           gml
     *     metadataEntity
     *       gco
     *       spatialRepresentation
     *         gss
     *           geometry
     *             gml
     *             gco
     *         gco
     *         citation
     *           gco
     *           referenceSystem
     *             gco
     *             citation !!![Circular Reference]!!!
     *             extent
     *               gss
     *               gts
     *                 temporalObjects
     *                   gml
     *                   gco
     *               gco
     *               gsr
     *                 spatialReferencing
     *                   gco
     *                   gml
     *               referenceSystem !!![Circular Reference]!!!
     *       metadataExtension
     *         gco
     *         citation
     *       content
     *         gco
     *         citation
     *       metadataApplication !!![Circular Reference]!!!
     *         gco
     *         metadataEntity !!![Circular Reference]!!!
     *       applicationSchema
     *         gco
     *         citation
     *       portrayalCatalogue
     *         gco
     *         citation
     *       dataQuality
     *         gco
     *         identification
     *           gco
     *           constraints
     *             gco
     *           distribution
     *             gco
     *             citation
     *           maintenance
     *             gts
     *             gco
     *             citation
     *       freeText
     *         gco
     *         identification
     *
     *
     * gmx
     *   gmxUsage
     *     catalogues
     *       uomItem
     *         gml
     *         gco
     *         gmd
     *       codelist
     *         gco
     *         gml
     *         gmd
     *       crs
     *         gco
     *         gml
     *         gmd
     *     extendedTypes
     *       gco
     *       xlinks
     *
     *
     *
     * 
     */



  }

}
