
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
  /// gml:VerticalCRSPropertyType is a property type for association roles to a vertical coordinate reference system, either referencing or containing the definition of that reference system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("VerticalCRSPropertyType")]
  public class VerticalCRSPropertyType : Model
  {
    #region Private fields
    private VerticalCRSType _verticalCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// VerticalCRSPropertyType class constructor
    /// </summary>
    public VerticalCRSPropertyType()
    {
      _verticalCRS = new VerticalCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("VerticalCRS", Order = 0)]
    public VerticalCRSType VerticalCRS
    {
      get
      {
        return _verticalCRS;
      }
      set
      {
        if (_verticalCRS == value)
        {
          return;
        }
        if (_verticalCRS == null || _verticalCRS.Equals(value) != true)
        {
          _verticalCRS = value;
          OnPropertyChanged("VerticalCRS");
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