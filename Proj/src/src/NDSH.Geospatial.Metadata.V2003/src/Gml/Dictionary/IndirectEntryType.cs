
using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Dictionary {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("IndirectEntryType")]
  public class IndirectEntryType : ObservableModel {
    #region Private fields
    private DefinitionProxyType _definitionProxy;
    #endregion

    /// <summary>
    /// IndirectEntryType class constructor
    /// </summary>
    public IndirectEntryType() {
      _definitionProxy = new DefinitionProxyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("DefinitionProxy", Order = 0)]
    public DefinitionProxyType DefinitionProxy {
      get {
        return _definitionProxy;
      }
      set {
        if (_definitionProxy == value) {
          return;
        }
        if (_definitionProxy == null || _definitionProxy.Equals(value) != true) {
          _definitionProxy = value;
          OnPropertyChanged("DefinitionProxy");
        }
      }
    }
  }
}
