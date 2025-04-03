
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
// <complexType name="CurveSegmentArrayPropertyType">
//   <annotation>
//     <documentation>gml:CurveSegmentArrayPropertyType is a container for an array of curve segments.</documentation>
//   </annotation>
//   <sequence minOccurs="0" maxOccurs="unbounded">
//     <element ref="gml:AbstractCurveSegment"/>
//   </sequence>
// </complexType>
// <element name="segments" type="gml:CurveSegmentArrayPropertyType">
//   <annotation>
//     <documentation>
//       This property element contains a list of curve segments.
//       The order of the elements is significant and shall be preserved when processing the array.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// gml:CurveSegmentArrayPropertyType is a container for an array of curve segments.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CurveSegmentArrayPropertyType")]
  public class CurveSegmentArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractCurveSegmentType> _abstractCurveSegment;
    #endregion

    /// <summary>
    /// CurveSegmentArrayPropertyType class constructor
    /// </summary>
    public CurveSegmentArrayPropertyType() {
      _abstractCurveSegment = new List<AbstractCurveSegmentType>();
    }

    [XmlElement("AbstractCurveSegment", Order = 0)]
    [JsonProperty("AbstractCurveSegment", Order = 0)]
    public List<AbstractCurveSegmentType> AbstractCurveSegment {
      get {
        return _abstractCurveSegment;
      }
      set {
        if (_abstractCurveSegment == value) {
          return;
        }
        if (_abstractCurveSegment == null || _abstractCurveSegment.Equals(value) != true) {
          _abstractCurveSegment = value;
          OnPropertyChanged("AbstractCurveSegment");
        }
      }
    }
  }

}
