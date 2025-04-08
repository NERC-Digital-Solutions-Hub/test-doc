
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.ReferenceSystems
{


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeClockType")]
  public class TimeClockType : TimeReferenceSystemType
  {
    #region Private fields
    private StringOrRefType _referenceEvent;
    private DateTime _referenceTime;
    private DateTime _utcReference;
    private List<TimeCalendarPropertyType> _dateBasis;
    #endregion

    /// <summary>
    /// TimeClockType class constructor
    /// </summary>
    public TimeClockType()
    {
      _dateBasis = new List<TimeCalendarPropertyType>();
      _referenceEvent = new StringOrRefType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("referenceEvent", Order = 0)]
    public StringOrRefType referenceEvent
    {
      get
      {
        return _referenceEvent;
      }
      set
      {
        if (_referenceEvent == value)
        {
          return;
        }
        if (_referenceEvent == null || _referenceEvent.Equals(value) != true)
        {
          _referenceEvent = value;
          OnPropertyChanged("referenceEvent");
        }
      }
    }

    [XmlElement(DataType = "time", Order = 1)]
    [JsonProperty("referenceTime", Order = 1)]
    public DateTime referenceTime
    {
      get
      {
        return _referenceTime;
      }
      set
      {
        if (_referenceTime.Equals(value) != true)
        {
          _referenceTime = value;
          OnPropertyChanged("referenceTime");
        }
      }
    }

    [XmlElement(DataType = "time", Order = 2)]
    [JsonProperty("utcReference", Order = 2)]
    public DateTime utcReference
    {
      get
      {
        return _utcReference;
      }
      set
      {
        if (_utcReference.Equals(value) != true)
        {
          _utcReference = value;
          OnPropertyChanged("utcReference");
        }
      }
    }

    [XmlElement("dateBasis", Order = 3)]
    [JsonProperty("dateBasis", Order = 3)]
    public List<TimeCalendarPropertyType> dateBasis
    {
      get
      {
        return _dateBasis;
      }
      set
      {
        if (_dateBasis == value)
        {
          return;
        }
        if (_dateBasis == null || _dateBasis.Equals(value) != true)
        {
          _dateBasis = value;
          OnPropertyChanged("dateBasis");
        }
      }
    }
  }
}