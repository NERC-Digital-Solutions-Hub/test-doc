
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoPrimitiveMemberType")]
  public class TopoPrimitiveMemberType : Model {
    #region Private fields
    private AbstractTopoPrimitiveType _abstractTopoPrimitive;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoPrimitiveMemberType class constructor
    /// </summary>
    public TopoPrimitiveMemberType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractTopoPrimitive", Order = 0)]
    public AbstractTopoPrimitiveType AbstractTopoPrimitive {
      get {
        return _abstractTopoPrimitive;
      }
      set {
        if (_abstractTopoPrimitive == value) {
          return;
        }
        if (_abstractTopoPrimitive == null || _abstractTopoPrimitive.Equals(value) != true) {
          _abstractTopoPrimitive = value;
          OnPropertyChanged("AbstractTopoPrimitive");
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

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("owns");
        }
      }
    }
  }
}