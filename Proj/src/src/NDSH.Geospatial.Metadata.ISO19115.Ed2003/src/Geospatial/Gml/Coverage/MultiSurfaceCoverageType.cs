
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
// <element name="MultiSurfaceCoverage" type="gml:MultiSurfaceCoverageType" substitutionGroup="gml:AbstractDiscreteCoverage">
//   <annotation>
//     <documentation>
//       In a gml:MultiSurfaceCoverage the domain is partitioned into a collection of surfaces comprising a
//       gml:MultiSurface.  The coverage function than maps each surface in the collection to a value in the range set.
//       The content model is derived by restriction from gml:AbstractDiscreteCoverageType.
//       Note that the restriction replaces the generic gml:domainSet by the specific gml:multiSurfaceDomain
//       whose value is a gml:MultiSurface.
//       In a gml:MultiSurfaceCoverage the mapping from the domain to the range is straightforward.
//       -  For gml:DataBlock encodings the surfaces of the gml:MultiSurface are mapped in document order to
//          the tuples of the data block.
//       -  For gml:CompositeValue encodings the surfaces of the gml:MultiSurface are mapped to the members of
//          the composite value in document order.
//       -  For gml:File encodings the surfaces of the gml:MultiSurface are mapped to the records of
//          the file in sequential order.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="MultiSurfaceCoverageType">
//   <complexContent>
//     <restriction base="gml:AbstractDiscreteCoverageType">
//       <sequence>
//         <group ref="gml:StandardObjectProperties"/>
//         <element ref="gml:boundedBy" minOccurs="0"/>
//         <element ref="gml:multiSurfaceDomain"/>
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

  [IsoType("MultiSurfaceCoverageType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiSurfaceCoverageType")]
  public class MultiSurfaceCoverageType : AbstractDiscreteCoverageType {

  }

}
