
using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("FeatureArrayPropertyType")]
  public class FeatureArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractFeatureType> _abstractFeature;
    #endregion

    /// <summary>
    /// FeatureArrayPropertyType class constructor
    /// </summary>
    public FeatureArrayPropertyType() {
      _abstractFeature = new List<AbstractFeatureType>();
    }

    [XmlElement("AbstractFeature", Order = 0)]
    [JsonProperty("AbstractFeature", Order = 0)]
    public List<AbstractFeatureType> AbstractFeature {
      get {
        return _abstractFeature;
      }
      set {
        if (_abstractFeature == value) {
          return;
        }
        if (_abstractFeature == null || _abstractFeature.Equals(value) != true) {
          _abstractFeature = value;
          OnPropertyChanged("AbstractFeature");
        }
      }
    }
  }
}
