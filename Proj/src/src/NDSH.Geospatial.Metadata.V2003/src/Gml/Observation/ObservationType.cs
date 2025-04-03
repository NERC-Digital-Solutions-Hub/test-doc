using NDSH.Geospatial.Metadata.V2003.Gml.Feature;
using NDSH.Geospatial.Metadata.V2003.Gml.Temporal;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Observation {


  [XmlInclude(typeof(DirectedObservationType))]
  [XmlInclude(typeof(DirectedObservationAtDistanceType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ObservationType")]
  public class ObservationType : AbstractFeatureType {
    #region Private fields
    private TimePrimitivePropertyType _validTime;
    private ProcedurePropertyType _using;
    private TargetPropertyType _target;
    private ResultType _resultOf;
    #endregion

    /// <summary>
    /// ObservationType class constructor
    /// </summary>
    public ObservationType() {
      _resultOf = new ResultType();
      _target = new TargetPropertyType();
      _using = new ProcedurePropertyType();
      _validTime = new TimePrimitivePropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("validTime", Order = 0)]
    public TimePrimitivePropertyType ValidTime {
      get {
        return _validTime;
      }
      set {
        if (_validTime == value) {
          return;
        }
        if (_validTime == null || _validTime.Equals(value) != true) {
          _validTime = value;
          OnPropertyChanged("ValidTime");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("using", Order = 1)]
    public ProcedurePropertyType Using {
      get {
        return _using;
      }
      set {
        if (_using == value) {
          return;
        }
        if (_using == null || _using.Equals(value) != true) {
          _using = value;
          OnPropertyChanged("Using");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("target", Order = 2)]
    public TargetPropertyType Target {
      get {
        return _target;
      }
      set {
        if (_target == value) {
          return;
        }
        if (_target == null || _target.Equals(value) != true) {
          _target = value;
          OnPropertyChanged("Target");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("resultOf", Order = 3)]
    public ResultType ResultOf {
      get {
        return _resultOf;
      }
      set {
        if (_resultOf == value) {
          return;
        }
        if (_resultOf == null || _resultOf.Equals(value) != true) {
          _resultOf = value;
          OnPropertyChanged("ResultOf");
        }
      }
    }
  }
}
