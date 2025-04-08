
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
// <xs:element name="Scale" type="gml:ScaleType" substitutionGroup="gco:Measure"/>
// <xs:complexType name="Scale_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Scale"/>
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
  /// Represents the ISO/OGC <c>Scale_PropertyType</c> in geospatial metadata, as defined by
  /// <see href="http://www.isotc211.org/2005/gco">ISO 19115</see> basic types and
  /// <see href="http://www.opengis.net/gml">GML</see> measures.<br></br>
  /// Inherits from <see cref="ScaleType"/>, which itself extends <see cref="MeasureType"/> 
  /// to capture a scale factor (or ratio) along with its unit of measure.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Instances whose properties are of <see cref="Scale_PropertyType"/> 
  ///     may encode optional metadata such as a nil reason, reflecting the underlying 
  ///     XSD structure’s support for absent or unknown values.
  ///   </para>
  ///   <para>
  ///     Use this class when you need to record or manipulate scale factors in geospatial 
  ///     metadata, for example mapping scale or ratio-based measures that require explicit 
  ///     unit-of-measure information. This design ensures compliance with ISO/GML standards 
  ///     for documenting scale-oriented data.
  ///   </para>
  /// </remarks>

  //[Serializable]
  //[XmlType("Scale_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Scale_PropertyType")]
  public class Scale_PropertyType : ScaleType {

  }

}
