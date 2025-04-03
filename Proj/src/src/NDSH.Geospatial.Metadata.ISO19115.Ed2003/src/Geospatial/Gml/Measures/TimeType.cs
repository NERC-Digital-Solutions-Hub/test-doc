
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
// <complexType name="TimeType">
//   <simpleContent>
//     <extension base="gml:MeasureType"/>
//   </simpleContent>
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

namespace NDSH.Geospatial.Gml.Measures {

  /// <summary>
  /// Represents the GML <c>TimeType</c> from the 
  /// <see href="http://www.opengis.net/gml">GML</see> specification. 
  /// This class extends <see cref="MeasureType"/> to handle time-based measurements, 
  /// typically indicating durations or intervals in a specified unit of measure (e.g., seconds, minutes, hours).
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Defined in <c>/2005/gml/measures.xsd</c>, <see cref="TimeType"/> inherits the properties 
  ///     of <see cref="MeasureType"/>, providing both a numeric <see cref="MeasureType.Value"/>
  ///     (base type: <c>double</c>) and a <see cref="MeasureType.UnitOfMeasure"/> (<c>uom</c>).
  ///     <br></br>
  ///     In geospatial contexts, this is commonly used to describe
  ///     time intervals, periods, or durations relevant to temporal data.
  ///   </para>
  ///   <para>
  ///     Storing an explicit <see cref="MeasureType.UnitOfMeasure"/> ensures that any time measurement
  ///     can be understood and converted accurately, promoting consistent data exchange across various
  ///     GML-compliant applications.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("TimeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeType")]
  public class TimeType : MeasureType {

  }

}
