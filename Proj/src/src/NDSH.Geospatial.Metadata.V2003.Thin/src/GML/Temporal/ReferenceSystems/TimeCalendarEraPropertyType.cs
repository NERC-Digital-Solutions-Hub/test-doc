
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


  /// <summary>
  /// gml:TimeCalendarEraPropertyType provides for associating a gml:TimeCalendarEra with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCalendarEraPropertyType")]
  public class TimeCalendarEraPropertyType : Model
  {
    #region Private fields
    private TimeCalendarEraType _timeCalendarEra;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TimeCalendarEraPropertyType class constructor
    /// </summary>
    public TimeCalendarEraPropertyType()
    {
      _timeCalendarEra = new TimeCalendarEraType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeCalendarEra", Order = 0)]
    public TimeCalendarEraType TimeCalendarEra
    {
      get
      {
        return _timeCalendarEra;
      }
      set
      {
        if (_timeCalendarEra == value)
        {
          return;
        }
        if (_timeCalendarEra == null || _timeCalendarEra.Equals(value) != true)
        {
          _timeCalendarEra = value;
          OnPropertyChanged("TimeCalendarEra");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool owns
    {
      get
      {
        return _owns;
      }
      set
      {
        if (_owns.Equals(value) != true)
        {
          _owns = value;
          OnPropertyChanged("owns");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string nilReason
    {
      get
      {
        return _nilReason;
      }
      set
      {
        if (_nilReason == value)
        {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true)
        {
          _nilReason = value;
          OnPropertyChanged("nilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string remoteSchema
    {
      get
      {
        return _remoteSchema;
      }
      set
      {
        if (_remoteSchema == value)
        {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true)
        {
          _remoteSchema = value;
          OnPropertyChanged("remoteSchema");
        }
      }
    }
  }
}