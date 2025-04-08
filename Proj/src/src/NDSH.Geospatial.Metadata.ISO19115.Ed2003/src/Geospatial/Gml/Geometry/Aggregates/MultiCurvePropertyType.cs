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
// XSD               : /2005/gml/geometryAggregates.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="MultiCurvePropertyType">
//   <annotation>
//     <documentation>
//       A property that has a collection of curves as its value domain may either be an appropriate geometry element encapsulated
//       in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements 
//       located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:MultiCurve"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="multiCurveProperty" type="gml:MultiCurvePropertyType">
//   <annotation>
//     <documentation>
//       This property element either references a curve aggregate via the XLink-attributes or contains the "multi curve" element.
//       multiCurveProperty is the predefined property, which may be used by GML Application Schemas whenever a GML feature has a 
//       property with a value that is substitutable for MultiCurve.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Aggregates {


  /// <summary>
  /// A property that has a collection of curves as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiCurvePropertyType")]
  public class MultiCurvePropertyType : ObservableModel {
    #region Private fields
    private MultiCurveType _multiCurve;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// MultiCurvePropertyType class constructor
    /// </summary>
    public MultiCurvePropertyType() {
      _multiCurve = default; // new MultiCurveType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("MultiCurve", Order = 0)]
    public MultiCurveType MultiCurve {
      get {
        return _multiCurve;
      }
      set {
        if (_multiCurve == value) {
          return;
        }
        if (_multiCurve == null || _multiCurve.Equals(value) != true) {
          _multiCurve = value;
          OnPropertyChanged("MultiCurve");
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

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }
  }
}
