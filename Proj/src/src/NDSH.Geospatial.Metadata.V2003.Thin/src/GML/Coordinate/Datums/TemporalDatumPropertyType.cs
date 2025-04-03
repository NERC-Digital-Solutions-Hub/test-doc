
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Datums
{


  /// <summary>
  /// gml:TemporalDatumPropertyType is a property type for association roles to a temporal datum, either referencing or containing the definition of that datum.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TemporalDatumPropertyType")]
  public class TemporalDatumPropertyType : Model
  {
    #region Private fields
    private TemporalDatumType _temporalDatum;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TemporalDatumPropertyType class constructor
    /// </summary>
    public TemporalDatumPropertyType()
    {
      _temporalDatum = new TemporalDatumType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TemporalDatum", Order = 0)]
    public TemporalDatumType TemporalDatum
    {
      get
      {
        return _temporalDatum;
      }
      set
      {
        if (_temporalDatum == value)
        {
          return;
        }
        if (_temporalDatum == null || _temporalDatum.Equals(value) != true)
        {
          _temporalDatum = value;
          OnPropertyChanged("TemporalDatum");
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