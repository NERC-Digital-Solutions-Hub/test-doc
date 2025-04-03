
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Systems {

  /// <summary>
  /// gml:CoordinateSystemPropertyType is a property type for association roles to a coordinate system,
  /// either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoordinateSystemPropertyType")]
  public class CoordinateSystemPropertyType : ObservableModel {

    #region Private fields
    private AbstractCoordinateSystemType _abstractCoordinateSystem;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractCoordinateSystem", Order = 0)]
    public AbstractCoordinateSystemType AbstractCoordinateSystem {
      get {
        return _abstractCoordinateSystem;
      }
      set {
        if (_abstractCoordinateSystem == value) {
          return;
        }
        if (_abstractCoordinateSystem == null || _abstractCoordinateSystem.Equals(value) != true) {
          _abstractCoordinateSystem = value;
          OnPropertyChanged("AbstractCoordinateSystem");
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
