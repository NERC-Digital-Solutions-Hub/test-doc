
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
// <complexType name="TinType">
//   <complexContent>
//     <extension base="gml:TriangulatedSurfaceType">
//       <sequence>
//         <element name="stopLines" type="gml:LineStringSegmentArrayPropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="breakLines" type="gml:LineStringSegmentArrayPropertyType" minOccurs="0" maxOccurs="unbounded"/>
//         <element name="maxLength" type="gml:LengthType"/>
//         <element name="controlPoint">
//           <complexType>
//             <choice>
//               <element ref="gml:posList"/>
//               <group ref="gml:geometricPositionGroup" minOccurs="3" maxOccurs="unbounded"/>
//             </choice>
//           </complexType>
//         </element>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Tin" type="gml:TinType" substitutionGroup="gml:TriangulatedSurface">
//   <annotation>
//     <documentation>
//       A tin is a triangulated surface that uses the Delaunay algorithm or a similar algorithm complemented
//       with consideration of stoplines (stopLines), breaklines (breakLines), and maximum length of triangle
//       sides (maxLength). controlPoint shall contain a set of the positions (three or more) used as posts for
//       this TIN (corners of the triangles in the TIN). See ISO 19107:2003, 6.4.39 for details.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Gml.Measures;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TinType")]
  public class TinType : TriangulatedSurfaceType {
    #region Private fields
    private List<LineStringSegmentArrayPropertyType> _stopLines;
    private List<LineStringSegmentArrayPropertyType> _breakLines;
    private LengthType _maxLength;
    private TinTypeControlPoint _controlPoint;
    #endregion

    /// <summary>
    /// TinType class constructor
    /// </summary>
    public TinType() {
      _controlPoint = new TinTypeControlPoint();
      _maxLength = new LengthType();
      _breakLines = new List<LineStringSegmentArrayPropertyType>();
      _stopLines = new List<LineStringSegmentArrayPropertyType>();
    }

    [XmlElement("stopLines", Order = 0)]
    [JsonProperty("stopLines", Order = 0)]
    public List<LineStringSegmentArrayPropertyType> StopLines {
      get {
        return _stopLines;
      }
      set {
        if (_stopLines == value) {
          return;
        }
        if (_stopLines == null || _stopLines.Equals(value) != true) {
          _stopLines = value;
          OnPropertyChanged("StopLines");
        }
      }
    }

    [XmlElement("breakLines", Order = 1)]
    [JsonProperty("breakLines", Order = 1)]
    public List<LineStringSegmentArrayPropertyType> BreakLines {
      get {
        return _breakLines;
      }
      set {
        if (_breakLines == value) {
          return;
        }
        if (_breakLines == null || _breakLines.Equals(value) != true) {
          _breakLines = value;
          OnPropertyChanged("BreakLines");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("maxLength", Order = 2)]
    public LengthType MaxLength {
      get {
        return _maxLength;
      }
      set {
        if (_maxLength == value) {
          return;
        }
        if (_maxLength == null || _maxLength.Equals(value) != true) {
          _maxLength = value;
          OnPropertyChanged("MaxLength");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("controlPoint", Order = 3)]
    public TinTypeControlPoint ControlPoint {
      get {
        return _controlPoint;
      }
      set {
        if (_controlPoint == value) {
          return;
        }
        if (_controlPoint == null || _controlPoint.Equals(value) != true) {
          _controlPoint = value;
          OnPropertyChanged("ControlPoint");
        }
      }
    }
  }

}
