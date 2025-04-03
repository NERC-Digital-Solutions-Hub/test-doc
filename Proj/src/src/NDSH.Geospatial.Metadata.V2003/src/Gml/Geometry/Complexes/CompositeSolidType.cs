using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Complexes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompositeSolidType")]
  public class CompositeSolidType : AbstractSolidType {
    #region Private fields
    private List<SolidPropertyType> _solidMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// CompositeSolidType class constructor
    /// </summary>
    public CompositeSolidType() {
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

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }
  }
}
