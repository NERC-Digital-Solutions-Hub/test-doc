
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

  /// <summary>
  /// gml:GeodeticCRSPropertyType is a property type for association roles to a geodetic coordinate reference system, either referencing or containing the definition of that reference system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodeticCRSPropertyType")]
  public class GeodeticCRSPropertyType : ObservableModel {

    #region Private fields
    private GeodeticCRSType _geodeticCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// GeodeticCRSPropertyType class constructor
    /// </summary>
    public GeodeticCRSPropertyType() {
      _geodeticCRS = new GeodeticCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("GeodeticCRS", Order = 0)]
    public GeodeticCRSType GeodeticCRS {
      get {
        return _geodeticCRS;
      }
      set {
        if (_geodeticCRS == value) {
          return;
        }
        if (_geodeticCRS == null || _geodeticCRS.Equals(value) != true) {
          _geodeticCRS = value;
          OnPropertyChanged("GeodeticCRS");
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
