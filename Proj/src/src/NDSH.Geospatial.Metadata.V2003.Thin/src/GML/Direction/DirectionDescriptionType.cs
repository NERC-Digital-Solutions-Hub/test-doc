using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Direction {


  /// <summary>
  /// direction descriptions are specified by a compass point code, a keyword, a textual description or a reference to a description.
  /// A gml:compassPoint is specified by a simple enumeration.
  /// In addition, thre elements to contain text-based descriptions of direction are provided.
  /// If the direction is specified using a term from a list, gml:keyword should be used, and the list indicated using the value of the codeSpace attribute.
  /// if the direction is decribed in prose, gml:direction or gml:reference should be used, allowing the value to be included inline or by reference.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectionDescriptionType")]
  public class DirectionDescriptionType : Model {
    #region Private fields
    private object _item;
    #endregion

    [XmlElement("compassPoint", typeof(CompassPointEnumeration), Order = 0)]
    [XmlElement("description", typeof(string), Order = 0)]
    [XmlElement("keyword", typeof(CodeType), Order = 0)]
    [XmlElement("reference", typeof(ReferenceType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }
  }



}
