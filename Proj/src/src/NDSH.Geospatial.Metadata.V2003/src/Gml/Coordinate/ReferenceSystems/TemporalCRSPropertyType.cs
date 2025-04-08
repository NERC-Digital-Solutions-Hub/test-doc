
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
  /// gml:TemporalCRSPropertyType is a property type for association roles to a temporal coordinate reference system, either referencing or containing the definition of that reference system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TemporalCRSPropertyType")]
  public class TemporalCRSPropertyType : ObservableModel {

    #region Private fields
    private TemporalCRSType _temporalCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TemporalCRSPropertyType class constructor
    /// </summary>
    public TemporalCRSPropertyType() {
      _temporalCRS = new TemporalCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TemporalCRS", Order = 0)]
    public TemporalCRSType TemporalCRS {
      get {
        return _temporalCRS;
      }
      set {
        if (_temporalCRS == value) {
          return;
        }
        if (_temporalCRS == null || _temporalCRS.Equals(value) != true) {
          _temporalCRS = value;
          OnPropertyChanged("TemporalCRS");
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
