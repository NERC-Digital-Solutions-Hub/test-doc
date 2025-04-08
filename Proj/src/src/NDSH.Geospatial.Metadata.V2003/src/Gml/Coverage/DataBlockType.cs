
#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes;
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
  [JsonObject("DataBlockType")]
  public class DataBlockType : ObservableModel {

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
    public RangeParametersType RangeParameters {
      get {
        return _rangeParameters;
      }
      set {
        if (_rangeParameters == value) {
          return;
        }
        if (_rangeParameters == null || _rangeParameters.Equals(value) != true) {
          _rangeParameters = value;
          OnPropertyChanged("RangeParameters");
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
