
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using NDSH.Geospatial.Metadata.V2003.Gml.GmlBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Dictionary {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DictionaryEntryType")]
  public class DictionaryEntryType : AbstractMemberType {
    #region Private fields
    private DefinitionType _definition;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// DictionaryEntryType class constructor
    /// </summary>
    public DictionaryEntryType() {
      _definition = new DefinitionType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Definition", Order = 0)]
    public DefinitionType Definition {
      get {
        return _definition;
      }
      set {
        if (_definition == value) {
          return;
        }
        if (_definition == null || _definition.Equals(value) != true) {
          _definition = value;
          OnPropertyChanged("Definition");
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
