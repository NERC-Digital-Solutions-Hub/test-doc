
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
// 
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
  /// Represents the GML <c>VolumeType</c> from the 
  /// <see href="http://www.opengis.net/gml">GML</see> specification. 
  /// This class extends <see cref="MeasureType"/> to capture volume measurements, 
  /// typically expressed as cubic units of measure (e.g., cubic meters).
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Defined in <c>/2005/gml/measures.xsd</c>, <see cref="VolumeType"/> inherits
  ///     the properties of <see cref="MeasureType"/>, including a numeric <see cref="MeasureType.Value"/> 
  ///     (base type <c>double</c>) and a <see cref="MeasureType.UnitOfMeasure"/> <c>uom</c>.
  ///     <br></br>
  ///     This enables precise representation of three-dimensional extents or capacities 
  ///     (e.g., reservoir volume) in geospatial applications.
  ///   </para>
  ///   <para>
  ///     By storing an explicit <see cref="MeasureType.UnitOfMeasure"/> for volume,
  ///     this class ensures that measurements can be consistently interpreted or converted,
  ///     facilitating robust interoperability within GML-compliant datasets and services.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("VolumeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VolumeType")]
  public class VolumeType : MeasureType {

  }

}
