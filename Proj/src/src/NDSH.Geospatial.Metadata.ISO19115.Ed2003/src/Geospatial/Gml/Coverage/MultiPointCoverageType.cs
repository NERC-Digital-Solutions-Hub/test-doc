
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
// XSD               : 
// ---------------------------------------------------------------------------------------------------------------------
// <element name="MultiPointCoverage" type="gml:MultiPointCoverageType" substitutionGroup="gml:AbstractDiscreteCoverage">
//   <annotation>
//     <documentation>
//       In a gml:MultiPointCoverage the domain set is a gml:MultiPoint, that is a collection of
//       arbitrarily distributed geometric points.
//       The content model is derived by restriction from gml:AbstractDiscreteCoverageType.
//       Note that the restriction replaces the generic gml:domainSet by the specific gml:multiPointDomain
//       whose value is a gml:MultiPoint.
//       In a gml:MultiPointCoverage the mapping from the domain to the range is straightforward.
//       -  For gml:DataBlock encodings the points of the gml:MultiPoint are mapped in document order
//          to the tuples of the data block.
//       -  For gml:CompositeValue encodings the points of the gml:MultiPoint are mapped to the members of
//          the composite value in document order.
//       -  For gml:File encodings the points of the gml:MultiPoint are mapped to the records of
//          the file in sequential order.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="MultiPointCoverageType">
//   <complexContent>
//     <restriction base="gml:AbstractDiscreteCoverageType">
//       <sequence>
//         <group ref="gml:StandardObjectProperties"/>
//         <element ref="gml:boundedBy" minOccurs="0"/>
//         <element ref="gml:multiPointDomain"/>
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

  [IsoType("MultiPointCoverageType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiPointCoverageType")]
  public class MultiPointCoverageType : AbstractDiscreteCoverageType {

  }

}
