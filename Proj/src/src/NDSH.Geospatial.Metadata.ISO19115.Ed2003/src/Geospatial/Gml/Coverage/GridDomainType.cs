
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
// <element name="gridDomain" type="gml:GridDomainType" substitutionGroup="gml:domainSet"/>
// <complexType name="GridDomainType">
//   <complexContent>
//     <restriction base="gml:DomainSetType">
//       <sequence minOccurs="0">
//         <choice>
//           <choice>
//             <element ref="gml:Grid"/>
//           </choice>
//           <choice/>
//         </choice>
//       </sequence>
//       <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//       <attributeGroup ref="gml:AssociationAttributeGroup"/>
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

  [IsoType("GridDomainType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridDomainType")]
  public class GridDomainType : DomainSetType {

  }

}
