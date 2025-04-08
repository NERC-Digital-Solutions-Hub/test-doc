using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D;
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
  [JsonObject("OrientableSurfaceType")]
  public class OrientableSurfaceType : AbstractSurfaceType {
    #region Private fields
    private SurfacePropertyType _baseSurface;
    private SignType _orientation;
    #endregion

    /// <summary>
    /// OrientableSurfaceType class constructor
    /// </summary>
    public OrientableSurfaceType() {
      _baseSurface = new SurfacePropertyType();
      _orientation = SignType.Item1;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("baseSurface", Order = 0)]
    public SurfacePropertyType baseSurface {
      get {
        return _baseSurface;
      }
      set {
        if (_baseSurface == value) {
          return;
        }
        if (_baseSurface == null || _baseSurface.Equals(value) != true) {
          _baseSurface = value;
          OnPropertyChanged("baseSurface");
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
