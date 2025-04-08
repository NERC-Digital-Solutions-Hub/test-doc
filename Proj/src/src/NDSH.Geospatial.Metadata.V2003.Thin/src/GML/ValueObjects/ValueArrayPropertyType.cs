
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.ValueObjects
{




  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ValueArrayPropertyType")]
  public class ValueArrayPropertyType : Model {
    #region Private fields
    private List<object> _items;
    private bool _owns;
    #endregion

    /// <summary>
    /// ValueArrayPropertyType class constructor
    /// </summary>
    public ValueArrayPropertyType() {
      _items = new List<object>();
      _owns = false;
    }

    [XmlElement("AbstractGeometry", typeof(AbstractGeometryType), Order = 0)]
    [XmlElement("AbstractTimeObject", typeof(AbstractTimeObjectType), Order = 0)]
    [XmlElement("AbstractValue", typeof(object), Order = 0)]
    [XmlElement("Null", typeof(string), Order = 0)]
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

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("owns");
        }
      }
    }
  }
}