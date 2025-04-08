
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/directions.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="DirectionDescriptionType">
//   <annotation>
//     <documentation>
//       Direction descriptions are specified by a compass point code, a keyword, a textual description or a reference to a description.
//       A gml:compassPoint is specified by a simple enumeration.    
//       In addition, thre elements to contain text-based descriptions of direction are provided.  
//       If the direction is specified using a term from a list, gml:keyword should be used, and the list indicated using the value of the codeSpace attribute. 
//       if the direction is decribed in prose, gml:direction or gml:reference should be used, allowing the value to be included inline or by reference.
//     </documentation>
//   </annotation>
//   <choice>
//     <element name="compassPoint" type="gml:CompassPointEnumeration"/>
//     <element name="keyword" type="gml:CodeType"/>
//     <element name="description" type="string"/>
//     <element name="reference" type="gml:ReferenceType"/>
//   </choice>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Direction {


  /// <summary>
  /// direction descriptions are specified by a compass point code, a keyword, a textual description or a reference to a description.
  /// A gml:compassPoint is specified by a simple enumeration.
  /// In addition, thre elements to contain text-based descriptions of direction are provided.
  /// If the direction is specified using a term from a list, gml:keyword should be used, and the list indicated using the value of the codeSpace attribute.
  /// if the direction is decribed in prose, gml:direction or gml:reference should be used, allowing the value to be included inline or by reference.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectionDescriptionType")]
  public class DirectionDescriptionType : ObservableModel {
    #region Private fields
    private object _item;
    #endregion

    [XmlElement("compassPoint", typeof(CompassPointEnumeration), Order = 0)]
    [XmlElement("description", typeof(string), Order = 0)]
    [XmlElement("keyword", typeof(CodeType), Order = 0)]
    [XmlElement("reference", typeof(ReferenceType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }
  }



}
