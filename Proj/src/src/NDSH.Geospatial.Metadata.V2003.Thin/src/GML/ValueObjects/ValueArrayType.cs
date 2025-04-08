
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.ValueObjects {


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
    public string codeSpace {
      get {
        return _codeSpace;
      }
      set {
        if (_codeSpace == value) {
          return;
        }
        if (_codeSpace == null || _codeSpace.Equals(value) != true) {
          _codeSpace = value;
          OnPropertyChanged("codeSpace");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("uom")]
    public string uom {
      get {
        return _uom;
      }
      set {
        if (_uom == value) {
          return;
        }
        if (_uom == null || _uom.Equals(value) != true) {
          _uom = value;
          OnPropertyChanged("uom");
        }
      }
    }
  }
}