
#region Imported Namespaces

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [XmlInclude(typeof(TopoSolidType))]
  [XmlInclude(typeof(NodeType))]
  [XmlInclude(typeof(EdgeType))]
  [XmlInclude(typeof(FaceType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractTopoPrimitiveType")]
  public abstract class AbstractTopoPrimitiveType : AbstractTopologyType {

    #region Private fields
    private List<IsolatedPropertyType> _isolated;
    private ContainerPropertyType _container;
    #endregion

    /// <summary>
    /// AbstractTopoPrimitiveType class constructor
    /// </summary>
    public AbstractTopoPrimitiveType() {
      _container = new ContainerPropertyType();
      _isolated = new List<IsolatedPropertyType>();
    }

    [XmlElement("isolated", Order = 0)]
    [JsonProperty("isolated", Order = 0)]
    public List<IsolatedPropertyType> Isolated {
      get {
        return _isolated;
      }
      set {
        if (_isolated == value) {
          return;
        }
        if (_isolated == null || _isolated.Equals(value) != true) {
          _isolated = value;
          OnPropertyChanged("Isolated");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("container", Order = 1)]
    public ContainerPropertyType Container {
      get {
        return _container;
      }
      set {
        if (_container == value) {
          return;
        }
        if (_container == null || _container.Equals(value) != true) {
          _container = value;
          OnPropertyChanged("Container");
        }
      }
    }

  }

}
