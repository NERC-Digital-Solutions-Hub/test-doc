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
// <complexType name="PointArrayPropertyType">
//   <annotation>
//     <documentation>
//       gml:PointArrayPropertyType is a container for an array of points. The elements are always contained inline in the 
//       array property, referencing geometry elements or arrays of geometry elements via XLinks is not supported.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0" maxOccurs="unbounded">
//     <element ref="gml:Point"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="pointArrayProperty" type="gml:PointArrayPropertyType">
//   <annotation>
//     <documentation>
//       This property element contains a list of point elements. pointArrayProperty is the predefined property 
//       which may be used by GML Application Schemas whenever a GML feature has a property with a value that is substitutable 
//       for a list of points.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {


  /// <summary>
  /// gml:PointArrayPropertyType is a container for an array of points. The elements are always contained inline in the array property, referencing geometry elements or arrays of geometry elements via XLinks is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PointArrayPropertyType")]
  public class PointArrayPropertyType : ObservableModel {
    #region Private fields
    private List<PointType> _point;
    private bool _owns;
    #endregion

    /// <summary>
    /// PointArrayPropertyType class constructor
    /// </summary>
    public PointArrayPropertyType() {
      _point = new List<PointType>();
      _owns = false;
    }

    [XmlElement("Point", Order = 0)]
    [JsonProperty("Point", Order = 0)]
    public List<PointType> Point {
      get {
        return _point;
      }
      set {
        if (_point == value) {
          return;
        }
        if (_point == null || _point.Equals(value) != true) {
          _point = value;
          OnPropertyChanged("Point");
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
