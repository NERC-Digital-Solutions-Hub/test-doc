
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
  /// gml:ProjectedCRSPropertyType is a property type for association roles to a projected coordinate reference system,
  /// either referencing or containing the definition of that reference system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ProjectedCRSPropertyType")]
  public class ProjectedCRSPropertyType : ObservableModel {

    #region Private fields
    private ProjectedCRSType _projectedCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ProjectedCRSPropertyType class constructor
    /// </summary>
    public ProjectedCRSPropertyType() {
      _projectedCRS = new ProjectedCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("ProjectedCRS", Order = 0)]
    public ProjectedCRSType ProjectedCRS {
      get {
        return _projectedCRS;
      }
      set {
        if (_projectedCRS == value) {
          return;
        }
        if (_projectedCRS == null || _projectedCRS.Equals(value) != true) {
          _projectedCRS = value;
          OnPropertyChanged("ProjectedCRS");
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
