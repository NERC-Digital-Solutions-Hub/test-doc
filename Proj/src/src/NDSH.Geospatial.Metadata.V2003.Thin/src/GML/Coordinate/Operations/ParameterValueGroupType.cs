
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


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ParameterValueGroupType")]
  public class ParameterValueGroupType : AbstractGeneralParameterValueType
  {
    #region Private fields
    private List<AbstractGeneralParameterValuePropertyType> _parameterValue;
    private OperationParameterGroupPropertyType _group;
    #endregion

    /// <summary>
    /// ParameterValueGroupType class constructor
    /// </summary>
    public ParameterValueGroupType()
    {
      _group = new OperationParameterGroupPropertyType();
      _parameterValue = new List<AbstractGeneralParameterValuePropertyType>();
    }

    [XmlElement("parameterValue", Order = 0)]
    [Required()]
    [JsonProperty("parameterValue", Order = 0)]
    public List<AbstractGeneralParameterValuePropertyType> parameterValue
    {
      get
      {
        return _parameterValue;
      }
      set
      {
        if (_parameterValue == value)
        {
          return;
        }
        if (_parameterValue == null || _parameterValue.Equals(value) != true)
        {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "parameterValue";
          Validator.ValidateProperty(value, validatorPropContext);
          _parameterValue = value;
          OnPropertyChanged("parameterValue");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("group", Order = 1)]
    public OperationParameterGroupPropertyType group
    {
      get
      {
        return _group;
      }
      set
      {
        if (_group == value)
        {
          return;
        }
        if (_group == null || _group.Equals(value) != true)
        {
          _group = value;
          OnPropertyChanged("group");
        }
      }
    }
  }
}