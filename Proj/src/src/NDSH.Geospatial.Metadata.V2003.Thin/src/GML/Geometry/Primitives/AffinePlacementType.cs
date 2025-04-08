using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
  [JsonObject("AffinePlacementType")]
  public class AffinePlacementType : Model {
    #region Private fields
    private DirectPositionType _location;
    private List<VectorType> _refDirection;
    private string _inDimension;
    private string _outDimension;
    #endregion

    /// <summary>
    /// AffinePlacementType class constructor
    /// </summary>
    public AffinePlacementType() {
      _refDirection = new List<VectorType>();
      _location = new DirectPositionType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("location", Order = 0)]
    public DirectPositionType location {
      get {
        return _location;
      }
      set {
        if (_location == value) {
          return;
        }
        if (_location == null || _location.Equals(value) != true) {
          _location = value;
          OnPropertyChanged("location");
        }
      }
    }

    [XmlElement("refDirection", Order = 1)]
    [JsonProperty("refDirection", Order = 1)]
    public List<VectorType> refDirection {
      get {
        return _refDirection;
      }
      set {
        if (_refDirection == value) {
          return;
        }
        if (_refDirection == null || _refDirection.Equals(value) != true) {
          _refDirection = value;
          OnPropertyChanged("refDirection");
        }
      }
    }

    [XmlElement(DataType = "positiveInteger", Order = 2)]
    [JsonProperty("inDimension", Order = 2)]
    public string inDimension {
      get {
        return _inDimension;
      }
      set {
        if (_inDimension == value) {
          return;
        }
        if (_inDimension == null || _inDimension.Equals(value) != true) {
          _inDimension = value;
          OnPropertyChanged("inDimension");
        }
      }
    }

    [XmlElement(DataType = "positiveInteger", Order = 3)]
    [JsonProperty("outDimension", Order = 3)]
    public string outDimension {
      get {
        return _outDimension;
      }
      set {
        if (_outDimension == value) {
          return;
        }
        if (_outDimension == null || _outDimension.Equals(value) != true) {
          _outDimension = value;
          OnPropertyChanged("outDimension");
        }
      }
    }
  }

}
