
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
  [JsonObject("CountPropertyType")]
  public class CountPropertyType : Model {
    #region Private fields
    private Count _count;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// CountPropertyType class constructor
    /// </summary>
    public CountPropertyType() {
      _count = new Count();
    }

    [XmlElement(IsNullable = true, Order = 0)]
    [JsonProperty("Count", Order = 0)]
    public Count Count {
      get {
        return _count;
      }
      set {
        if (_count == value) {
          return;
        }
        if (_count == null || _count.Equals(value) != true) {
          _count = value;
          OnPropertyChanged("Count");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string nilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("nilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string remoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("remoteSchema");
        }
      }
    }
  }
}