
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
  /// gml:ImageDatumPropertyType is a property type for association roles to an image datum, either referencing or containing the definition of that datum.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ImageDatumPropertyType")]
  public class ImageDatumPropertyType : Model
  {
    #region Private fields
    private ImageDatumType _imageDatum;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ImageDatumPropertyType class constructor
    /// </summary>
    public ImageDatumPropertyType()
    {
      _imageDatum = new ImageDatumType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("ImageDatum", Order = 0)]
    public ImageDatumType ImageDatum
    {
      get
      {
        return _imageDatum;
      }
      set
      {
        if (_imageDatum == value)
        {
          return;
        }
        if (_imageDatum == null || _imageDatum.Equals(value) != true)
        {
          _imageDatum = value;
          OnPropertyChanged("ImageDatum");
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