using NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Aggregates {


  [XmlInclude(typeof(MultiSolidType))]
  [XmlInclude(typeof(MultiSurfaceType))]
  [XmlInclude(typeof(MultiCurveType))]
  [XmlInclude(typeof(MultiPointType))]
  [XmlInclude(typeof(MultiGeometryType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeometricAggregateType")]
  public abstract class AbstractGeometricAggregateType : AbstractGeometryType {
    #region Private fields
    private AggregationType _aggregationType;
    #endregion

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
