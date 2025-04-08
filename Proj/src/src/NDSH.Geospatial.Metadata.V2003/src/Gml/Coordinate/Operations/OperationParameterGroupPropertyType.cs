
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
  /// gml:OperationParameterPropertyType is a property type for association roles to an operation parameter group, either referencing or containing the definition of that parameter group.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationParameterGroupPropertyType")]
  public class OperationParameterGroupPropertyType : ObservableModel {

    #region Private fields
    private OperationParameterGroupType _operationParameterGroup;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// OperationParameterGroupPropertyType class constructor
    /// </summary>
    public OperationParameterGroupPropertyType() {
      _operationParameterGroup = new OperationParameterGroupType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("OperationParameterGroup", Order = 0)]
    public OperationParameterGroupType OperationParameterGroup {
      get {
        return _operationParameterGroup;
      }
      set {
        if (_operationParameterGroup == value) {
          return;
        }
        if (_operationParameterGroup == null || _operationParameterGroup.Equals(value) != true) {
          _operationParameterGroup = value;
          OnPropertyChanged("OperationParameterGroup");
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
