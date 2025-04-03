

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Metadata.V2003.Gml.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.GmlBase {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("InlinePropertyType")]
  public class InlinePropertyType : ObservableModel {

    #region Private fields
    private object _abstractObject;
    private bool _owns;
    #endregion

    /// <summary>
    /// InlinePropertyType class constructor
    /// </summary>
    public InlinePropertyType() {
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractObject", Order = 0)]
    public object AbstractObject {
      get {
        return _abstractObject;
      }
      set {
        if (_abstractObject == value) {
          return;
        }
        if (_abstractObject == null || _abstractObject.Equals(value) != true) {
          _abstractObject = value;
          OnPropertyChanged("AbstractObject");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }
  }

}
