
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
  /// gml:ImageDatumPropertyType is a property type for association roles to an image datum, either referencing or containing the definition of that datum.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ImageDatumPropertyType")]
  public class ImageDatumPropertyType : ObservableModel {

    #region Private fields
    private ImageDatumType _imageDatum;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ImageDatumPropertyType class constructor
    /// </summary>
    public ImageDatumPropertyType() {
      _imageDatum = new ImageDatumType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("ImageDatum", Order = 0)]
    public ImageDatumType ImageDatum {
      get {
        return _imageDatum;
      }
      set {
        if (_imageDatum == value) {
          return;
        }
        if (_imageDatum == null || _imageDatum.Equals(value) != true) {
          _imageDatum = value;
          OnPropertyChanged("ImageDatum");
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
