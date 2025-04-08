
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


  /// <summary>
  /// gml:GeodeticCRSPropertyType is a property type for association roles to a geodetic coordinate reference system, either referencing or containing the definition of that reference system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodeticCRSPropertyType")]
  public class GeodeticCRSPropertyType : Model
  {
    #region Private fields
    private GeodeticCRSType _geodeticCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// GeodeticCRSPropertyType class constructor
    /// </summary>
    public GeodeticCRSPropertyType()
    {
      _geodeticCRS = new GeodeticCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("GeodeticCRS", Order = 0)]
    public GeodeticCRSType GeodeticCRS
    {
      get
      {
        return _geodeticCRS;
      }
      set
      {
        if (_geodeticCRS == value)
        {
          return;
        }
        if (_geodeticCRS == null || _geodeticCRS.Equals(value) != true)
        {
          _geodeticCRS = value;
          OnPropertyChanged("GeodeticCRS");
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