using NDSH.Geospatial.Metadata.V2003.Thin.GML.GmlBase;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations
{

  [XmlInclude(typeof(ML_PassThroughOperation_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PassThroughOperationType")]
  public class PassThroughOperationType : AbstractCoordinateOperationType
  {
    #region Private fields
    private List<string> _modifiedCoordinate;
    private CoordinateOperationPropertyType _coordOperation;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// PassThroughOperationType class constructor
    /// </summary>
    public PassThroughOperationType()
    {
      _coordOperation = default; //  new CoordinateOperationPropertyType();
      _modifiedCoordinate = default; //  new List<string>();
    }

    [XmlElement("modifiedCoordinate", DataType = "positiveInteger", Order = 0)]
    [JsonProperty("modifiedCoordinate", Order = 0)]
    public List<string> modifiedCoordinate
    {
      get
      {
        return _modifiedCoordinate;
      }
      set
      {
        if (_modifiedCoordinate == value)
        {
          return;
        }
        if (_modifiedCoordinate == null || _modifiedCoordinate.Equals(value) != true)
        {
          _modifiedCoordinate = value;
          OnPropertyChanged("modifiedCoordinate");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("coordOperation", Order = 1)]
    public CoordinateOperationPropertyType coordOperation
    {
      get
      {
        return _coordOperation;
      }
      set
      {
        if (_coordOperation == value)
        {
          return;
        }
        if (_coordOperation == null || _coordOperation.Equals(value) != true)
        {
          _coordOperation = value;
          OnPropertyChanged("coordOperation");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType aggregationType
    {
      get
      {
        return _aggregationType;
      }
      set
      {
        if (_aggregationType.Equals(value) != true)
        {
          _aggregationType = value;
          OnPropertyChanged("aggregationType");
        }
      }
    }
  }

}