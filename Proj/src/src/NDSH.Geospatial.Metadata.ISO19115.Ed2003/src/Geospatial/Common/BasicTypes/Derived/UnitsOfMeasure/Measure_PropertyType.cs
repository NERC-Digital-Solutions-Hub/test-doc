
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 21/12/2022, @gisvlasta
// History           : 27/02/2025, @gisvlasta - Updated inheritance and class documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/basicTypes.xsd
//                     /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// /2005/gml/basicTypes.xsd
// --------------------------------------------------------------------------------
// <complexType name="MeasureType">
//   <simpleContent>
//     <extension base="double">
//       <attribute name="uom" type="gml:UomIdentifier" use="required"/>
//     </extension>
//   </simpleContent>
// </complexType>
// <simpleType name="UomIdentifier">
//   <annotation>
//     <documentation>
//       The simple type gml:UomIdentifer defines the syntax and value space of the unit of measure identifier.
//     </documentation>
//   </annotation>
//   <union memberTypes="gml:UomSymbol gml:UomURI"/>
// </simpleType>
// <simpleType name="UomSymbol">
//   <annotation>
//     <documentation>
//       This type specifies a character string of length at least one, and restricted such that
//       it must not contain any of the following characters:
//         “:” (colon), “ “ (space), (newline), (carriage return), (tab).
//       This allows values corresponding to familiar abbreviations, such as “kg”, “m/s”, etc.
//       It is recommended that the symbol be an identifier for a unit of measure as specified in the
//       “Unified Code of Units of Measure" (UCUM) (http://aurora.regenstrief.org/UCUM).
//       This provides a set of symbols and a grammar for constructing identifiers for units of measure
//       that are unique, and may be easily entered with a keyboard supporting the limited character set
//       known as 7-bit ASCII. ISO 2955 formerly provided a specification with this scope,
//       but was withdrawn in 2001. UCUM largely follows ISO 2955 with modifications to remove ambiguities
//       and other problems.
//     </documentation>
//   </annotation>
//   <restriction base="string">
//     <pattern value="[^: \n\r\t]+"/>
//   </restriction>
// </simpleType>
// <simpleType name="UomURI">
//   <annotation>
//     <documentation>
//       This type specifies a URI, restricted such that it must start with one of the following sequences:
// 			   “#”, “./”, “../”, or a string of characters followed by a “:”.
//       These patterns ensure that the most common URI forms are supported,
//       including absolute and relative URIs and URIs that are simple fragment identifiers,
//       but prohibits certain forms of relative URI that could be mistaken for unit of measure symbol . 
//       NOTE	It is possible to re-write such a relative URI to conform to the restriction (e.g. “./m/s”).
//       In an instance document, on elements of type gml:MeasureType the mandatory uom attribute shall carry
//       a value corresponding to either 
//       - a conventional unit of measure symbol,
//       - a link to a definition of a unit of measure that does not have a conventional symbol,
//       or when it is desired to indicate a precise or variant definition.
//     </documentation>
//   </annotation>
//   <restriction base="anyURI">
//     <pattern value="([a-zA-Z][a-zA-Z0-9\-\+\.]*:|\.\./|\./|#).*"/>
//   </restriction>
// </simpleType>
//
// /2005/gco/basicTypes.xsd
// --------------------------------------------------------------------------------
// <xs:element name="Measure" type="gml:MeasureType"/>
// <xs:complexType name="Measure_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Measure"/>
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
  /// Represents the ISO/OGC <c>Measure_PropertyType</c> in geospatial metadata, as defined by
  /// <see href="http://www.isotc211.org/2005/gco">ISO 19115</see> basic types and
  /// <see href="http://www.opengis.net/gml">GML</see> measures.<br></br>
  /// Inherits from <see cref="MeasureType"/>, which itself extends <see cref="MeasureType"/>
  /// to capture a numeric measure value along with its unit of measure.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Instances whose properties are of <see cref="Measure_PropertyType"/>
  ///     may encode optional metadata such as a nil reason, reflecting the underlying 
  ///     XSD structure’s support for absent or unknown values.
  ///   </para>
  ///   <para>
  ///     Use this class when mapping to a database entity that represents both the
  ///     measure's numeric value and its unit of measure identifier (such as UCUM strings or URIs),
  ///     in accordance with OGC/ISO standards for geospatial metadata.  
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("Measure", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Measure")]
  public class Measure_PropertyType : MeasureType {

  }

}
