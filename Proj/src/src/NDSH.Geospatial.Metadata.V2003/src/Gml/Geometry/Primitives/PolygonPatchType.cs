﻿
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PolygonPatchType")]
  public class PolygonPatchType : AbstractSurfacePatchType {
    #region Private fields
    private AbstractRingPropertyType _exterior;
    private List<AbstractRingPropertyType> _interior;
    private SurfaceInterpolationType _interpolation;
    #endregion

    /// <summary>
    /// PolygonPatchType class constructor
    /// </summary>
    public PolygonPatchType() {
      _interior = new List<AbstractRingPropertyType>();
      _exterior = new AbstractRingPropertyType();
      _interpolation = SurfaceInterpolationType.planar;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("exterior", Order = 0)]
    public AbstractRingPropertyType Exterior {
      get {
        return _exterior;
      }
      set {
        if (_exterior == value) {
          return;
        }
        if (_exterior == null || _exterior.Equals(value) != true) {
          _exterior = value;
          OnPropertyChanged("Exterior");
        }
      }
    }

    [XmlElement("interior", Order = 1)]
    [JsonProperty("interior", Order = 1)]
    public List<AbstractRingPropertyType> Interior {
      get {
        return _interior;
      }
      set {
        if (_interior == value) {
          return;
        }
        if (_interior == null || _interior.Equals(value) != true) {
          _interior = value;
          OnPropertyChanged("Interior");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("interpolation")]
    public SurfaceInterpolationType interpolation {
      get {
        return _interpolation;
      }
      set {
        if (_interpolation.Equals(value) != true) {
          _interpolation = value;
          OnPropertyChanged("interpolation");
        }
      }
    }
  }

}
