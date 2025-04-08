
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
  /// gml:EllipsoidalCSPropertyType is a property type for association roles to an ellipsoidal coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EllipsoidalCSPropertyType")]
  public class EllipsoidalCSPropertyType : Model
  {
    #region Private fields
    private EllipsoidalCSType _ellipsoidalCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// EllipsoidalCSPropertyType class constructor
    /// </summary>
    public EllipsoidalCSPropertyType()
    {
      _ellipsoidalCS = new EllipsoidalCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("EllipsoidalCS", Order = 0)]
    public EllipsoidalCSType EllipsoidalCS
    {
      get
      {
        return _ellipsoidalCS;
      }
      set
      {
        if (_ellipsoidalCS == value)
        {
          return;
        }
        if (_ellipsoidalCS == null || _ellipsoidalCS.Equals(value) != true)
        {
          _ellipsoidalCS = value;
          OnPropertyChanged("EllipsoidalCS");
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