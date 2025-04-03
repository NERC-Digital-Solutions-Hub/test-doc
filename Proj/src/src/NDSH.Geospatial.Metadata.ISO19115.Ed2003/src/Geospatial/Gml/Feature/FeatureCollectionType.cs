
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
// <element name="FeatureCollection" type="gml:FeatureCollectionType" substitutionGroup="gml:AbstractFeature">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// <complexType name="FeatureCollectionType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractFeatureCollectionType"/>
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
  [JsonObject("FeatureCollectionType")]
  public class FeatureCollectionType : AbstractFeatureCollectionType {
  }
}
