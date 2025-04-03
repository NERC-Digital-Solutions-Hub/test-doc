
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
  /// gml:CoordinateOperationPropertyType is a property type for association roles to a coordinate operation, either referencing or containing the definition of that coordinate operation.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoordinateOperationPropertyType")]
  public class CoordinateOperationPropertyType : Model
  {
    #region Private fields
    private AbstractCoordinateOperationType _abstractCoordinateOperation;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractCoordinateOperation", Order = 0)]
    public AbstractCoordinateOperationType AbstractCoordinateOperation
    {
      get
      {
        return _abstractCoordinateOperation;
      }
      set
      {
        if (_abstractCoordinateOperation == value)
        {
          return;
        }
        if (_abstractCoordinateOperation == null || _abstractCoordinateOperation.Equals(value) != true)
        {
          _abstractCoordinateOperation = value;
          OnPropertyChanged("AbstractCoordinateOperation");
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