
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PolygonType")]
  public class PolygonType : AbstractSurfaceType {
    #region Private fields
    private AbstractRingPropertyType _exterior;
    private List<AbstractRingPropertyType> _interior;
    #endregion

    /// <summary>
    /// PolygonType class constructor
    /// </summary>
    public PolygonType() {
      _interior = new List<AbstractRingPropertyType>();
      _exterior = new AbstractRingPropertyType();
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

    [XmlElement("interior", Order = 1)]
    [JsonProperty("interior", Order = 1)]
    public List<AbstractRingPropertyType> interior {
      get {
        return _interior;
      }
      set {
        if (_interior == value) {
          return;
        }
        if (_interior == null || _interior.Equals(value) != true) {
          _interior = value;
          OnPropertyChanged("interior");
        }
      }
    }
  }
}
