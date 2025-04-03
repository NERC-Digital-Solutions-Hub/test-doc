
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


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TemporalCSPropertyType")]
  public class TemporalCSPropertyType : Model
  {
    #region Private fields
    private TemporalCSType _temporalCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TemporalCSPropertyType class constructor
    /// </summary>
    public TemporalCSPropertyType()
    {
      _temporalCS = new TemporalCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TemporalCS", Order = 0)]
    public TemporalCSType TemporalCS
    {
      get
      {
        return _temporalCS;
      }
      set
      {
        if (_temporalCS == value)
        {
          return;
        }
        if (_temporalCS == null || _temporalCS.Equals(value) != true)
        {
          _temporalCS = value;
          OnPropertyChanged("TemporalCS");
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