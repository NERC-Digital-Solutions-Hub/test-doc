
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations
{


  /// <summary>
  /// gml:AbstractGeneralOperationParameterPropertyType is a property type for association roles to an operation parameter or group, either referencing or containing the definition of that parameter or group.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralOperationParameterPropertyType")]
  public class AbstractGeneralOperationParameterPropertyType : Model
  {
    #region Private fields
    private AbstractGeneralOperationParameterType _abstractGeneralOperationParameter;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractGeneralOperationParameter", Order = 0)]
    public AbstractGeneralOperationParameterType AbstractGeneralOperationParameter
    {
      get
      {
        return _abstractGeneralOperationParameter;
      }
      set
      {
        if (_abstractGeneralOperationParameter == value)
        {
          return;
        }
        if (_abstractGeneralOperationParameter == null || _abstractGeneralOperationParameter.Equals(value) != true)
        {
          _abstractGeneralOperationParameter = value;
          OnPropertyChanged("AbstractGeneralOperationParameter");
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