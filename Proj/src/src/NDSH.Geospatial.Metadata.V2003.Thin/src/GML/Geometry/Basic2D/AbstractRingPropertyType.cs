
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic2D {

  /// <summary>
  /// A property with the content model of gml:AbstractRingPropertyType encapsulates a ring to represent the surface boundary property of a surface.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractRingPropertyType")]
  public class AbstractRingPropertyType : Model {
    #region Private fields
    private AbstractRingType _abstractRing;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractRing", Order = 0)]
    public AbstractRingType AbstractRing {
      get {
        return _abstractRing;
      }
      set {
        if (_abstractRing == value) {
          return;
        }
        if (_abstractRing == null || _abstractRing.Equals(value) != true) {
          _abstractRing = value;
          OnPropertyChanged("AbstractRing");
        }
      }
    }
  }
}
