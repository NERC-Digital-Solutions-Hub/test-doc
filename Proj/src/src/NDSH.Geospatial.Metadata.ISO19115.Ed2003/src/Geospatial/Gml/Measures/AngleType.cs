
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/measures.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AngleType">
//   <simpleContent>
//     <extension base="gml:MeasureType"/>
//   </simpleContent>
// </complexType>
// <element name="angle" type="gml:AngleType">
//   <annotation>
//     <documentation>
//       The gml:angle property element is used to record the value of an angle quantity as a single number,
//       with its units.
//     </documentation>
//   </annotation>
// </element>
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

namespace NDSH.Geospatial.Gml.Measures {

  /// <summary>
  /// Represents the GML <c>AngleType</c> as defined by
  /// <see href="http://www.opengis.net/gml">GML</see> specification.
  /// This type extends <see cref="MeasureType"/> to handle angular measurements
  /// (e.g., bearing, azimuth, or other rotational values),
  /// storing a numeric angle value and its unit of measure.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     According to the definitions in <c>/2005/gml/measures.xsd</c>, <see cref="AngleType"/>
  ///     is used to record an angle quantity as a single numeric <see cref="MeasureType.Value"/>
  ///     (base type <c>double</c>) with a corresponding <see cref="MeasureType.UnitOfMeasure"/> (<c>uom</c>).
  ///   </para>
  ///   <para>
  ///     Implementing <see cref="IAngle"/> ensures consistency with the geospatial
  ///     metadata model for handling angles across various spatial contexts
  ///     (e.g., directional data, rotation angles, or slope measurements).
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("AngleType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AngleType")]
  public class AngleType : MeasureType, IAngle {

  }

}
