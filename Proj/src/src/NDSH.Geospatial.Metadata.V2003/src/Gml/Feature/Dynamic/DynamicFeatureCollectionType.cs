using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature.Dynamic {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DynamicFeatureCollectionType")]
  public class DynamicFeatureCollectionType : DynamicFeatureType {
    #region Private fields
    private DynamicFeatureMemberType _dynamicMembers;
    #endregion

    /// <summary>
    /// DynamicFeatureCollectionType class constructor
    /// </summary>
    public DynamicFeatureCollectionType() {
      _dynamicMembers = default; // new DynamicFeatureMemberType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("dynamicMembers", Order = 0)]
    public DynamicFeatureMemberType DynamicMembers {
      get {
        return _dynamicMembers;
      }
      set {
        if (_dynamicMembers == value) {
          return;
        }
        if (_dynamicMembers == null || _dynamicMembers.Equals(value) != true) {
          _dynamicMembers = value;
          OnPropertyChanged("DynamicMembers");
        }
      }
    }
  }

}
