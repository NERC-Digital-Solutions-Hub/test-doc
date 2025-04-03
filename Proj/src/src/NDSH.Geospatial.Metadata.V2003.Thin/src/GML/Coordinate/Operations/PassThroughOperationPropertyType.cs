
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
  /// gml:PassThroughOperationPropertyType is a property type for association roles to a pass through operation, either referencing or containing the definition of that pass through operation.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PassThroughOperationPropertyType")]
  public class PassThroughOperationPropertyType : Model
  {
    #region Private fields
    private PassThroughOperationType _passThroughOperation;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// PassThroughOperationPropertyType class constructor
    /// </summary>
    public PassThroughOperationPropertyType()
    {
      _passThroughOperation = new PassThroughOperationType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("PassThroughOperation", Order = 0)]
    public PassThroughOperationType PassThroughOperation
    {
      get
      {
        return _passThroughOperation;
      }
      set
      {
        if (_passThroughOperation == value)
        {
          return;
        }
        if (_passThroughOperation == null || _passThroughOperation.Equals(value) != true)
        {
          _passThroughOperation = value;
          OnPropertyChanged("PassThroughOperation");
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