
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
  /// gml:AbstractGeneralParameterValuePropertyType is a  property type for inline association roles to a parameter value or group of parameter values, always containing the values.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralParameterValuePropertyType")]
  public class AbstractGeneralParameterValuePropertyType : Model
  {
    #region Private fields
    private AbstractGeneralParameterValueType _abstractGeneralParameterValue;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractGeneralParameterValue", Order = 0)]
    public AbstractGeneralParameterValueType AbstractGeneralParameterValue
    {
      get
      {
        return _abstractGeneralParameterValue;
      }
      set
      {
        if (_abstractGeneralParameterValue == value)
        {
          return;
        }
        if (_abstractGeneralParameterValue == null || _abstractGeneralParameterValue.Equals(value) != true)
        {
          _abstractGeneralParameterValue = value;
          OnPropertyChanged("AbstractGeneralParameterValue");
        }
      }
    }
  }
}