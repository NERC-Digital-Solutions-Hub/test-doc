
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
  /// A property that has a curve as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CurvePropertyType")]
  public class CurvePropertyType : Model {
    #region Private fields
    private AbstractCurveType _abstractCurve;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// CurvePropertyType class constructor
    /// </summary>
    public CurvePropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractCurve", Order = 0)]
    public AbstractCurveType AbstractCurve {
      get {
        return _abstractCurve;
      }
      set {
        if (_abstractCurve == value) {
          return;
        }
        if (_abstractCurve == null || _abstractCurve.Equals(value) != true) {
          _abstractCurve = value;
          OnPropertyChanged("AbstractCurve");
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
  }
}
