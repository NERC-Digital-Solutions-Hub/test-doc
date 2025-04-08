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
// XSD               : /2005/gml/geometryComplexes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="GeometricComplexType">
//   <complexContent>
//     <extension base="gml:AbstractGeometryType">
//       <sequence>
//         <element name="element" type="gml:GeometricPrimitivePropertyType" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="GeometricComplex" type="gml:GeometricComplexType" substitutionGroup="gml:AbstractGeometry"/>
// <complexType name="GeometricComplexPropertyType">
//   <annotation>
//     <documentation>
//       A property that has a geometric complex as its value domain may either
//       be an appropriate geometry element encapsulated in an element of this
//       type or an XLink reference to a remote geometry element (where remote
//       includes geometry elements located elsewhere in the same document).
//       Either the reference or the contained element shall be given,
//       but neither both nor none.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <choice>
//       <element ref="gml:GeometricComplex"/>
//       <element ref="gml:CompositeCurve"/>
//       <element ref="gml:CompositeSurface"/>
//       <element ref="gml:CompositeSolid"/>
//     </choice>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion


using NDSH.Apps;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Complexes {

  /// <summary>
  /// A property that has a geometric complex as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeometricComplexPropertyType")]
  public class GeometricComplexPropertyType : ObservableModel {
    #region Private fields
    private AbstractGeometryType _item;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// GeometricComplexPropertyType class constructor
    /// </summary>
    public GeometricComplexPropertyType() {
      _owns = false;
    }

    [XmlElement("CompositeCurve", typeof(CompositeCurveType), Order = 0)]
    [XmlElement("CompositeSolid", typeof(CompositeSolidType), Order = 0)]
    [XmlElement("CompositeSurface", typeof(CompositeSurfaceType), Order = 0)]
    [XmlElement("GeometricComplex", typeof(GeometricComplexType), Order = 0)]
    public AbstractGeometryType Item {
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
