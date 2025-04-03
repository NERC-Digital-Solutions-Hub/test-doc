using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal {

  [XmlInclude(typeof(TimePeriodType))]
  [XmlInclude(typeof(TimeInstantType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeGeometricPrimitiveType")]
  public abstract class AbstractTimeGeometricPrimitiveType : AbstractTimePrimitiveType {
    #region Private fields
    private string _frame;
    #endregion

    /// <summary>
    /// AbstractTimeGeometricPrimitiveType class constructor
    /// </summary>
    public AbstractTimeGeometricPrimitiveType() {
      _frame = "#ISO-8601";
    }

    [XmlAttribute(DataType = "anyURI")]
    [DefaultValue("#ISO-8601")]
    [JsonProperty("frame")]
    public string frame {
      get {
        return _frame;
      }
      set {
        if (_frame == value) {
          return;
        }
        if (_frame == null || _frame.Equals(value) != true) {
          _frame = value;
          OnPropertyChanged("frame");
        }
      }
    }
  }

}
