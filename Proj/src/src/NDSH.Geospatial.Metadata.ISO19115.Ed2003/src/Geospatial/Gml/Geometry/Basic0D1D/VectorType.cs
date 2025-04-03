#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryAggregates.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="VectorType">
//   <annotation>
//     <documentation>
//       For some applications the components of the position may be adjusted to yield a unit vector.
//     </documentation>
//   </annotation>
//   <simpleContent>
//     <restriction base="gml:DirectPositionType"/>
//   </simpleContent>
// </complexType>
// <element name="vector" type="gml:VectorType"/>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {

  /// <summary>
  /// For some applications the components of the position may be adjusted to yield a unit vector.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VectorType")]
  public class VectorType : DirectPositionType {

  }

}
