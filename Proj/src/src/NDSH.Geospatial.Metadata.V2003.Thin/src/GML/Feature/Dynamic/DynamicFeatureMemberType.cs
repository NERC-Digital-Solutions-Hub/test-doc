using NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Feature.Dynamic
{

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DynamicFeatureMemberType")]
  public class DynamicFeatureMemberType : AbstractFeatureMemberType
  {
    #region Private fields
    private List<DynamicFeatureType> _dynamicFeature;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// DynamicFeatureMemberType class constructor
    /// </summary>
    public DynamicFeatureMemberType()
    {
      _dynamicFeature = default; // new List<DynamicFeatureType>();
    }

    [XmlElement("DynamicFeature", Order = 0)]
    [JsonProperty("DynamicFeature", Order = 0)]
    public List<DynamicFeatureType> DynamicFeature
    {
      get
      {
        return _dynamicFeature;
      }
      set
      {
        if (_dynamicFeature == value)
        {
          return;
        }
        if (_dynamicFeature == null || _dynamicFeature.Equals(value) != true)
        {
          _dynamicFeature = value;
          OnPropertyChanged("DynamicFeature");
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