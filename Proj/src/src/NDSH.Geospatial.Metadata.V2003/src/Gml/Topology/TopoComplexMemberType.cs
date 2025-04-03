
#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Topology {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoComplexMemberType")]
  public class TopoComplexMemberType : ObservableModel {

    #region Private fields
    private TopoComplexType _topoComplex;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TopoComplexMemberType class constructor
    /// </summary>
    public TopoComplexMemberType() {
      _topoComplex = new TopoComplexType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TopoComplex", Order = 0)]
    public TopoComplexType TopoComplex {
      get {
        return _topoComplex;
      }
      set {
        if (_topoComplex == value) {
          return;
        }
        if (_topoComplex == null || _topoComplex.Equals(value) != true) {
          _topoComplex = value;
          OnPropertyChanged("TopoComplex");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("RemoteSchema");
        }
      }
    }

  }

}
