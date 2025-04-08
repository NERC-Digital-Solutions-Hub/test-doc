
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
  /// gml:ImageCRSPropertyType is a property type for association roles to an image coordinate reference system,
  /// either referencing or containing the definition of that reference system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ImageCRSPropertyType")]
  public class ImageCRSPropertyType : ObservableModel {

    #region Private fields
    private ImageCRSType _imageCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ImageCRSPropertyType class constructor
    /// </summary>
    public ImageCRSPropertyType() {
      _imageCRS = new ImageCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("ImageCRS", Order = 0)]
    public ImageCRSType ImageCRS {
      get {
        return _imageCRS;
      }
      set {
        if (_imageCRS == value) {
          return;
        }
        if (_imageCRS == null || _imageCRS.Equals(value) != true) {
          _imageCRS = value;
          OnPropertyChanged("ImageCRS");
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
