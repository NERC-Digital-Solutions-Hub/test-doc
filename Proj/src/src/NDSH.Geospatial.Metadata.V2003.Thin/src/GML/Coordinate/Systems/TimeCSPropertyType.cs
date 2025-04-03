
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Systems
{


  /// <summary>
  /// gml:TimeCSPropertyType is a property type for association roles to a time coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCSPropertyType")]
  public class TimeCSPropertyType : Model
  {
    #region Private fields
    private TimeCSType _timeCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TimeCSPropertyType class constructor
    /// </summary>
    public TimeCSPropertyType()
    {
      _timeCS = new TimeCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeCS", Order = 0)]
    public TimeCSType TimeCS
    {
      get
      {
        return _timeCS;
      }
      set
      {
        if (_timeCS == value)
        {
          return;
        }
        if (_timeCS == null || _timeCS.Equals(value) != true)
        {
          _timeCS = value;
          OnPropertyChanged("TimeCS");
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