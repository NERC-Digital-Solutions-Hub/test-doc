
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
  /// gml:EngineeringCRSPropertyType is a property type for association roles to an engineering coordinate reference system, either referencing or containing the definition of that reference system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("EngineeringCRSPropertyType")]
  public class EngineeringCRSPropertyType : Model
  {
    #region Private fields
    private EngineeringCRSType _engineeringCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// EngineeringCRSPropertyType class constructor
    /// </summary>
    public EngineeringCRSPropertyType()
    {
      _engineeringCRS = new EngineeringCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("EngineeringCRS", Order = 0)]
    public EngineeringCRSType EngineeringCRS
    {
      get
      {
        return _engineeringCRS;
      }
      set
      {
        if (_engineeringCRS == value)
        {
          return;
        }
        if (_engineeringCRS == null || _engineeringCRS.Equals(value) != true)
        {
          _engineeringCRS = value;
          OnPropertyChanged("EngineeringCRS");
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