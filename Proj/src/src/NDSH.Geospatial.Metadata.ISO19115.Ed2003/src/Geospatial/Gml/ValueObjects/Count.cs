
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 01/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/valueObjects.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="Count" substitutionGroup="gml:AbstractScalarValue" nillable="true">
//   <complexType>
//     <simpleContent>
//       <extension base="integer">
//         <attribute name="nilReason" type="gml:NilReasonType"/>
//       </extension>
//     </simpleContent>
//   </complexType>
// </element>
// 
// <complexType name="CountPropertyType">
//   <sequence minOccurs="0">
//     <element ref="gml:Count"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.ValueObjects {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("Count", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Count")]
  public class Count : ObservableModel {

    #region Public Properties

    private string _nilReason;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("nilReason")]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "integer")]
    [JsonProperty("Value")]
    public string Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
