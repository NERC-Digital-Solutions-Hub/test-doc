
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RectangleType")]
  public class RectangleType : AbstractSurfacePatchType {
    #region Private fields
    private AbstractRingPropertyType _exterior;
    private SurfaceInterpolationType _interpolation;
    #endregion

    /// <summary>
    /// RectangleType class constructor
    /// </summary>
    public RectangleType() {
      _exterior = new AbstractRingPropertyType();
      _interpolation = SurfaceInterpolationType.planar;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("exterior", Order = 0)]
    public AbstractRingPropertyType exterior {
      get {
        return _exterior;
      }
      set {
        if (_exterior == value) {
          return;
        }
        if (_exterior == null || _exterior.Equals(value) != true) {
          _exterior = value;
          OnPropertyChanged("exterior");
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
