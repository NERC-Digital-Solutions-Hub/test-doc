
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.ReferenceSystems
{


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCalendarType")]
  public class TimeCalendarType : TimeReferenceSystemType
  {
    #region Private fields
    private List<TimeCalendarEraPropertyType> _referenceFrame;
    #endregion

    /// <summary>
    /// TimeCalendarType class constructor
    /// </summary>
    public TimeCalendarType()
    {
      _referenceFrame = new List<TimeCalendarEraPropertyType>();
    }

    [XmlElement("referenceFrame", Order = 0)]
    [JsonProperty("referenceFrame", Order = 0)]
    public List<TimeCalendarEraPropertyType> referenceFrame
    {
      get
      {
        return _referenceFrame;
      }
      set
      {
        if (_referenceFrame == value)
        {
          return;
        }
        if (_referenceFrame == null || _referenceFrame.Equals(value) != true)
        {
          _referenceFrame = value;
          OnPropertyChanged("referenceFrame");
        }
      }
    }
  }
}