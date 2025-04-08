
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
  /// gml:VerticalCSPropertyType is a property type for association roles to a vertical coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VerticalCSPropertyType")]
  public class VerticalCSPropertyType : Model
  {
    #region Private fields
    private VerticalCSType _verticalCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// VerticalCSPropertyType class constructor
    /// </summary>
    public VerticalCSPropertyType()
    {
      _verticalCS = new VerticalCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("VerticalCS", Order = 0)]
    public VerticalCSType VerticalCS
    {
      get
      {
        return _verticalCS;
      }
      set
      {
        if (_verticalCS == value)
        {
          return;
        }
        if (_verticalCS == null || _verticalCS.Equals(value) != true)
        {
          _verticalCS = value;
          OnPropertyChanged("VerticalCS");
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