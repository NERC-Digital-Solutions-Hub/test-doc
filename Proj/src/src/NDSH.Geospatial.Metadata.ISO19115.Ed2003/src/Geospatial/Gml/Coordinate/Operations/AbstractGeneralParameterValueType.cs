
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
// <element name="AbstractGeneralParameterValue" type="gml:AbstractGeneralParameterValueType" abstract="true" substitutionGroup="gml:AbstractObject">
//   <annotation>
//     <documentation>gml:AbstractGeneralParameterValue is an abstract parameter value or group of parameter values.
//       This abstract complexType is expected to be extended and restricted for well-known operation methods with many instances,
//       in Application Schemas that define operation-method-specialized element names and contents.
//       Specific parameter value elements are directly contained in concrete subtypes, not in this abstract type.
//       All concrete types derived from this type shall extend this type to include one "...Value" element with an appropriate type,
//       which should be one of the element types allowed in the ParameterValueType.
//       In addition, all derived concrete types shall extend this type to include a "operationParameter" property element that references
//       one element substitutable for the "OperationParameter" object element.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractGeneralParameterValueType" abstract="true">
//   <sequence/>
// </complexType>
// <complexType name="AbstractGeneralParameterValuePropertyType">
//   <annotation>
//     <documentation>
//       gml:AbstractGeneralParameterValuePropertyType is a property type for inline association roles to a parameter value or group of parameter values,
//       always containing the values.
//     </documentation>
//   </annotation>
//   <sequence>
//     <element ref="gml:AbstractGeneralParameterValue"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 01/02/2023, 20:47, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(ParameterValueGroupType))]
  //[XmlInclude(typeof(ParameterValueType))]
  [Serializable]
  //[XmlType("AbstractGeneralParameterValueType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralParameterValueType")]
  public abstract class AbstractGeneralParameterValueType : ObservableModel {

  }

}
