
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
// <complexType name="LengthType">
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
  /// Represents the GML <c>LengthType</c> as defined by
  /// <see href="http://www.opengis.net/gml">GML</see> specification.
  /// This class extends <see cref="MeasureType"/> to store length measurements,
  /// typically expressed as a numeric value plus a mandatory unit of measure (<c>uom</c>).
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Defined in <c>/2005/gml/measures.xsd</c>, <see cref="LengthType"/> inherits the properties of
  ///     <see cref="MeasureType"/>, including the numeric <see cref="MeasureType.Value"/>
  ///     (base type <c>double</c>) and <see cref="MeasureType.UnitOfMeasure"/> (<c>uom</c>).
  ///     <br></br>
  ///     In geospatial contexts, it is commonly used to describe linear extents such as
  ///     distances, diameters, or any other length-based measurement.
  ///   </para>
  ///   <para>
  ///     By maintaining explicit <see cref="MeasureType.UnitOfMeasure"/> information,
  ///     this class allows for unambiguous representation of lengths in GML-compliant datasets,
  ///     facilitating accurate data exchange and interoperability.
  ///   </para>
  ///   <para>
  ///   This is a prototypical definition for a specific measure type defined as a vacuous extension
  ///   (i.e. aliases) of gml:MeasureType. In this case, the content model supports the description
  ///   of a length (or distance) quantity, with its units. The unit of measure referenced by uom 
  ///   shall be suitable for a length, such as metres or feet.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("LengthType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("LengthType")]
  public class LengthType : MeasureType {

  }

}
