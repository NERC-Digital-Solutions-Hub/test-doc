
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/02/2023, @gisvlasta
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
// <xs:element name="Length" type="gml:LengthType" substitutionGroup="gco:Measure"/>
// <xs:complexType name="Length_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Length"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Derived.UnitsOfMeasure {

  /// <summary>
  /// Represents the ISO/OGC <c>Length_PropertyType</c> in geospatial metadata, as defined by
  /// <see href="http://www.isotc211.org/2005/gco">ISO 19115</see> basic types and
  /// <see href="http://www.opengis.net/gml">GML</see> measures.<br></br>
  /// Inherits from <see cref="LengthType"/>, which itself extends <see cref="MeasureType"/>
  /// to capture a  numeric value along with its unit of measure.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Instances whose properties are of <see cref="Length_PropertyType"/>
  ///     may encode optional metadata such as a nil reason, reflecting the underlying 
  ///     XSD structure’s support for absent or unknown values.
  ///   </para>
  ///   <para>
  ///     Use this class if you need to store or manipulate ISO/GML-compliant length measurements
  ///     in a geospatial metadata context, including the unit of measure (uom).
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("Length_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Length_PropertyType")]
  public class Length_PropertyType : LengthType {

  }

}
