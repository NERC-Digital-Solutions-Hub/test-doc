
#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.ValueObjects;
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
  [JsonObject("RangeSetType")]
  public class RangeSetType : ObservableModel {

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
