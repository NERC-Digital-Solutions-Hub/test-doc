
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
  /// gml:GeodeticDatumPropertyType is a property type for association roles to a geodetic datum, either referencing or containing the definition of that datum.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GeodeticDatumPropertyType")]
  public class GeodeticDatumPropertyType : Model
  {
    #region Private fields
    private GeodeticDatumType _geodeticDatum;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// GeodeticDatumPropertyType class constructor
    /// </summary>
    public GeodeticDatumPropertyType()
    {
      _geodeticDatum = new GeodeticDatumType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("GeodeticDatum", Order = 0)]
    public GeodeticDatumType GeodeticDatum
    {
      get
      {
        return _geodeticDatum;
      }
      set
      {
        if (_geodeticDatum == value)
        {
          return;
        }
        if (_geodeticDatum == null || _geodeticDatum.Equals(value) != true)
        {
          _geodeticDatum = value;
          OnPropertyChanged("GeodeticDatum");
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