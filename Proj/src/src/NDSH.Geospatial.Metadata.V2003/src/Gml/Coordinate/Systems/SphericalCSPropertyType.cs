
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
  /// gml:SphericalCSPropertyType is property type for association roles to a spherical coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SphericalCSPropertyType")]
  public class SphericalCSPropertyType : ObservableModel {

    #region Private fields
    private SphericalCSType _sphericalCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// SphericalCSPropertyType class constructor
    /// </summary>
    public SphericalCSPropertyType() {
      _sphericalCS = new SphericalCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("SphericalCS", Order = 0)]
    public SphericalCSType SphericalCS {
      get {
        return _sphericalCS;
      }
      set {
        if (_sphericalCS == value) {
          return;
        }
        if (_sphericalCS == null || _sphericalCS.Equals(value) != true) {
          _sphericalCS = value;
          OnPropertyChanged("SphericalCS");
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
