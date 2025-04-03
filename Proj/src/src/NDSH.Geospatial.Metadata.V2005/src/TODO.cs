using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.Metadata.V2005 {
  
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
     * 
     * TODO: {Service Folder} Is the namespace GMD???
     * TODO: {Service Folder} Initialization - Make sure it is correct by reading the documentation regarding cardinality and Mandatory !!!
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
     * gco = geographic common objects
     * gss = geographic spatial schema
     * gts = geographic temporal schema
     * gsr = geographic spatial reference
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
     */



  }

}
