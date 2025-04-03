
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateOperations.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractGeneralTransformation" type="gml:AbstractGeneralTransformationType" abstract="true" substitutionGroup="gml:AbstractOperation">
//   <annotation>
//     <documentation>
//       gml:AbstractGeneralTransformation is an abstract operation on coordinates that usually includes a change of Datum.
//       The parameters of a coordinate transformation are empirically derived from data containing the coordinates of a
//       series of points in both coordinate reference systems. This computational process is usually "over-determined",
//       allowing derivation of error (or accuracy) estimates for the transformation. Also, the stochastic nature of the
//       parameters may result in multiple (different) versions of the same coordinate transformation. The operationVersion,
//       sourceCRS, and targetCRS property elements are mandatory in a coordinate transformation.
//       This abstract complex type is expected to be extended for well-known operation methods with many Transformation instances,
//       in Application Schemas that define operation-method-specialized value element names and contents.
//       This transformation uses an operation method with associated parameter values. 
//       However, operation methods and parameter values are directly associated with concrete subtypes, not with this abstract type.
//       All concrete types derived from this type shall extend this type to include a "usesMethod" element that references
//       one "OperationMethod" element. Similarly, all concrete types derived from this type shall extend this type to include
//       one or more elements each named "uses...Value" that each use the type of an element substitutable for
//       the "AbstractGeneralParameterValue" element.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractGeneralTransformationType" abstract="true">
//   <complexContent>
//     <restriction base="gml:AbstractCoordinateOperationType">
//       <sequence>
//         <element ref="gml:metaDataProperty" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:description" minOccurs="0"/>
//         <element ref="gml:descriptionReference" minOccurs="0"/>
//         <element ref="gml:identifier"/>
//         <element ref="gml:name" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:remarks" minOccurs="0"/>
//         <element ref="gml:domainOfValidity" minOccurs="0"/>
//         <element ref="gml:scope" maxOccurs="unbounded"/>
//         <element ref="gml:operationVersion"/>
//         <element ref="gml:coordinateOperationAccuracy" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:sourceCRS"/>
//         <element ref="gml:targetCRS"/>
//       </sequence>
//       <attribute ref="gml:id" use="required"/>
//     </restriction>
//   </complexContent>
// </complexType>
// <complexType name="GeneralTransformationPropertyType">
//   <annotation>
//     <documentation>
//       gml:GeneralTransformationPropertyType is a property type for association roles to a general transformation,
//       either referencing or containing the definition of that transformation.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractGeneralTransformation"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
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

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  //[XmlInclude(typeof(ML_Transformation_Type))] // GMX
  //[XmlInclude(typeof(TransformationType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralTransformationType")]
  public abstract class AbstractGeneralTransformationType : AbstractCoordinateOperationType {

  }

}
