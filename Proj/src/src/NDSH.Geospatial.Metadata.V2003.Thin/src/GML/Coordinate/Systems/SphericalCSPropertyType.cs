
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
  /// gml:SphericalCSPropertyType is property type for association roles to a spherical coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SphericalCSPropertyType")]
  public class SphericalCSPropertyType : Model
  {
    #region Private fields
    private SphericalCSType _sphericalCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// SphericalCSPropertyType class constructor
    /// </summary>
    public SphericalCSPropertyType()
    {
      _sphericalCS = new SphericalCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("SphericalCS", Order = 0)]
    public SphericalCSType SphericalCS
    {
      get
      {
        return _sphericalCS;
      }
      set
      {
        if (_sphericalCS == value)
        {
          return;
        }
        if (_sphericalCS == null || _sphericalCS.Equals(value) != true)
        {
          _sphericalCS = value;
          OnPropertyChanged("SphericalCS");
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