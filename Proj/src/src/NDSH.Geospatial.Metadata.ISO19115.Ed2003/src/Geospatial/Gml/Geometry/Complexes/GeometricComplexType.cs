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


using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Complexes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeometricComplexType")]
  public class GeometricComplexType : AbstractGeometryType {
    #region Private fields
    private List<GeometricPrimitivePropertyType> _element;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// GeometricComplexType class constructor
    /// </summary>
    public GeometricComplexType() {
      _element = new List<GeometricPrimitivePropertyType>();
    }

    [XmlElement("element", Order = 0)]
    [JsonProperty("element", Order = 0)]
    public List<GeometricPrimitivePropertyType> Element {
      get {
        return _element;
      }
      set {
        if (_element == value) {
          return;
        }
        if (_element == null || _element.Equals(value) != true) {
          _element = value;
          OnPropertyChanged("Element");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }
  }
}
