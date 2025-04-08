
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
// History           : 27/02/2025, @gisvlasta - Updated inheritance and class documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="Angle" type="gml:AngleType" substitutionGroup="gco:Measure"/>
// <xs:complexType name="Angle_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Angle"/>
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
  /// Represents the ISO/OGC <c>Angle_PropertyType</c> in geospatial metadata, as defined by
  /// <see href="http://www.isotc211.org/2005/gco">ISO 19115</see> basic types and
  /// <see href="http://www.opengis.net/gml">GML</see> measures.<br></br>
  /// Inherits from <see cref="AngleType"/>, which itself extends <see cref="MeasureType"/>
  /// to capture a numeric angle value along with its unit of measure.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Instances whose properties are of <see cref="Angle_PropertyType"/>
  ///     may encode optional metadata such as a nil reason, reflecting the underlying 
  ///     XSD structure’s support for absent or unknown values.
  ///   </para>
  ///   <para>
  ///     Use this class when you need to record or manipulate angle values
  ///     (such as bearings, azimuths, or other directional data) with explicit
  ///     unit-of-measure information.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("Angle", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Angle")]
  public class Angle_PropertyType : AngleType {

  }

}
