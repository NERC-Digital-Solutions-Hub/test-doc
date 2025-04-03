
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/measures.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AreaType">
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
  /// Represents the GML <c>AreaType</c> from the
  /// <see href="http://www.opengis.net/gml">GML</see> specification.
  /// This class extends <see cref="MeasureType"/> to store area measurements,
  /// typically including a numeric value and a unit of measure.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     According to <c>/2005/gml/measures.xsd</c>, <see cref="AreaType"/>
  ///     inherits the properties of <see cref="MeasureType"/>, making it suitable for
  ///     specifying the total surface area of a feature in geospatial contexts
  ///     (e.g., polygons, footprints, or bounding surfaces).
  ///   </para>
  ///   <para>
  ///     By explicitly tracking the <see cref="MeasureType.UnitOfMeasure"/> (<c>uom</c>)
  ///     (for example, square meters), this class ensures that area measurements are accurately
  ///     described and interoperable across different GML-compliant systems.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("AreaType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AreaType")]
  public class AreaType : MeasureType {

  }

}
