
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// History           : 27/02/2025, @gisvlasta - Updated inheritance and class documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="UnitOfMeasure_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:UnitDefinition"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Units;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure {

  /// <summary>
  /// Represents the ISO/OGC <c>UnitOfMeasure_PropertyType</c> in geospatial metadata, as defined by 
  /// <see href="http://www.isotc211.org/2005/gco">ISO 19115</see> and leveraging 
  /// <see href="http://www.opengis.net/gml">GML</see> unit definitions.
  /// This class inherits from <see cref="UnitDefinitionType"/>, allowing for detailed 
  /// descriptions of a unit of measure
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Instances whose properties are of <see cref="UnitOfMeasure_PropertyType"/> 
  ///     may encode optional metadata such as a nil reason, reflecting the underlying 
  ///     XSD structure’s support for absent or unknown values.
  ///   </para>
  ///   <para>
  ///     By inheriting from <see cref="UnitDefinitionType"/>, this class unifies 
  ///     GML-based unit definitions with ISO-compliant metadata references, ensuring 
  ///     that any described unit of measure can be accurately interpreted and 
  ///     consistently managed within a broader geospatial information framework.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("UnitOfMeasure", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("UnitOfMeasure")]
  public class UnitOfMeasure_PropertyType : UnitDefinitionType {

  }

}
