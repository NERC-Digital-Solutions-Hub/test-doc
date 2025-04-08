using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Feature {


  [XmlInclude(typeof(FeatureCollectionType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractFeatureCollectionType")]
  public abstract class AbstractFeatureCollectionType : AbstractFeatureType {
    #region Private fields
    private List<FeaturePropertyType> _featureMember;
    private FeatureArrayPropertyType _featureMembers;
    #endregion

    /// <summary>
    /// AbstractFeatureCollectionType class constructor
    /// </summary>
    public AbstractFeatureCollectionType() {
      _featureMembers = new FeatureArrayPropertyType();
      _featureMember = new List<FeaturePropertyType>();
    }

    [XmlElement("featureMember", Order = 0)]
    [JsonProperty("featureMember", Order = 0)]
    public List<FeaturePropertyType> FeatureMember {
      get {
        return _featureMember;
      }
      set {
        if (_featureMember == value) {
          return;
        }
        if (_featureMember == null || _featureMember.Equals(value) != true) {
          _featureMember = value;
          OnPropertyChanged("FeatureMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("featureMembers", Order = 1)]
    public FeatureArrayPropertyType FeatureMembers {
      get {
        return _featureMembers;
      }
      set {
        if (_featureMembers == value) {
          return;
        }
        if (_featureMembers == null || _featureMembers.Equals(value) != true) {
          _featureMembers = value;
          OnPropertyChanged("FeatureMembers");
        }
      }
    }
  }
}
