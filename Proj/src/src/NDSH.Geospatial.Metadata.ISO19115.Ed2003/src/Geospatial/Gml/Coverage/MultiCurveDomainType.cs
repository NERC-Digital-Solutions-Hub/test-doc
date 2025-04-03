
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
// <element name="multiCurveDomain" type="gml:MultiCurveDomainType" substitutionGroup="gml:domainSet"/>
// <complexType name="MultiCurveDomainType">
//   <complexContent>
//     <restriction base="gml:DomainSetType">
//       <sequence minOccurs="0">
//         <element ref="gml:MultiCurve"/>
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

  [IsoType("MultiCurveDomainType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiCurveDomainType")]
  public class MultiCurveDomainType : DomainSetType {

  }

}
