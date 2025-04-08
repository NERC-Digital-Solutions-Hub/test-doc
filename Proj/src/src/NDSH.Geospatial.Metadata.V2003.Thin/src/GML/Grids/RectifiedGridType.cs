
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Grids
{


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RectifiedGridType")]
  public class RectifiedGridType : GridType {
    #region Private fields
    private PointPropertyType _origin;
    private List<VectorType> _offsetVector;
    #endregion

    /// <summary>
    /// RectifiedGridType class constructor
    /// </summary>
    public RectifiedGridType() {
      _offsetVector = new List<VectorType>();
      _origin = new PointPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("origin", Order = 0)]
    public PointPropertyType origin {
      get {
        return _origin;
      }
      set {
        if (_origin == value) {
          return;
        }
        if (_origin == null || _origin.Equals(value) != true) {
          _origin = value;
          OnPropertyChanged("origin");
        }
      }
    }

    [XmlElement("offsetVector", Order = 1)]
    [JsonProperty("offsetVector", Order = 1)]
    public List<VectorType> offsetVector {
      get {
        return _offsetVector;
      }
      set {
        if (_offsetVector == value) {
          return;
        }
        if (_offsetVector == null || _offsetVector.Equals(value) != true) {
          _offsetVector = value;
          OnPropertyChanged("offsetVector");
        }
      }
    }
  }
}