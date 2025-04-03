
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coverage {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridFunctionType")]
  public class GridFunctionType : Model {
    #region Private fields
    private SequenceRuleType _sequenceRule;
    private string _startPoint;
    #endregion

    /// <summary>
    /// GridFunctionType class constructor
    /// </summary>
    public GridFunctionType() {
      _sequenceRule = new SequenceRuleType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("sequenceRule", Order = 0)]
    public SequenceRuleType sequenceRule {
      get {
        return _sequenceRule;
      }
      set {
        if (_sequenceRule == value) {
          return;
        }
        if (_sequenceRule == null || _sequenceRule.Equals(value) != true) {
          _sequenceRule = value;
          OnPropertyChanged("sequenceRule");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("startPoint", Order = 1)]
    public string startPoint {
      get {
        return _startPoint;
      }
      set {
        if (_startPoint == value) {
          return;
        }
        if (_startPoint == null || _startPoint.Equals(value) != true) {
          _startPoint = value;
          OnPropertyChanged("startPoint");
        }
      }
    }
  }
}