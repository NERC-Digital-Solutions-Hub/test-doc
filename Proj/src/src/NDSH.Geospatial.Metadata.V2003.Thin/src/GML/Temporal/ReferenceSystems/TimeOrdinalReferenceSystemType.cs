
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
  [JsonObject("TimeOrdinalReferenceSystemType")]
  public class TimeOrdinalReferenceSystemType : TimeReferenceSystemType
  {
    #region Private fields
    private List<TimeOrdinalEraPropertyType> _component;
    #endregion

    /// <summary>
    /// TimeOrdinalReferenceSystemType class constructor
    /// </summary>
    public TimeOrdinalReferenceSystemType()
    {
      _component = new List<TimeOrdinalEraPropertyType>();
    }

    [XmlElement("component", Order = 0)]
    [JsonProperty("component", Order = 0)]
    public List<TimeOrdinalEraPropertyType> component
    {
      get
      {
        return _component;
      }
      set
      {
        if (_component == value)
        {
          return;
        }
        if (_component == null || _component.Equals(value) != true)
        {
          _component = value;
          OnPropertyChanged("component");
        }
      }
    }
  }
}