
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
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums
{

  [XmlInclude(typeof(ML_TemporalDatum_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TemporalDatumType")]
  public class TemporalDatumType : TemporalDatumBaseType
  {
    #region Private fields
    private DateTime _origin;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("origin", Order = 0)]
    public DateTime origin
    {
      get
      {
        return _origin;
      }
      set
      {
        if (_origin.Equals(value) != true)
        {
          _origin = value;
          OnPropertyChanged("origin");
        }
      }
    }
  }
}