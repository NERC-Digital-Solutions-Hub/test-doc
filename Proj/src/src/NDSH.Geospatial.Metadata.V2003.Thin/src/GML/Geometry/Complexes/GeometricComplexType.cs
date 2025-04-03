
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Complexes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeometricComplexType")]
  public class GeometricComplexType : AbstractGeometryType {
    #region Private fields
    private List<GeometricPrimitivePropertyType> _element;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// GeometricComplexType class constructor
    /// </summary>
    public GeometricComplexType() {
      _element = new List<GeometricPrimitivePropertyType>();
    }

    [XmlElement("element", Order = 0)]
    [JsonProperty("element", Order = 0)]
    public List<GeometricPrimitivePropertyType> element {
      get {
        return _element;
      }
      set {
        if (_element == value) {
          return;
        }
        if (_element == null || _element.Equals(value) != true) {
          _element = value;
          OnPropertyChanged("element");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType aggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("aggregationType");
        }
      }
    }
  }
}
