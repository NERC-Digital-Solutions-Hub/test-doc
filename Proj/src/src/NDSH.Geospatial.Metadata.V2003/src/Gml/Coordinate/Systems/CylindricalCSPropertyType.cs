
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
  /// gml:CylindricalCSPropertyType is a property type for association roles to a cylindrical coordinate system,
  /// either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CylindricalCSPropertyType")]
  public class CylindricalCSPropertyType : ObservableModel {

    #region Private fields
    private CylindricalCSType _cylindricalCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// CylindricalCSPropertyType class constructor
    /// </summary>
    public CylindricalCSPropertyType() {
      _cylindricalCS = new CylindricalCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("CylindricalCS", Order = 0)]
    public CylindricalCSType CylindricalCS {
      get {
        return _cylindricalCS;
      }
      set {
        if (_cylindricalCS == value) {
          return;
        }
        if (_cylindricalCS == null || _cylindricalCS.Equals(value) != true) {
          _cylindricalCS = value;
          OnPropertyChanged("CylindricalCS");
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
