
#region Imported Namespaces

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.ValueObjects {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ValueArrayType")]
  public class ValueArrayType : CompositeValueType {

    #region Private fields
    private string _codeSpace;
    private string _uom;
    #endregion

    [XmlAttribute(DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    public string CodeSpace {
      get {
        return _codeSpace;
      }
      set {
        if (_codeSpace == value) {
          return;
        }
        if (_codeSpace == null || _codeSpace.Equals(value) != true) {
          _codeSpace = value;
          OnPropertyChanged("CodeSpace");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("uom")]
    public string Uom {
      get {
        return _uom;
      }
      set {
        if (_uom == value) {
          return;
        }
        if (_uom == null || _uom.Equals(value) != true) {
          _uom = value;
          OnPropertyChanged("Uom");
        }
      }
    }

  }

}
