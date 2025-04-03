
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
  /// gml:UserDefinedCSPropertyType is a property type for association roles to a user-defined coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("UserDefinedCSPropertyType")]
  public class UserDefinedCSPropertyType : Model
  {
    #region Private fields
    private UserDefinedCSType _userDefinedCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// UserDefinedCSPropertyType class constructor
    /// </summary>
    public UserDefinedCSPropertyType()
    {
      _userDefinedCS = new UserDefinedCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("UserDefinedCS", Order = 0)]
    public UserDefinedCSType UserDefinedCS
    {
      get
      {
        return _userDefinedCS;
      }
      set
      {
        if (_userDefinedCS == value)
        {
          return;
        }
        if (_userDefinedCS == null || _userDefinedCS.Equals(value) != true)
        {
          _userDefinedCS = value;
          OnPropertyChanged("UserDefinedCS");
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