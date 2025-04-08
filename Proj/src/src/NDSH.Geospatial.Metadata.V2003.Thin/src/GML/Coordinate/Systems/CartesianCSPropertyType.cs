
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
  /// gml:CartesianCSPropertyType is a property type for association roles to a Cartesian coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CartesianCSPropertyType")]
  public class CartesianCSPropertyType : Model
  {
    #region Private fields
    private CartesianCSType _cartesianCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// CartesianCSPropertyType class constructor
    /// </summary>
    public CartesianCSPropertyType()
    {
      _cartesianCS = new CartesianCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("CartesianCS", Order = 0)]
    public CartesianCSType CartesianCS
    {
      get
      {
        return _cartesianCS;
      }
      set
      {
        if (_cartesianCS == value)
        {
          return;
        }
        if (_cartesianCS == null || _cartesianCS.Equals(value) != true)
        {
          _cartesianCS = value;
          OnPropertyChanged("CartesianCS");
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