
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

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiPointType")]
  public class MultiPointType : AbstractGeometricAggregateType {
    #region Private fields
    private List<PointPropertyType> _pointMember;
    private PointArrayPropertyType _pointMembers;
    #endregion

    /// <summary>
    /// MultiPointType class constructor
    /// </summary>
    public MultiPointType() {
      _pointMembers = new PointArrayPropertyType();
      _pointMember = new List<PointPropertyType>();
    }

    [XmlElement("pointMember", Order = 0)]
    [JsonProperty("pointMember", Order = 0)]
    public List<PointPropertyType> pointMember {
      get {
        return _pointMember;
      }
      set {
        if (_pointMember == value) {
          return;
        }
        if (_pointMember == null || _pointMember.Equals(value) != true) {
          _pointMember = value;
          OnPropertyChanged("pointMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("pointMembers", Order = 1)]
    public PointArrayPropertyType pointMembers {
      get {
        return _pointMembers;
      }
      set {
        if (_pointMembers == value) {
          return;
        }
        if (_pointMembers == null || _pointMembers.Equals(value) != true) {
          _pointMembers = value;
          OnPropertyChanged("pointMembers");
        }
      }
    }
  }
}