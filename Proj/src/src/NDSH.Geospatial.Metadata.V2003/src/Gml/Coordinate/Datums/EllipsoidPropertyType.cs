
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums {

  /// <summary>
  /// gml:EllipsoidPropertyType is a property type for association roles to an ellipsoid, either referencing or containing the definition of that ellipsoid.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EllipsoidPropertyType")]
  public class EllipsoidPropertyType : ObservableModel {

    #region Private fields
    private EllipsoidType _ellipsoid;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// EllipsoidPropertyType class constructor
    /// </summary>
    public EllipsoidPropertyType() {
      _ellipsoid = new EllipsoidType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Ellipsoid", Order = 0)]
    public EllipsoidType Ellipsoid {
      get {
        return _ellipsoid;
      }
      set {
        if (_ellipsoid == value) {
          return;
        }
        if (_ellipsoid == null || _ellipsoid.Equals(value) != true) {
          _ellipsoid = value;
          OnPropertyChanged("Ellipsoid");
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
