
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
  /// gml:PrimeMeridianPropertyType is a property type for association roles to a prime meridian, either referencing or containing the definition of that meridian.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PrimeMeridianPropertyType")]
  public class PrimeMeridianPropertyType : Model
  {
    #region Private fields
    private PrimeMeridianType _primeMeridian;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// PrimeMeridianPropertyType class constructor
    /// </summary>
    public PrimeMeridianPropertyType()
    {
      _primeMeridian = new PrimeMeridianType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("PrimeMeridian", Order = 0)]
    public PrimeMeridianType PrimeMeridian
    {
      get
      {
        return _primeMeridian;
      }
      set
      {
        if (_primeMeridian == value)
        {
          return;
        }
        if (_primeMeridian == null || _primeMeridian.Equals(value) != true)
        {
          _primeMeridian = value;
          OnPropertyChanged("PrimeMeridian");
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