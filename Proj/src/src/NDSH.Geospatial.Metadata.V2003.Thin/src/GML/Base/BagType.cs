
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("BagType")]
  public class BagType : AbstractGMLType {
    #region Private fields
    private List<AssociationRoleType> _member;
    private ArrayAssociationType _members;
    #endregion

    /// <summary>
    /// BagType class constructor
    /// </summary>
    public BagType() {
      _members = new ArrayAssociationType();
      _member = new List<AssociationRoleType>();
    }

    [XmlElement("member", Order = 0)]
    [JsonProperty("member", Order = 0)]
    public List<AssociationRoleType> member {
      get {
        return _member;
      }
      set {
        if (_member == value) {
          return;
        }
        if (_member == null || _member.Equals(value) != true) {
          _member = value;
          OnPropertyChanged("member");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("members", Order = 1)]
    public ArrayAssociationType members {
      get {
        return _members;
      }
      set {
        if (_members == value) {
          return;
        }
        if (_members == null || _members.Equals(value) != true) {
          _members = value;
          OnPropertyChanged("members");
        }
      }
    }
  }
}