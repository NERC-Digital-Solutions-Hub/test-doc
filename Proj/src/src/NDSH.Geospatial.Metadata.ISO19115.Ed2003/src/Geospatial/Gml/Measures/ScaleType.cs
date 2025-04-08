
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
// <complexType name="ScaleType">
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
  /// Represents the GML <c>ScaleType</c> from the 
  /// <see href="http://www.opengis.net/gml">GML</see> specification. 
  /// This class extends <see cref="MeasureType"/> to handle scale or ratio 
  /// measurements, typically dimensionless values with an optional unit of measure.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Defined in <c>/2005/gml/measures.xsd</c>, <see cref="ScaleType"/> inherits the 
  ///     properties of <see cref="MeasureType"/>, storing a numeric <see cref="MeasureType.Value"/>
  ///     and its corresponding <see cref="MeasureType.UnitOfMeasure"/> <c>uom</c>.
  ///     In many geospatial contexts, scale is dimensionless or expressed as a ratio (e.g., “1:50,000”),
  ///     but if necessary, a unit of measure can be provided to support domain-specific needs.
  ///   </para>
  ///   <para>
  ///     Use this class to ensure your model complies with GML requirements for 
  ///     scale-related metadata, enabling standardized exchange of geospatial data 
  ///     involving scale factors or ratios.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("ScaleType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ScaleType")]
  public class ScaleType : MeasureType {

  }

}
