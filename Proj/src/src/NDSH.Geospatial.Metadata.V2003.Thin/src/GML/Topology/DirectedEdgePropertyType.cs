
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
  [JsonObject("DirectedEdgePropertyType")]
  public class DirectedEdgePropertyType : Model {
    #region Private fields
    private EdgeType _edge;
    private SignType _orientation;
    private string _nilReason;
    private string _remoteSchema;
    private bool _owns;
    #endregion

    /// <summary>
    /// DirectedEdgePropertyType class constructor
    /// </summary>
    public DirectedEdgePropertyType() {
      _edge = new EdgeType();
      _orientation = SignType.Item1;
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Edge", Order = 0)]
    public EdgeType Edge {
      get {
        return _edge;
      }
      set {
        if (_edge == value) {
          return;
        }
        if (_edge == null || _edge.Equals(value) != true) {
          _edge = value;
          OnPropertyChanged("Edge");
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