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
// <complexType name="MultiSolidPropertyType">
//   <annotation>
//     <documentation>
//       A property that has a collection of solids as its value domain may either be an appropriate geometry element 
//       encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes 
//       geometry elements located elsewhere in the same document). Either the reference or the contained element shall be
//        given, but neither both nor none.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:MultiSolid"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="multiSolidProperty" type="gml:MultiSolidPropertyType">
//   <annotation>
//     <documentation>This property element either references a solid aggregate via the XLink-attributes or contains the 
//       "multi solid" element. multiSolidProperty is the predefined property, which may be used by GML Application 
//       Schemas whenever a GML feature has a property with a value that is substitutable for MultiSolid.
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
  /// A property that has a collection of solids as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiSolidPropertyType")]
  public class MultiSolidPropertyType : ObservableModel {
    #region Private fields
    private MultiSolidType _multiSolid;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// MultiSolidPropertyType class constructor
    /// </summary>
    public MultiSolidPropertyType() {
      _multiSolid = default; // new MultiSolidType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("MultiSolid", Order = 0)]
    public MultiSolidType MultiSolid {
      get {
        return _multiSolid;
      }
      set {
        if (_multiSolid == value) {
          return;
        }
        if (_multiSolid == null || _multiSolid.Equals(value) != true) {
          _multiSolid = value;
          OnPropertyChanged("MultiSolid");
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
