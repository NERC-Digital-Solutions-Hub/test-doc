
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D {

  /// <summary>
  /// A property that has a geometric primitive as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeometricPrimitivePropertyType")]
  public class GeometricPrimitivePropertyType : Model {
    #region Private fields
    private AbstractGeometricPrimitiveType _abstractGeometricPrimitive;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// GeometricPrimitivePropertyType class constructor
    /// </summary>
    public GeometricPrimitivePropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractGeometricPrimitive", Order = 0)]
    public AbstractGeometricPrimitiveType AbstractGeometricPrimitive {
      get {
        return _abstractGeometricPrimitive;
      }
      set {
        if (_abstractGeometricPrimitive == value) {
          return;
        }
        if (_abstractGeometricPrimitive == null || _abstractGeometricPrimitive.Equals(value) != true) {
          _abstractGeometricPrimitive = value;
          OnPropertyChanged("AbstractGeometricPrimitive");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("owns");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string nilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("nilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string remoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("remoteSchema");
        }
      }
    }
  }
}
