
#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// A property with the content model of gml:RingPropertyType encapsulates a ring to represent a component of a surface boundary.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RingPropertyType")]
  public class RingPropertyType : ObservableModel {

    #region Private fields
    private RingType _ring;
    #endregion

    /// <summary>
    /// RingPropertyType class constructor
    /// </summary>
    public RingPropertyType() {
      _ring = new RingType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Ring", Order = 0)]
    public RingType Ring {
      get {
        return _ring;
      }
      set {
        if (_ring == value) {
          return;
        }
        if (_ring == null || _ring.Equals(value) != true) {
          _ring = value;
          OnPropertyChanged("Ring");
        }
      }
    }
  }

}
