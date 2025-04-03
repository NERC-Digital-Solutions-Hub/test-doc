
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Operations {

  /// <summary>
  /// gml:OperationMethodPropertyType is a property type for association roles to a concrete general-purpose
  /// operation method, either referencing or containing the definition of that method.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationMethodPropertyType")]
  public class OperationMethodPropertyType : ObservableModel {

    #region Private fields
    private OperationMethodType _operationMethod;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// OperationMethodPropertyType class constructor
    /// </summary>
    public OperationMethodPropertyType() {
      _operationMethod = new OperationMethodType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("OperationMethod", Order = 0)]
    public OperationMethodType OperationMethod {
      get {
        return _operationMethod;
      }
      set {
        if (_operationMethod == value) {
          return;
        }
        if (_operationMethod == null || _operationMethod.Equals(value) != true) {
          _operationMethod = value;
          OnPropertyChanged("OperationMethod");
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
