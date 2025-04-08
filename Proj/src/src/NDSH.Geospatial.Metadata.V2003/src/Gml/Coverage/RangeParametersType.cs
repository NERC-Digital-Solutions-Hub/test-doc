
#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coverage {

  /// <summary>
  /// gml:RangeParameterType is a framework for the description of the range parameters each of which is a gml:AbstractValue.  Specific range parameters are defined through the creation of a GML Application Schema that provides elements that are substitutable for gml:AbstractValue.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RangeParametersType")]
  public class RangeParametersType : ObservableModel {

    #region Private fields
    private object _abstractValue;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// RangeParametersType class constructor
    /// </summary>
    public RangeParametersType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractValue", Order = 0)]
    public object AbstractValue {
      get {
        return _abstractValue;
      }
      set {
        if (_abstractValue == value) {
          return;
        }
        if (_abstractValue == null || _abstractValue.Equals(value) != true) {
          _abstractValue = value;
          OnPropertyChanged("AbstractValue");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
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
