
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.Datums;
using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Datums {

  [XmlInclude(typeof(ML_TemporalDatum_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TemporalDatumType")]
  public class TemporalDatumType : TemporalDatumBaseType {

    #region Private fields
    private DateTime _origin;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("origin", Order = 0)]
    public DateTime Origin {
      get {
        return _origin;
      }
      set {
        if (_origin.Equals(value) != true) {
          _origin = value;
          OnPropertyChanged("Origin");
        }
      }
    }
  }
}
