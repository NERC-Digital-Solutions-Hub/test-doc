
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
  /// gml:AbstractGeneralOperationParameterPropertyType is a property type for association roles to an operation
  /// parameter or group, either referencing or containing the definition of that parameter or group.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralOperationParameterPropertyType")]
  public class AbstractGeneralOperationParameterPropertyType : ObservableModel {

    #region Private fields
    private AbstractGeneralOperationParameterType _abstractGeneralOperationParameter;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractGeneralOperationParameter", Order = 0)]
    public AbstractGeneralOperationParameterType AbstractGeneralOperationParameter {
      get {
        return _abstractGeneralOperationParameter;
      }
      set {
        if (_abstractGeneralOperationParameter == value) {
          return;
        }
        if (_abstractGeneralOperationParameter == null || _abstractGeneralOperationParameter.Equals(value) != true) {
          _abstractGeneralOperationParameter = value;
          OnPropertyChanged("AbstractGeneralOperationParameter");
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
