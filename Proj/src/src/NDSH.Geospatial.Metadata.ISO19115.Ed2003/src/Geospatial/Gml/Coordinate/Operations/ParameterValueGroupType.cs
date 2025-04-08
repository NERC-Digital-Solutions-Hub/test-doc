
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateOperations.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="ParameterValueGroup" type="gml:ParameterValueGroupType" substitutionGroup="gml:AbstractGeneralParameterValue">
//   <annotation>
//     <documentation>
//       gml:ParameterValueGroup is a group of related parameter values.
//       The same group can be repeated more than once in a Conversion, Transformation,
//       or higher level ParameterValueGroup, if those instances contain different values of one or
//       more parameterValues which suitably distinquish among those groups. This concrete complex type can
//       be used for operation methods without using an Application Schema that defines operation-method-specialized
//       element names and contents. This complex type may be used, extended, or restricted for well-known operation methods,
//       especially for methods with only one instance.
//       The parameterValue elements are an unordered set of composition association roles to the parameter values
//       and groups of values included in this group.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="ParameterValueGroupType">
//   <complexContent>
//     <extension base="gml:AbstractGeneralParameterValueType">
//       <sequence>
//         <element ref="gml:parameterValue" minOccurs="2" maxOccurs="unbounded"/>
//         <element ref="gml:group"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ParameterValueGroupType")]
  public class ParameterValueGroupType : AbstractGeneralParameterValueType {

    #region Private fields
    private List<AbstractGeneralParameterValuePropertyType> _parameterValue;
    private OperationParameterGroupPropertyType _group;
    #endregion

    /// <summary>
    /// ParameterValueGroupType class constructor
    /// </summary>
    public ParameterValueGroupType() {
      _group = new OperationParameterGroupPropertyType();
      _parameterValue = new List<AbstractGeneralParameterValuePropertyType>();
    }

    [XmlElement("parameterValue", Order = 0)]
    [Required()]
    [JsonProperty("parameterValue", Order = 0)]
    public List<AbstractGeneralParameterValuePropertyType> ParameterValue {
      get {
        return _parameterValue;
      }
      set {
        if (_parameterValue == value) {
          return;
        }
        if (_parameterValue == null || _parameterValue.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "ParameterValue";
          Validator.ValidateProperty(value, validatorPropContext);
          _parameterValue = value;
          OnPropertyChanged("ParameterValue");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("group", Order = 1)]
    public OperationParameterGroupPropertyType Group {
      get {
        return _group;
      }
      set {
        if (_group == value) {
          return;
        }
        if (_group == null || _group.Equals(value) != true) {
          _group = value;
          OnPropertyChanged("Group");
        }
      }
    }

  }

}
