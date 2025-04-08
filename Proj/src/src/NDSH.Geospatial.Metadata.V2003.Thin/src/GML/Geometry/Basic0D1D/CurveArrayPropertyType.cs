
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
  /// A container for an array of curves. The elements are always contained in the array property, referencing geometry elements or arrays of geometry elements via XLinks is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CurveArrayPropertyType")]
  public class CurveArrayPropertyType : Model {
    #region Private fields
    private List<AbstractCurveType> _abstractCurve;
    private bool _owns;
    #endregion

    /// <summary>
    /// CurveArrayPropertyType class constructor
    /// </summary>
    public CurveArrayPropertyType() {
      _abstractCurve = new List<AbstractCurveType>();
      _owns = false;
    }

    [XmlElement("AbstractCurve", Order = 0)]
    [JsonProperty("AbstractCurve", Order = 0)]
    public List<AbstractCurveType> AbstractCurve {
      get {
        return _abstractCurve;
      }
      set {
        if (_abstractCurve == value) {
          return;
        }
        if (_abstractCurve == null || _abstractCurve.Equals(value) != true) {
          _abstractCurve = value;
          OnPropertyChanged("AbstractCurve");
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
