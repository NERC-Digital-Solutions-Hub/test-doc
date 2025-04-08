
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Observation {


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
    public TimePrimitivePropertyType validTime {
      get {
        return _validTime;
      }
      set {
        if (_validTime == value) {
          return;
        }
        if (_validTime == null || _validTime.Equals(value) != true) {
          _validTime = value;
          OnPropertyChanged("validTime");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("using", Order = 1)]
    public ProcedurePropertyType @using {
      get {
        return _using;
      }
      set {
        if (_using == value) {
          return;
        }
        if (_using == null || _using.Equals(value) != true) {
          _using = value;
          OnPropertyChanged("using");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("target", Order = 2)]
    public TargetPropertyType target {
      get {
        return _target;
      }
      set {
        if (_target == value) {
          return;
        }
        if (_target == null || _target.Equals(value) != true) {
          _target = value;
          OnPropertyChanged("target");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("resultOf", Order = 3)]
    public ResultType resultOf {
      get {
        return _resultOf;
      }
      set {
        if (_resultOf == value) {
          return;
        }
        if (_resultOf == null || _resultOf.Equals(value) != true) {
          _resultOf = value;
          OnPropertyChanged("resultOf");
        }
      }
    }
  }
}