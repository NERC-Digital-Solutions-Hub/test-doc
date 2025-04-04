﻿using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// gml:LineStringSegmentArrayPropertyType provides a container for line strings.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("LineStringSegmentArrayPropertyType")]
  public class LineStringSegmentArrayPropertyType : ObservableModel {
    #region Private fields
    private List<LineStringSegmentType> _lineStringSegment;
    #endregion

    /// <summary>
    /// LineStringSegmentArrayPropertyType class constructor
    /// </summary>
    public LineStringSegmentArrayPropertyType() {
      _lineStringSegment = new List<LineStringSegmentType>();
    }

    [XmlElement("LineStringSegment", Order = 0)]
    [JsonProperty("LineStringSegment", Order = 0)]
    public List<LineStringSegmentType> LineStringSegment {
      get {
        return _lineStringSegment;
      }
      set {
        if (_lineStringSegment == value) {
          return;
        }
        if (_lineStringSegment == null || _lineStringSegment.Equals(value) != true) {
          _lineStringSegment = value;
          OnPropertyChanged("LineStringSegment");
        }
      }
    }
  }

}
