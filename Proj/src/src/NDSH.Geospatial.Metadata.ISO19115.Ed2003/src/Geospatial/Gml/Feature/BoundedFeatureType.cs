
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : data, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/feature.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="BoundedFeatureType" abstract="true">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <restriction base="gml:AbstractFeatureType">
//       <sequence>
//         <group ref="gml:StandardObjectProperties"/>
//         <element ref="gml:boundedBy"/>
//         <element ref="gml:location" minOccurs="0"/>
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

namespace NDSH.Geospatial.Gml.Feature {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("BoundedFeatureType")]
  public abstract class BoundedFeatureType : AbstractFeatureType {
  }
}
