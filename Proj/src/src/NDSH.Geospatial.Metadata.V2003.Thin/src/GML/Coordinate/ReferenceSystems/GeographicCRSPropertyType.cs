
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.ReferenceSystems
{


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeographicCRSPropertyType")]
  public class GeographicCRSPropertyType : Model
  {
    #region Private fields
    private GeographicCRSType _geographicCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// GeographicCRSPropertyType class constructor
    /// </summary>
    public GeographicCRSPropertyType()
    {
      _geographicCRS = new GeographicCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("GeographicCRS", Order = 0)]
    public GeographicCRSType GeographicCRS
    {
      get
      {
        return _geographicCRS;
      }
      set
      {
        if (_geographicCRS == value)
        {
          return;
        }
        if (_geographicCRS == null || _geographicCRS.Equals(value) != true)
        {
          _geographicCRS = value;
          OnPropertyChanged("GeographicCRS");
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