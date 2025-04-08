
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
// <element name="OperationParameter" type="gml:OperationParameterType" substitutionGroup="gml:AbstractGeneralOperationParameter">
//   <annotation>
//     <documentation>
//       gml:OperationParameter is the definition of a parameter used by an operation method.
//       Most parameter values are numeric, but other types of parameter values are possible.
//       This complex type is expected to be used or extended for all operation methods,
//       without defining operation-method-specialized element names.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="OperationParameterType">
//   <complexContent>
//     <extension base="gml:AbstractGeneralOperationParameterType">
//       <sequence/>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="OperationParameterPropertyType">
//   <annotation>
//     <documentation>
//       gml:OperationParameterPropertyType is a property type for association roles to an operation parameter,
//       either referencing or containing the definition of that parameter.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:OperationParameter"/>
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

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(ML_OperationParameter_Type))] // GMX
  //[XmlInclude(typeof(OperationParameterAlt_Type))] // GMX
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationParameterType")]
  public class OperationParameterType : AbstractGeneralOperationParameterType {

  }

}
