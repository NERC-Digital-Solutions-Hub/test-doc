
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
// XSD               : /2005/gml/coverage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="GridCoverage" type="gml:GridCoverageType" substitutionGroup="gml:AbstractDiscreteCoverage">
//   <annotation>
//     <documentation>
//       A gml:GriddedCoverage is a discrete point coverage in which the domain set is a geometric grid of points.
//       Note that this is the same as the gml:MultiPointCoverage except that we have a gml:gridDomain
//       property to describe the domain. The simple gridded coverage is not geometrically referenced and
//       hence no geometric positions are assignable to the points in the grid.
//       Such geometric positioning is introduced in the gml:RectifiedGridCoverage.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="GridCoverageType">
//   <complexContent>
//     <restriction base="gml:AbstractDiscreteCoverageType">
//       <sequence>
//         <group ref="gml:StandardObjectProperties"/>
//         <element ref="gml:boundedBy" minOccurs="0"/>
//         <element ref="gml:gridDomain"/>
//         <element ref="gml:rangeSet"/>
//         <element ref="gml:coverageFunction" minOccurs="0"/>
//       </sequence>
//     </restriction>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coverage {

  [IsoType("GridCoverageType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridCoverageType")]
  public class GridCoverageType : AbstractDiscreteCoverageType {

  }

}
