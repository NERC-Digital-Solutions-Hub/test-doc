
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// History           : 27/02/2025, @gisvlasta - Updated inheritance and class documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/measures.xsd
//                     /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="LengthType">
//   <simpleContent>
//     <extension base="gml:MeasureType"/>
//   </simpleContent>
// </complexType>
// <xs:element name="Distance" type="gml:LengthType" substitutionGroup="gco:Length"/>
// <xs:complexType name="Distance_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Distance"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Measures;
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
  /// Represents the ISO/OGC <c>Distance_PropertyType</c> in geospatial metadata, as defined by
  /// <see href="http://www.isotc211.org/2005/gco">ISO 19115</see> basic types and
  /// <see href="http://www.opengis.net/gml">GML</see> measures.<br></br>
  /// Inherits from <see cref="LengthType"/>, which itself extends <see cref="MeasureType"/>
  /// to capture a numeric value along with its unit of measure.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Instances whose properties are of <see cref="Distance_PropertyType"/>
  ///     may encode optional metadata such as a nil reason, reflecting the underlying 
  ///     XSD structure’s support for absent or unknown values.
  ///   </para>
  ///   <para>
  ///     Use this class when you need a geospatial metadata model that distinguishes a distance
  ///     (e.g., a separation or interval value) and ensures compliance with ISO/GML schemas.<br></br>
  ///     In many contexts, distance is treated as a specialized form of length, potentially including
  ///     domain-specific validation or additional business rules.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("Distance", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Distance")]
  public class Distance_PropertyType : LengthType {

  }

}
