
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Dictionary;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal.ReferenceSystems
{


  [XmlInclude(typeof(TimeOrdinalReferenceSystemType))]
  [XmlInclude(typeof(TimeClockType))]
  [XmlInclude(typeof(TimeCalendarType))]
  [XmlInclude(typeof(TimeCoordinateSystemType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeReferenceSystemType")]
  public class TimeReferenceSystemType : DefinitionType
  {
    #region Private fields
    private string _domainOfValidity;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("domainOfValidity", Order = 0)]
    public string domainOfValidity
    {
      get
      {
        return _domainOfValidity;
      }
      set
      {
        if (_domainOfValidity == value)
        {
          return;
        }
        if (_domainOfValidity == null || _domainOfValidity.Equals(value) != true)
        {
          _domainOfValidity = value;
          OnPropertyChanged("domainOfValidity");
        }
      }
    }
  }
}