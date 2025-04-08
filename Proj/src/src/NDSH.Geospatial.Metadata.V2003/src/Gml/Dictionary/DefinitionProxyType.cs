using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Dictionary {






  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DefinitionProxyType")]
  public class DefinitionProxyType : DefinitionType {
    #region Private fields
    private ReferenceType _definitionRef;
    #endregion

    /// <summary>
    /// DefinitionProxyType class constructor
    /// </summary>
    public DefinitionProxyType() {
      _definitionRef = new ReferenceType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("definitionRef", Order = 0)]
    public ReferenceType DefinitionRef {
      get {
        return _definitionRef;
      }
      set {
        if (_definitionRef == value) {
          return;
        }
        if (_definitionRef == null || _definitionRef.Equals(value) != true) {
          _definitionRef = value;
          OnPropertyChanged("DefinitionRef");
        }
      }
    }
  }
}
