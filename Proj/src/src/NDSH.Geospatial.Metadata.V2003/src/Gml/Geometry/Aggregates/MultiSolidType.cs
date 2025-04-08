using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Aggregates {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiSolidType")]
  public class MultiSolidType : AbstractGeometricAggregateType {
    #region Private fields
    private List<SolidPropertyType> _solidMember;
    private SolidArrayPropertyType _solidMembers;
    #endregion

    /// <summary>
    /// MultiSolidType class constructor
    /// </summary>
    public MultiSolidType() {
      _solidMembers = new SolidArrayPropertyType();
      _solidMember = new List<SolidPropertyType>();
    }

    [XmlElement("solidMember", Order = 0)]
    [JsonProperty("solidMember", Order = 0)]
    public List<SolidPropertyType> SolidMember {
      get {
        return _solidMember;
      }
      set {
        if (_solidMember == value) {
          return;
        }
        if (_solidMember == null || _solidMember.Equals(value) != true) {
          _solidMember = value;
          OnPropertyChanged("SolidMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("solidMembers", Order = 1)]
    public SolidArrayPropertyType SolidMembers {
      get {
        return _solidMembers;
      }
      set {
        if (_solidMembers == value) {
          return;
        }
        if (_solidMembers == null || _solidMembers.Equals(value) != true) {
          _solidMembers = value;
          OnPropertyChanged("SolidMembers");
        }
      }
    }
  }
}
