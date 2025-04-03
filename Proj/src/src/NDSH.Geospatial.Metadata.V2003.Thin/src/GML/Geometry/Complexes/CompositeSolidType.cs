
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Primitives;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Complexes {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompositeSolidType")]
  public class CompositeSolidType : AbstractSolidType {
    #region Private fields
    private List<SolidPropertyType> _solidMember;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// CompositeSolidType class constructor
    /// </summary>
    public CompositeSolidType() {
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
