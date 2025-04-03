
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
  /// gml:DerivedCRSPropertyType is a property type for association roles to a non-projected derived coordinate reference system, either referencing or containing the definition of that reference system.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DerivedCRSPropertyType")]
  public class DerivedCRSPropertyType : Model
  {
    #region Private fields
    private DerivedCRSType _derivedCRS;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// DerivedCRSPropertyType class constructor
    /// </summary>
    public DerivedCRSPropertyType()
    {
      _derivedCRS = new DerivedCRSType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("DerivedCRS", Order = 0)]
    public DerivedCRSType DerivedCRS
    {
      get
      {
        return _derivedCRS;
      }
      set
      {
        if (_derivedCRS == value)
        {
          return;
        }
        if (_derivedCRS == null || _derivedCRS.Equals(value) != true)
        {
          _derivedCRS = value;
          OnPropertyChanged("DerivedCRS");
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