
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Dictionary;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.Topology;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.ReferenceSystems
{


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeOrdinalEraType")]
  public class TimeOrdinalEraType : DefinitionType
  {
    #region Private fields
    private List<RelatedTimeType> _relatedTime;
    private TimeNodePropertyType _start;
    private TimeNodePropertyType _end;
    private TimePeriodPropertyType _extent;
    private List<TimeOrdinalEraPropertyType> _member;
    private ReferenceType _group;
    #endregion

    /// <summary>
    /// TimeOrdinalEraType class constructor
    /// </summary>
    public TimeOrdinalEraType()
    {
      _group = new ReferenceType();
      _member = new List<TimeOrdinalEraPropertyType>();
      _extent = new TimePeriodPropertyType();
      _end = new TimeNodePropertyType();
      _start = new TimeNodePropertyType();
      _relatedTime = new List<RelatedTimeType>();
    }

    [XmlElement("relatedTime", Order = 0)]
    [JsonProperty("relatedTime", Order = 0)]
    public List<RelatedTimeType> relatedTime
    {
      get
      {
        return _relatedTime;
      }
      set
      {
        if (_relatedTime == value)
        {
          return;
        }
        if (_relatedTime == null || _relatedTime.Equals(value) != true)
        {
          _relatedTime = value;
          OnPropertyChanged("relatedTime");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("start", Order = 1)]
    public TimeNodePropertyType start
    {
      get
      {
        return _start;
      }
      set
      {
        if (_start == value)
        {
          return;
        }
        if (_start == null || _start.Equals(value) != true)
        {
          _start = value;
          OnPropertyChanged("start");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("end", Order = 2)]
    public TimeNodePropertyType end
    {
      get
      {
        return _end;
      }
      set
      {
        if (_end == value)
        {
          return;
        }
        if (_end == null || _end.Equals(value) != true)
        {
          _end = value;
          OnPropertyChanged("end");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("extent", Order = 3)]
    public TimePeriodPropertyType extent
    {
      get
      {
        return _extent;
      }
      set
      {
        if (_extent == value)
        {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true)
        {
          _extent = value;
          OnPropertyChanged("extent");
        }
      }
    }

    [XmlElement("member", Order = 4)]
    [JsonProperty("member", Order = 4)]
    public List<TimeOrdinalEraPropertyType> member
    {
      get
      {
        return _member;
      }
      set
      {
        if (_member == value)
        {
          return;
        }
        if (_member == null || _member.Equals(value) != true)
        {
          _member = value;
          OnPropertyChanged("member");
        }
      }
    }

    [XmlElement(Order = 5)]
    [JsonProperty("group", Order = 5)]
    public ReferenceType group
    {
      get
      {
        return _group;
      }
      set
      {
        if (_group == value)
        {
          return;
        }
        if (_group == null || _group.Equals(value) != true)
        {
          _group = value;
          OnPropertyChanged("group");
        }
      }
    }
  }
}