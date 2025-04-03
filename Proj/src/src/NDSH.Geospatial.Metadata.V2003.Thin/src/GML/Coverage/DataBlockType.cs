
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coverage {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DataBlockType")]
  public class DataBlockType : Model {
    #region Private fields
    private RangeParametersType _rangeParameters;
    private object _item;
    #endregion

    /// <summary>
    /// DataBlockType class constructor
    /// </summary>
    public DataBlockType() {
      _rangeParameters = new RangeParametersType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("rangeParameters", Order = 0)]
    public RangeParametersType rangeParameters {
      get {
        return _rangeParameters;
      }
      set {
        if (_rangeParameters == value) {
          return;
        }
        if (_rangeParameters == null || _rangeParameters.Equals(value) != true) {
          _rangeParameters = value;
          OnPropertyChanged("rangeParameters");
        }
      }
    }

    [XmlElement("doubleOrNilReasonTupleList", typeof(string), Order = 1)]
    [XmlElement("tupleList", typeof(CoordinatesType), Order = 1)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }
  }
}