
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Aggregates {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiGeometryType")]
  public class MultiGeometryType : AbstractGeometricAggregateType {
    #region Private fields
    private List<GeometryPropertyType> _geometryMember;
    private GeometryArrayPropertyType _geometryMembers;
    #endregion

    /// <summary>
    /// MultiGeometryType class constructor
    /// </summary>
    public MultiGeometryType() {
      _geometryMembers = new GeometryArrayPropertyType();
      _geometryMember = new List<GeometryPropertyType>();
    }

    [XmlElement("geometryMember", Order = 0)]
    [JsonProperty("geometryMember", Order = 0)]
    public List<GeometryPropertyType> geometryMember {
      get {
        return _geometryMember;
      }
      set {
        if (_geometryMember == value) {
          return;
        }
        if (_geometryMember == null || _geometryMember.Equals(value) != true) {
          _geometryMember = value;
          OnPropertyChanged("geometryMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("geometryMembers", Order = 1)]
    public GeometryArrayPropertyType geometryMembers {
      get {
        return _geometryMembers;
      }
      set {
        if (_geometryMembers == value) {
          return;
        }
        if (_geometryMembers == null || _geometryMembers.Equals(value) != true) {
          _geometryMembers = value;
          OnPropertyChanged("geometryMembers");
        }
      }
    }
  }
}
