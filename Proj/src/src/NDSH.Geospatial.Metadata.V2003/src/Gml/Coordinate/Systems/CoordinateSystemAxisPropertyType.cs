
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
  /// gml:CoordinateSystemAxisPropertyType is a property type for association roles to a coordinate system axis, either referencing or containing the definition of that axis.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoordinateSystemAxisPropertyType")]
  public class CoordinateSystemAxisPropertyType : ObservableModel {

    #region Private fields
    private CoordinateSystemAxisType _coordinateSystemAxis;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// CoordinateSystemAxisPropertyType class constructor
    /// </summary>
    public CoordinateSystemAxisPropertyType() {
      _coordinateSystemAxis = new CoordinateSystemAxisType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("CoordinateSystemAxis", Order = 0)]
    public CoordinateSystemAxisType CoordinateSystemAxis {
      get {
        return _coordinateSystemAxis;
      }
      set {
        if (_coordinateSystemAxis == value) {
          return;
        }
        if (_coordinateSystemAxis == null || _coordinateSystemAxis.Equals(value) != true) {
          _coordinateSystemAxis = value;
          OnPropertyChanged("CoordinateSystemAxis");
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
