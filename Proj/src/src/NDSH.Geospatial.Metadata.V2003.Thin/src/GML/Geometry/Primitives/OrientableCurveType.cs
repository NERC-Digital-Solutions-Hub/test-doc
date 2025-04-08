using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OrientableCurveType")]
  public class OrientableCurveType : AbstractCurveType {
    #region Private fields
    private CurvePropertyType _baseCurve;
    private SignType _orientation;
    #endregion

    /// <summary>
    /// OrientableCurveType class constructor
    /// </summary>
    public OrientableCurveType() {
      _baseCurve = new CurvePropertyType();
      _orientation = SignType.Item1;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("baseCurve", Order = 0)]
    public CurvePropertyType baseCurve {
      get {
        return _baseCurve;
      }
      set {
        if (_baseCurve == value) {
          return;
        }
        if (_baseCurve == null || _baseCurve.Equals(value) != true) {
          _baseCurve = value;
          OnPropertyChanged("baseCurve");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(SignType.Item1)]
    [JsonProperty("orientation")]
    public SignType orientation {
      get {
        return _orientation;
      }
      set {
        if (_orientation.Equals(value) != true) {
          _orientation = value;
          OnPropertyChanged("orientation");
        }
      }
    }
  }

}
