
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Operations {

  [XmlInclude(typeof(ML_OperationParameterGroup_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationParameterGroupType")]
  public class OperationParameterGroupType : AbstractGeneralOperationParameterType {

    #region Private fields
    private string _maximumOccurs;
    private List<AbstractGeneralOperationParameterPropertyType> _generalOperationParameter;
    #endregion

    /// <summary>
    /// OperationParameterGroupType class constructor
    /// </summary>
    public OperationParameterGroupType() {
      _generalOperationParameter = default; //  new List<AbstractGeneralOperationParameterPropertyType>();
    }

    [XmlElement(DataType = "positiveInteger", Order = 0)]
    [JsonProperty("maximumOccurs", Order = 0)]
    public string MaximumOccurs {
      get {
        return _maximumOccurs;
      }
      set {
        if (_maximumOccurs == value) {
          return;
        }
        if (_maximumOccurs == null || _maximumOccurs.Equals(value) != true) {
          _maximumOccurs = value;
          OnPropertyChanged("MaximumOccurs");
        }
      }
    }

    [XmlElement("generalOperationParameter", Order = 1)]
    [Required()]
    [JsonProperty("generalOperationParameter", Order = 1)]
    public List<AbstractGeneralOperationParameterPropertyType> GeneralOperationParameter {
      get {
        return _generalOperationParameter;
      }
      set {
        if (_generalOperationParameter == value) {
          return;
        }
        if (_generalOperationParameter == null || _generalOperationParameter.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "GeneralOperationParameter";
          Validator.ValidateProperty(value, validatorPropContext);
          _generalOperationParameter = value;
          OnPropertyChanged("GeneralOperationParameter");
        }
      }
    }

  }

}
