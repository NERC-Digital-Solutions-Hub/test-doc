
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

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Basic2D {


  /// <summary>
  /// gml:SurfaceArrayPropertyType is a container for an array of surfaces. The elements are always contained in the array property, referencing geometry elements or arrays of geometry elements via XLinks is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SurfaceArrayPropertyType")]
  public class SurfaceArrayPropertyType : ObservableModel {

    #region Private fields
    private List<AbstractSurfaceType> _abstractSurface;
    private bool _owns;
    #endregion

    /// <summary>
    /// SurfaceArrayPropertyType class constructor
    /// </summary>
    public SurfaceArrayPropertyType() {
      _abstractSurface = new List<AbstractSurfaceType>();
      _owns = false;
    }

    [XmlElement("AbstractSurface", Order = 0)]
    [JsonProperty("AbstractSurface", Order = 0)]
    public List<AbstractSurfaceType> AbstractSurface {
      get {
        return _abstractSurface;
      }
      set {
        if (_abstractSurface == value) {
          return;
        }
        if (_abstractSurface == null || _abstractSurface.Equals(value) != true) {
          _abstractSurface = value;
          OnPropertyChanged("AbstractSurface");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }
  }

}
