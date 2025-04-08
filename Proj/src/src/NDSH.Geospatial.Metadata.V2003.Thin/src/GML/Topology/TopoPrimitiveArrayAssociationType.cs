
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Topology {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TopoPrimitiveArrayAssociationType")]
  public class TopoPrimitiveArrayAssociationType : Model {
    #region Private fields
    private List<AbstractTopoPrimitiveType> _abstractTopoPrimitive;
    private bool _owns;
    #endregion

    /// <summary>
    /// TopoPrimitiveArrayAssociationType class constructor
    /// </summary>
    public TopoPrimitiveArrayAssociationType() {
      _abstractTopoPrimitive = new List<AbstractTopoPrimitiveType>();
      _owns = false;
    }

    [XmlElement("AbstractTopoPrimitive", Order = 0)]
    [JsonProperty("AbstractTopoPrimitive", Order = 0)]
    public List<AbstractTopoPrimitiveType> AbstractTopoPrimitive {
      get {
        return _abstractTopoPrimitive;
      }
      set {
        if (_abstractTopoPrimitive == value) {
          return;
        }
        if (_abstractTopoPrimitive == null || _abstractTopoPrimitive.Equals(value) != true) {
          _abstractTopoPrimitive = value;
          OnPropertyChanged("AbstractTopoPrimitive");
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