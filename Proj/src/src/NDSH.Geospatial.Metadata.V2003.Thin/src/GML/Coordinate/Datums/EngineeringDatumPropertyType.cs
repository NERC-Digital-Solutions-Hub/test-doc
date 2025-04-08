
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
  /// gml:EngineeringDatumPropertyType is a property type for association roles to an engineering datum, either referencing or containing the definition of that datum.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EngineeringDatumPropertyType")]
  public class EngineeringDatumPropertyType : Model
  {
    #region Private fields
    private EngineeringDatumType _engineeringDatum;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// EngineeringDatumPropertyType class constructor
    /// </summary>
    public EngineeringDatumPropertyType()
    {
      _engineeringDatum = new EngineeringDatumType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("EngineeringDatum", Order = 0)]
    public EngineeringDatumType EngineeringDatum
    {
      get
      {
        return _engineeringDatum;
      }
      set
      {
        if (_engineeringDatum == value)
        {
          return;
        }
        if (_engineeringDatum == null || _engineeringDatum.Equals(value) != true)
        {
          _engineeringDatum = value;
          OnPropertyChanged("EngineeringDatum");
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