
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
  /// gml:AffineCSPropertyType is a property type for association roles to an affine coordinate system, either referencing or containing the definition of that coordinate system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AffineCSPropertyType")]
  public class AffineCSPropertyType : Model
  {
    #region Private fields
    private AffineCSType _affineCS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// AffineCSPropertyType class constructor
    /// </summary>
    public AffineCSPropertyType()
    {
      _affineCS = new AffineCSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("AffineCS", Order = 0)]
    public AffineCSType AffineCS
    {
      get
      {
        return _affineCS;
      }
      set
      {
        if (_affineCS == value)
        {
          return;
        }
        if (_affineCS == null || _affineCS.Equals(value) != true)
        {
          _affineCS = value;
          OnPropertyChanged("AffineCS");
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