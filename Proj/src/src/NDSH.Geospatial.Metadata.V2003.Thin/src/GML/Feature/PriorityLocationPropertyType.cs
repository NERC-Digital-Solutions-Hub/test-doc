
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PriorityLocationPropertyType")]
  public class PriorityLocationPropertyType : LocationPropertyType {
    #region Private fields
    private string _priority;
    #endregion

    [XmlAttribute]
    [JsonProperty("priority")]
    public string priority {
      get {
        return _priority;
      }
      set {
        if (_priority == value) {
          return;
        }
        if (_priority == null || _priority.Equals(value) != true) {
          _priority = value;
          OnPropertyChanged("priority");
        }
      }
    }
  }
}