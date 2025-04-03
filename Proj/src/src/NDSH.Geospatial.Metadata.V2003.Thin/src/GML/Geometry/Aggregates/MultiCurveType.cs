
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
  [JsonObject("MultiCurveType")]
  public class MultiCurveType : AbstractGeometricAggregateType {
    #region Private fields
    private List<CurvePropertyType> _curveMember;
    private CurveArrayPropertyType _curveMembers;
    #endregion

    /// <summary>
    /// MultiCurveType class constructor
    /// </summary>
    public MultiCurveType() {
      _curveMembers = new CurveArrayPropertyType();
      _curveMember = new List<CurvePropertyType>();
    }

    [XmlElement("curveMember", Order = 0)]
    [JsonProperty("curveMember", Order = 0)]
    public List<CurvePropertyType> curveMember {
      get {
        return _curveMember;
      }
      set {
        if (_curveMember == value) {
          return;
        }
        if (_curveMember == null || _curveMember.Equals(value) != true) {
          _curveMember = value;
          OnPropertyChanged("curveMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("curveMembers", Order = 1)]
    public CurveArrayPropertyType curveMembers {
      get {
        return _curveMembers;
      }
      set {
        if (_curveMembers == value) {
          return;
        }
        if (_curveMembers == null || _curveMembers.Equals(value) != true) {
          _curveMembers = value;
          OnPropertyChanged("curveMembers");
        }
      }
    }
  }
}
