using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PriorityLocationPropertyType")]
  public class PriorityLocationPropertyType : LocationPropertyType {
    #region Private fields
    private string _priority;
    #endregion

    [XmlAttribute]
    [JsonProperty("priority")]
    public string Priority {
      get {
        return _priority;
      }
      set {
        if (_priority == value) {
          return;
        }
        if (_priority == null || _priority.Equals(value) != true) {
          _priority = value;
          OnPropertyChanged("Priority");
        }
      }
    }
  }
}
