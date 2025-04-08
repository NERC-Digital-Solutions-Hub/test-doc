using NDSH.Geospatial.Metadata.V2003.Thin.GML.ReferenceSystems;
using NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual;
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

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(ML_OperationParameter_Type))] // GMX
  [XmlInclude(typeof(ML_OperationParameterGroup_Type))] // GMX
  [XmlInclude(typeof(OperationParameterAlt_Type))] // GMX
  [XmlInclude(typeof(OperationParameterGroupType))]
  [XmlInclude(typeof(OperationParameterType))]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralOperationParameterType")]
  public abstract class AbstractGeneralOperationParameterType : IdentifiedObjectType
  {
    #region Private fields
    private string _minimumOccurs;
    #endregion

    [XmlElement(DataType = "nonNegativeInteger", Order = 0)]
    [JsonProperty("minimumOccurs", Order = 0)]
    public string MinimumOccurs
    {
      get
      {
        return _minimumOccurs;
      }
      set
      {
        if (_minimumOccurs == value)
        {
          return;
        }
        if (_minimumOccurs == null || _minimumOccurs.Equals(value) != true)
        {
          _minimumOccurs = value;
          OnPropertyChanged("minimumOccurs");
        }
      }
    }
  }

}