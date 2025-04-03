
#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coverage {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridFunctionType")]
  public class GridFunctionType : ObservableModel {

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
    public SequenceRuleType SequenceRule {
      get {
        return _sequenceRule;
      }
      set {
        if (_sequenceRule == value) {
          return;
        }
        if (_sequenceRule == null || _sequenceRule.Equals(value) != true) {
          _sequenceRule = value;
          OnPropertyChanged("SequenceRule");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("startPoint", Order = 1)]
    public string StartPoint {
      get {
        return _startPoint;
      }
      set {
        if (_startPoint == value) {
          return;
        }
        if (_startPoint == null || _startPoint.Equals(value) != true) {
          _startPoint = value;
          OnPropertyChanged("StartPoint");
        }
      }
    }

  }

}
