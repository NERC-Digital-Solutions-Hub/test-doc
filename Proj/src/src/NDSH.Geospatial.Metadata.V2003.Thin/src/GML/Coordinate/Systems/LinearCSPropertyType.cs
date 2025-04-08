
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
  /// gml:LinearCSPropertyType is a property type for association roles to a linear coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("LinearCSPropertyType")]
  public class LinearCSPropertyType : Model
  {
    #region Private fields
    private LinearCSType _linearCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// LinearCSPropertyType class constructor
    /// </summary>
    public LinearCSPropertyType()
    {
      _linearCS = new LinearCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("LinearCS", Order = 0)]
    public LinearCSType LinearCS
    {
      get
      {
        return _linearCS;
      }
      set
      {
        if (_linearCS == value)
        {
          return;
        }
        if (_linearCS == null || _linearCS.Equals(value) != true)
        {
          _linearCS = value;
          OnPropertyChanged("LinearCS");
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