
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.ValueObjects;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coverage {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RangeSetType")]
  public class RangeSetType : Model {
    #region Private fields
    private List<object> _items;
    #endregion

    /// <summary>
    /// RangeSetType class constructor
    /// </summary>
    public RangeSetType() {
      _items = new List<object>();
    }

    [XmlElement("AbstractScalarValueList", typeof(object), Order = 0)]
    [XmlElement("DataBlock", typeof(DataBlockType), Order = 0)]
    [XmlElement("File", typeof(FileType), Order = 0)]
    [XmlElement("ValueArray", typeof(ValueArrayType), Order = 0)]
    public List<object> Items {
      get {
        return _items;
      }
      set {
        if (_items == value) {
          return;
        }
        if (_items == null || _items.Equals(value) != true) {
          _items = value;
          OnPropertyChanged("Items");
        }
      }
    }
  }
}