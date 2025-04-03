
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations
{


  /// <summary>
  /// gml:ConversionPropertyType is a property type for association roles to a concrete general-purpose conversion, either referencing or containing the definition of that conversion.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConversionPropertyType")]
  public class ConversionPropertyType : Model
  {
    #region Private fields
    private ConversionType _conversion;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ConversionPropertyType class constructor
    /// </summary>
    public ConversionPropertyType()
    {
      _conversion = new ConversionType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("Conversion", Order = 0)]
    public ConversionType Conversion
    {
      get
      {
        return _conversion;
      }
      set
      {
        if (_conversion == value)
        {
          return;
        }
        if (_conversion == null || _conversion.Equals(value) != true)
        {
          _conversion = value;
          OnPropertyChanged("Conversion");
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