
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
  /// gml:PolarCSPropertyType is a property type for association roles to a polar coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PolarCSPropertyType")]
  public class PolarCSPropertyType : Model
  {
    #region Private fields
    private PolarCSType _polarCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// PolarCSPropertyType class constructor
    /// </summary>
    public PolarCSPropertyType()
    {
      _polarCS = new PolarCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("PolarCS", Order = 0)]
    public PolarCSType PolarCS
    {
      get
      {
        return _polarCS;
      }
      set
      {
        if (_polarCS == value)
        {
          return;
        }
        if (_polarCS == null || _polarCS.Equals(value) != true)
        {
          _polarCS = value;
          OnPropertyChanged("PolarCS");
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