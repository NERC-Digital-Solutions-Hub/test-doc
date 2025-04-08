using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Temporal.Topology {


  [XmlInclude(typeof(TimeEdgeType))]
  [XmlInclude(typeof(TimeNodeType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTimeTopologyPrimitiveType")]
  public abstract class AbstractTimeTopologyPrimitiveType : AbstractTimePrimitiveType {
    #region Private fields
    private ReferenceType _complex;
    #endregion

    /// <summary>
    /// AbstractTimeTopologyPrimitiveType class constructor
    /// </summary>
    public AbstractTimeTopologyPrimitiveType() {
      _complex = new ReferenceType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("complex", Order = 0)]
    public ReferenceType Complex {
      get {
        return _complex;
      }
      set {
        if (_complex == value) {
          return;
        }
        if (_complex == null || _complex.Equals(value) != true) {
          _complex = value;
          OnPropertyChanged("Complex");
        }
      }
    }
  }

}
