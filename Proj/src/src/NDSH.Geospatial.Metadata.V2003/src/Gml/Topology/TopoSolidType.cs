
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

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
    public List<DirectedFacePropertyType> DirectedFace {
      get {
        return _directedFace;
      }
      set {
        if (_directedFace == value) {
          return;
        }
        if (_directedFace == null || _directedFace.Equals(value) != true) {
          _directedFace = value;
          OnPropertyChanged("DirectedFace");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("solidProperty", Order = 1)]
    public SolidPropertyType SolidProperty {
      get {
        return _solidProperty;
      }
      set {
        if (_solidProperty == value) {
          return;
        }
        if (_solidProperty == null || _solidProperty.Equals(value) != true) {
          _solidProperty = value;
          OnPropertyChanged("SolidProperty");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }

  }

}
