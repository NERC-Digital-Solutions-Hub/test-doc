
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
  /// gml:VerticalDatumPropertyType is property type for association roles to a vertical datum, either referencing or containing the definition of that datum.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VerticalDatumPropertyType")]
  public class VerticalDatumPropertyType : Model
  {
    #region Private fields
    private VerticalDatumType _verticalDatum;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// VerticalDatumPropertyType class constructor
    /// </summary>
    public VerticalDatumPropertyType()
    {
      _verticalDatum = new VerticalDatumType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("VerticalDatum", Order = 0)]
    public VerticalDatumType VerticalDatum
    {
      get
      {
        return _verticalDatum;
      }
      set
      {
        if (_verticalDatum == value)
        {
          return;
        }
        if (_verticalDatum == null || _verticalDatum.Equals(value) != true)
        {
          _verticalDatum = value;
          OnPropertyChanged("VerticalDatum");
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