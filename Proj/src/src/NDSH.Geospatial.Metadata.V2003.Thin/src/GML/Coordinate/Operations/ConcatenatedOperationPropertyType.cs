
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
  /// gml:ConcatenatedOperationPropertyType is a property type for association roles to a concatenated operation, either referencing or containing the definition of that concatenated operation.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConcatenatedOperationPropertyType")]
  public class ConcatenatedOperationPropertyType : Model
  {
    #region Private fields
    private ConcatenatedOperationType _concatenatedOperation;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ConcatenatedOperationPropertyType class constructor
    /// </summary>
    public ConcatenatedOperationPropertyType()
    {
      _concatenatedOperation = new ConcatenatedOperationType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("ConcatenatedOperation", Order = 0)]
    public ConcatenatedOperationType ConcatenatedOperation
    {
      get
      {
        return _concatenatedOperation;
      }
      set
      {
        if (_concatenatedOperation == value)
        {
          return;
        }
        if (_concatenatedOperation == null || _concatenatedOperation.Equals(value) != true)
        {
          _concatenatedOperation = value;
          OnPropertyChanged("ConcatenatedOperation");
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