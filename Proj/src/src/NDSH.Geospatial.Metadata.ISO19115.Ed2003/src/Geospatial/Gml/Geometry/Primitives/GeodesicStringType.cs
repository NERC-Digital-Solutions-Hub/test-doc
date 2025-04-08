
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
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="GeodesicStringType">
//   <complexContent>
//     <extension base="gml:AbstractCurveSegmentType">
//       <choice>
//         <element ref="gml:posList"/>
//         <group ref="gml:geometricPositionGroup" minOccurs="2" maxOccurs="unbounded"/>
//       </choice>
//       <attribute name="interpolation" type="gml:CurveInterpolationType" fixed="geodesic"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="GeodesicString" type="gml:GeodesicStringType" substitutionGroup="gml:AbstractCurveSegment">
//   <annotation>
//     <documentation>
//       A sequence of geodesic segments. 
//       The number of control points shall be at least two.
//       interpolation is fixed as "geodesic".
//       The content model follows the general pattern for the encoding of curve segments.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  //[XmlInclude(typeof(GeodesicType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodesicStringType")]
  public class GeodesicStringType : AbstractCurveSegmentType {
    #region Private fields
    private object _item;
    private CurveInterpolationType _interpolation;
    #endregion

    /// <summary>
    /// GeodesicStringType class constructor
    /// </summary>
    public GeodesicStringType() {
      _interpolation = CurveInterpolationType.geodesic;
    }

    [XmlElement("pointProperty", typeof(PointPropertyType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("posList", typeof(DirectPositionListType), Order = 0)]
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
    [JsonProperty("interpolation")]
    public CurveInterpolationType Interpolation {
      get {
        return _interpolation;
      }
      set {
        if (_interpolation.Equals(value) != true) {
          _interpolation = value;
          OnPropertyChanged("Interpolation");
        }
      }
    }
  }

}
