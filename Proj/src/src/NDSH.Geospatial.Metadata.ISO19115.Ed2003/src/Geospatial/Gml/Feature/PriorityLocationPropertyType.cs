
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
// <element name="priorityLocation" type="gml:PriorityLocationPropertyType" substitutionGroup="gml:location">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// <complexType name="PriorityLocationPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <extension base="gml:LocationPropertyType">
//       <attribute name="priority" type="string"/>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PriorityLocationPropertyType")]
  public class PriorityLocationPropertyType : LocationPropertyType {
    #region Private fields
    private string _priority;
    #endregion

    [XmlAttribute]
    [JsonProperty("priority")]
    public string Priority {
      get {
        return _priority;
      }
      set {
        if (_priority == value) {
          return;
        }
        if (_priority == null || _priority.Equals(value) != true) {
          _priority = value;
          OnPropertyChanged("Priority");
        }
      }
    }
  }
}
