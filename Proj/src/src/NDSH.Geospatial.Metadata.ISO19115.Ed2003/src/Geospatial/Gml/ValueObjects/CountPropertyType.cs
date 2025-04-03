
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

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CountPropertyType")]
  public class CountPropertyType : ObservableModel {

    #region Private fields
    private Count _count;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// CountPropertyType class constructor
    /// </summary>
    public CountPropertyType() {
      _count = new Count();
    }

    [XmlElement(IsNullable = true, Order = 0)]
    [JsonProperty("Count", Order = 0)]
    public Count Count {
      get {
        return _count;
      }
      set {
        if (_count == value) {
          return;
        }
        if (_count == null || _count.Equals(value) != true) {
          _count = value;
          OnPropertyChanged("Count");
        }
      }
    }

    [XmlAttribute]
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
          OnPropertyChanged("NilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("RemoteSchema");
        }
      }
    }

  }

}
