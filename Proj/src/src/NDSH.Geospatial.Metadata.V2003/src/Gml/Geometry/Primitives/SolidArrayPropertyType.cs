using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {


  /// <summary>
  /// gml:SolidArrayPropertyType is a container for an array of solids. The elements are always contained in the array property, referencing geometry elements or arrays of geometry elements is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SolidArrayPropertyType")]
  public class SolidArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractSolidType> _abstractSolid;
    private bool _owns;
    #endregion

    /// <summary>
    /// SolidArrayPropertyType class constructor
    /// </summary>
    public SolidArrayPropertyType() {
      _abstractSolid = new List<AbstractSolidType>();
      _owns = false;
    }

    [XmlElement("AbstractSolid", Order = 0)]
    [JsonProperty("AbstractSolid", Order = 0)]
    public List<AbstractSolidType> AbstractSolid {
      get {
        return _abstractSolid;
      }
      set {
        if (_abstractSolid == value) {
          return;
        }
        if (_abstractSolid == null || _abstractSolid.Equals(value) != true) {
          _abstractSolid = value;
          OnPropertyChanged("AbstractSolid");
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
