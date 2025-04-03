
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D {


  /// <summary>
  /// gml:PointArrayPropertyType is a container for an array of points. The elements are always contained inline in the array property, referencing geometry elements or arrays of geometry elements via XLinks is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PointArrayPropertyType")]
  public class PointArrayPropertyType : Model {
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
    public bool owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("owns");
        }
      }
    }
  }
}
