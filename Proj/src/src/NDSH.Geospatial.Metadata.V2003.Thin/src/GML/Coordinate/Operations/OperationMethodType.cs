using NDSH.Geospatial.Metadata.V2003.Thin.GML.BasicTypes;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.ReferenceSystems;
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

  [XmlInclude(typeof(ML_OperationMethod_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationMethodType")]
  public class OperationMethodType : IdentifiedObjectType
  {
    #region Private fields
    private CodeType _formula;
    private string _sourceDimensions;
    private string _targetDimensions;
    private List<AbstractGeneralOperationParameterPropertyType> _generalOperationParameter;
    #endregion

    /// <summary>
    /// OperationMethodType class constructor
    /// </summary>
    public OperationMethodType()
    {
      _generalOperationParameter = default; //  new List<AbstractGeneralOperationParameterPropertyType>();
      _formula = default; //  new CodeType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("formula", Order = 0)]
    public CodeType formula
    {
      get
      {
        return _formula;
      }
      set
      {
        if (_formula == value)
        {
          return;
        }
        if (_formula == null || _formula.Equals(value) != true)
        {
          _formula = value;
          OnPropertyChanged("formula");
        }
      }
    }

    [XmlElement(DataType = "positiveInteger", Order = 1)]
    [JsonProperty("sourceDimensions", Order = 1)]
    public string sourceDimensions
    {
      get
      {
        return _sourceDimensions;
      }
      set
      {
        if (_sourceDimensions == value)
        {
          return;
        }
        if (_sourceDimensions == null || _sourceDimensions.Equals(value) != true)
        {
          _sourceDimensions = value;
          OnPropertyChanged("sourceDimensions");
        }
      }
    }

    [XmlElement(DataType = "positiveInteger", Order = 2)]
    [JsonProperty("targetDimensions", Order = 2)]
    public string targetDimensions
    {
      get
      {
        return _targetDimensions;
      }
      set
      {
        if (_targetDimensions == value)
        {
          return;
        }
        if (_targetDimensions == null || _targetDimensions.Equals(value) != true)
        {
          _targetDimensions = value;
          OnPropertyChanged("targetDimensions");
        }
      }
    }

    [XmlElement("generalOperationParameter", Order = 3)]
    [JsonProperty("generalOperationParameter", Order = 3)]
    public List<AbstractGeneralOperationParameterPropertyType> generalOperationParameter
    {
      get
      {
        return _generalOperationParameter;
      }
      set
      {
        if (_generalOperationParameter == value)
        {
          return;
        }
        if (_generalOperationParameter == null || _generalOperationParameter.Equals(value) != true)
        {
          _generalOperationParameter = value;
          OnPropertyChanged("generalOperationParameter");
        }
      }
    }
  }

}