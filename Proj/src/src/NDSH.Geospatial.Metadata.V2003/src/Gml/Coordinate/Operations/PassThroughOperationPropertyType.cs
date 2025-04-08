
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
  /// gml:PassThroughOperationPropertyType is a property type for association roles to a pass through operation, either referencing or containing the definition of that pass through operation.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PassThroughOperationPropertyType")]
  public class PassThroughOperationPropertyType : ObservableModel {

    #region Private fields
    private PassThroughOperationType _passThroughOperation;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// PassThroughOperationPropertyType class constructor
    /// </summary>
    public PassThroughOperationPropertyType() {
      _passThroughOperation = new PassThroughOperationType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("PassThroughOperation", Order = 0)]
    public PassThroughOperationType PassThroughOperation {
      get {
        return _passThroughOperation;
      }
      set {
        if (_passThroughOperation == value) {
          return;
        }
        if (_passThroughOperation == null || _passThroughOperation.Equals(value) != true) {
          _passThroughOperation = value;
          OnPropertyChanged("PassThroughOperation");
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
