
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.ReferenceSystems {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeocentricCRSPropertyType")]
  public class GeocentricCRSPropertyType : ObservableModel {

    #region Private fields
    private GeocentricCRSType _geocentricCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// GeocentricCRSPropertyType class constructor
    /// </summary>
    public GeocentricCRSPropertyType() {
      _geocentricCRS = new GeocentricCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("GeocentricCRS", Order = 0)]
    public GeocentricCRSType GeocentricCRS {
      get {
        return _geocentricCRS;
      }
      set {
        if (_geocentricCRS == value) {
          return;
        }
        if (_geocentricCRS == null || _geocentricCRS.Equals(value) != true) {
          _geocentricCRS = value;
          OnPropertyChanged("GeocentricCRS");
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
