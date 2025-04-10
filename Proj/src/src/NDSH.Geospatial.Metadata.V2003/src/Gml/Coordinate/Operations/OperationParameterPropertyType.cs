
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
  /// gml:OperationParameterPropertyType is a property type for association roles to an operation parameter, either referencing or containing the definition of that parameter.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationParameterPropertyType")]
  public class OperationParameterPropertyType : ObservableModel {

    #region Private fields
    private OperationParameterType _operationParameter;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// OperationParameterPropertyType class constructor
    /// </summary>
    public OperationParameterPropertyType() {
      _operationParameter = new OperationParameterType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("OperationParameter", Order = 0)]
    public OperationParameterType OperationParameter {
      get {
        return _operationParameter;
      }
      set {
        if (_operationParameter == value) {
          return;
        }
        if (_operationParameter == null || _operationParameter.Equals(value) != true) {
          _operationParameter = value;
          OnPropertyChanged("OperationParameter");
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
