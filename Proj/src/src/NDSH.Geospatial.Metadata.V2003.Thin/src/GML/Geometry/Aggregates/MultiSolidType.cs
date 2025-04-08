
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Aggregates {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiSolidType")]
  public class MultiSolidType : AbstractGeometricAggregateType {
    #region Private fields
    private List<SolidPropertyType> _solidMember;
    private SolidArrayPropertyType _solidMembers;
    #endregion

    /// <summary>
    /// MultiSolidType class constructor
    /// </summary>
    public MultiSolidType() {
      _solidMembers = new SolidArrayPropertyType();
      _solidMember = new List<SolidPropertyType>();
    }

    [XmlElement("solidMember", Order = 0)]
    [JsonProperty("solidMember", Order = 0)]
    public List<SolidPropertyType> solidMember {
      get {
        return _solidMember;
      }
      set {
        if (_solidMember == value) {
          return;
        }
        if (_solidMember == null || _solidMember.Equals(value) != true) {
          _solidMember = value;
          OnPropertyChanged("solidMember");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("solidMembers", Order = 1)]
    public SolidArrayPropertyType solidMembers {
      get {
        return _solidMembers;
      }
      set {
        if (_solidMembers == value) {
          return;
        }
        if (_solidMembers == null || _solidMembers.Equals(value) != true) {
          _solidMembers = value;
          OnPropertyChanged("solidMembers");
        }
      }
    }
  }
}