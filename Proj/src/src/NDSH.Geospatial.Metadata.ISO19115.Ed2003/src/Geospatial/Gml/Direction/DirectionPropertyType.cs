
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
// <element name="direction" type="gml:DirectionPropertyType">
//   <annotation>
//     <documentation>
//       The property gml:direction is intended as a pre-defined property expressing a
//       direction to be assigned to features defined in a GML application schema.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="DirectionPropertyType">
//   <sequence minOccurs="0">
//     <choice>
//       <element name="DirectionVector" type="gml:DirectionVectorType"/>
//       <element name="DirectionDescription" type="gml:DirectionDescriptionType"/>
//       <element name="CompassPoint" type="gml:CompassPointEnumeration"/>
//       <element name="DirectionKeyword" type="gml:CodeType"/>
//       <element name="DirectionString" type="gml:StringOrRefType"/>
//     </choice>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Direction {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectionPropertyType")]
  public class DirectionPropertyType : ObservableModel {
    #region Private fields
    private object _item;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// DirectionPropertyType class constructor
    /// </summary>
    public DirectionPropertyType() {
      _owns = false;
    }

    [XmlElement("CompassPoint", typeof(CompassPointEnumeration), Order = 0)]
    [XmlElement("DirectionDescription", typeof(DirectionDescriptionType), Order = 0)]
    [XmlElement("DirectionKeyword", typeof(CodeType), Order = 0)]
    [XmlElement("DirectionString", typeof(StringOrRefType), Order = 0)]
    [XmlElement("DirectionVector", typeof(DirectionVectorType), Order = 0)]
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
