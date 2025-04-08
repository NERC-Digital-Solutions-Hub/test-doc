
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
// <complexType name="GridLengthType">
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
  /// Represents the GML <c>GridLengthType</c> as defined by
  /// <see href="http://www.opengis.net/gml">GML</see> specification.
  /// This type extends <see cref="MeasureType"/> to describe grid spacing or resolution dimensions 
  /// within a geospatial context.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Defined in <c>/2005/gml/measures.xsd</c>, <see cref="GridLengthType"/> inherits the properties of 
  /// <see cref="MeasureType"/>, thus including both a numeric <see cref="MeasureType.Value"/>
  /// (base type <c>double</c>) and a <see cref="MeasureType.UnitOfMeasure"/> (<c>uom</c>).
  /// <br></br>
  /// This is commonly used to specify the spacing along a grid axis, 
  /// ensuring consistency in geospatial data where precise measurements are needed.
  /// </para>
  /// <para>
  /// By leveraging <see cref="GridLengthType"/>, you can maintain explicit unit information alongside 
  /// the numeric value, in accordance with GML standards for expressing distance or resolution within 
  /// grid-based spatial datasets.
  /// </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("GridLengthType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridLengthType")]
  public class GridLengthType : MeasureType {

  }

}
