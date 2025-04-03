
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology
{


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoSolidType")]
  public class TopoSolidType : AbstractTopoPrimitiveType {
    #region Private fields
    private List<DirectedFacePropertyType> _directedFace;
    private SolidPropertyType _solidProperty;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// TopoSolidType class constructor
    /// </summary>
    public TopoSolidType() {
      _solidProperty = new SolidPropertyType();
      _directedFace = new List<DirectedFacePropertyType>();
    }

    [XmlElement("directedFace", Order = 0)]
    [JsonProperty("directedFace", Order = 0)]
    public List<DirectedFacePropertyType> directedFace {
      get {
        return _directedFace;
      }
      set {
        if (_directedFace == value) {
          return;
        }
        if (_directedFace == null || _directedFace.Equals(value) != true) {
          _directedFace = value;
          OnPropertyChanged("directedFace");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("solidProperty", Order = 1)]
    public SolidPropertyType solidProperty {
      get {
        return _solidProperty;
      }
      set {
        if (_solidProperty == value) {
          return;
        }
        if (_solidProperty == null || _solidProperty.Equals(value) != true) {
          _solidProperty = value;
          OnPropertyChanged("solidProperty");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType aggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("aggregationType");
        }
      }
    }
  }
}