using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(SphereType))]
  [XmlInclude(typeof(CylinderType))]
  [XmlInclude(typeof(ConeType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGriddedSurfaceType")]
  public abstract class AbstractGriddedSurfaceType : AbstractParametricCurveSurfaceType {
    #region Private fields
    private List<AbstractGriddedSurfaceTypeRow> _rows;
    private string _rows1;
    private string _columns;
    #endregion

    /// <summary>
    /// AbstractGriddedSurfaceType class constructor
    /// </summary>
    public AbstractGriddedSurfaceType() {
      _rows = new List<AbstractGriddedSurfaceTypeRow>();
    }

    [XmlArray(Order = 0)]
    [XmlArrayItem("Row", IsNullable = false)]
    [JsonProperty("Row", Order = 0)]
    public List<AbstractGriddedSurfaceTypeRow> Rows {
      get {
        return _rows;
      }
      set {
        if (_rows == value) {
          return;
        }
        if (_rows == null || _rows.Equals(value) != true) {
          _rows = value;
          OnPropertyChanged("Rows");
        }
      }
    }

    [XmlAttribute("rows", DataType = "integer")]
    public string Rows1 {
      get {
        return _rows1;
      }
      set {
        if (_rows1 == value) {
          return;
        }
        if (_rows1 == null || _rows1.Equals(value) != true) {
          _rows1 = value;
          OnPropertyChanged("Rows1");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [JsonProperty("columns")]
    public string Columns {
      get {
        return _columns;
      }
      set {
        if (_columns == value) {
          return;
        }
        if (_columns == null || _columns.Equals(value) != true) {
          _columns = value;
          OnPropertyChanged("Columns");
        }
      }
    }
  }

}
