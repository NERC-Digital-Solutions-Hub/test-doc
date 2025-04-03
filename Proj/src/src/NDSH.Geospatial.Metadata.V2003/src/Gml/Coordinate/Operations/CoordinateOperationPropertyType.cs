
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
  /// gml:CoordinateOperationPropertyType is a property type for association roles to a coordinate operation,
  /// either referencing or containing the definition of that coordinate operation.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoordinateOperationPropertyType")]
  public class CoordinateOperationPropertyType : ObservableModel {

    #region Private fields
    private AbstractCoordinateOperationType _abstractCoordinateOperation;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractCoordinateOperation", Order = 0)]
    public AbstractCoordinateOperationType AbstractCoordinateOperation {
      get {
        return _abstractCoordinateOperation;
      }
      set {
        if (_abstractCoordinateOperation == value) {
          return;
        }
        if (_abstractCoordinateOperation == null || _abstractCoordinateOperation.Equals(value) != true) {
          _abstractCoordinateOperation = value;
          OnPropertyChanged("AbstractCoordinateOperation");
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
