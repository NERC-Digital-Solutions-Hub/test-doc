
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

  /// <summary>
  /// The gml:SequenceRuleType is derived from the gml:SequenceRuleEnumeration through the addition of an axisOrder attribute.  The gml:SequenceRuleEnumeration is an enumerated type. The rule names are defined in ISO 19123. If no rule name is specified the default is “Linear”.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SequenceRuleType")]
  public class SequenceRuleType : ObservableModel {

    #region Private fields
    private IncrementOrder _order;
    private List<string> _axisOrder;
    private SequenceRuleEnumeration _value;
    #endregion

    /// <summary>
    /// SequenceRuleType class constructor
    /// </summary>
    public SequenceRuleType() {
      _axisOrder = new List<string>();
    }

    [XmlAttribute]
    [JsonProperty("order")]
    public IncrementOrder Order {
      get {
        return _order;
      }
      set {
        if (_order.Equals(value) != true) {
          _order = value;
          OnPropertyChanged("Order");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("axisOrder")]
    public List<string> AxisOrder {
      get {
        return _axisOrder;
      }
      set {
        if (_axisOrder == value) {
          return;
        }
        if (_axisOrder == null || _axisOrder.Equals(value) != true) {
          _axisOrder = value;
          OnPropertyChanged("AxisOrder");
        }
      }
    }

    [XmlTextAttribute]
    [JsonProperty("Value")]
    public SequenceRuleEnumeration Value {
      get {
        return _value;
      }
      set {
        if (_value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged("Value");
        }
      }
    }

  }

}
