
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
// <element name="boundedBy" type="gml:BoundingShapeType" nillable="true">
//   <annotation>
//     <documentation>This property describes the minimum bounding box or rectangle that encloses the entire feature.</documentation>
//   </annotation>
// </element>
// <complexType name="BoundingShapeType">
//   <sequence>
//     <choice>
//       <element ref="gml:Envelope"/>
//       <element ref="gml:Null"/>
//     </choice>
//   </sequence>
//   <attribute name="nilReason" type="gml:NilReasonType"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Feature {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("BoundingShapeType")]
  public class BoundingShapeType : ObservableModel {
    #region Private fields
    private object _item;
    private string _nilReason;
    #endregion

    [XmlElement("Envelope", typeof(EnvelopeType), Order = 0)]
    [XmlElement("Null", typeof(string), Order = 0)]
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
  }
}
