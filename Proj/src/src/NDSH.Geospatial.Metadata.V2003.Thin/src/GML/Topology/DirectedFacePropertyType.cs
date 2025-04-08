
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectedFacePropertyType")]
  public class DirectedFacePropertyType : Model {
    #region Private fields
    private FaceType _face;
    private SignType _orientation;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// DirectedFacePropertyType class constructor
    /// </summary>
    public DirectedFacePropertyType() {
      _face = new FaceType();
      _orientation = SignType.Item1;
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Face", Order = 0)]
    public FaceType Face {
      get {
        return _face;
      }
      set {
        if (_face == value) {
          return;
        }
        if (_face == null || _face.Equals(value) != true) {
          _face = value;
          OnPropertyChanged("Face");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(SignType.Item1)]
    [JsonProperty("orientation")]
    public SignType orientation {
      get {
        return _orientation;
      }
      set {
        if (_orientation.Equals(value) != true) {
          _orientation = value;
          OnPropertyChanged("orientation");
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