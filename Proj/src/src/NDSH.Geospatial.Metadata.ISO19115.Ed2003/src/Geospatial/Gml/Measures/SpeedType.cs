
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
// <complexType name="SpeedType">
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
  /// Represents the GML <c>SpeedType</c> as defined by
  /// <see href="http://www.opengis.net/gml">GML</see> specification.
  /// This class extends <see cref="MeasureType"/> to store speed measurements,
  /// typically expressed as a distance per unit time (e.g., meters per second).
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Defined in <c>/2005/gml/measures.xsd</c>, <see cref="SpeedType"/> inherits the properties
  ///     of <see cref="MeasureType"/>, namely a numeric <see cref="MeasureType.Value"/>
  ///     (base type <c>double</c>) and an associated <see cref="MeasureType.UnitOfMeasure"/> (<c>uom</c>).
  ///     <br></br>
  ///     In a geospatial context, speed often applies to movement of a feature or
  ///     phenomenon within the coordinate reference system.
  ///   </para>
  ///   <para>
  ///     By maintaining explicit <see cref="MeasureType.UnitOfMeasure"/> information,
  ///     this class ensures that any speed measurement can be consistently interpreted or transformed,
  ///     contributing to more reliable geospatial data exchange.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("SpeedType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SpeedType")]
  public class SpeedType : MeasureType {

  }

}
