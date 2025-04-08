
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
// <element name="OperationParameterGroup" type="gml:OperationParameterGroupType" substitutionGroup="gml:AbstractGeneralOperationParameter">
//   <annotation>
//     <documentation>
//       gml:OperationParameterGroup is the definition of a group of parameters used by an operation method.
//       This complex type is expected to be used or extended for all applicable operation methods,
//       without defining operation-method-specialized element names.
//       The generalOperationParameter elements are an unordered list of associations to the
//       set of operation parameters that are members of this group.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="OperationParameterGroupType">
//   <complexContent>
//     <extension base="gml:AbstractGeneralOperationParameterType">
//       <sequence>
//         <element ref="gml:maximumOccurs" minOccurs="0"/>
//         <element ref="gml:generalOperationParameter" minOccurs="2" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="OperationParameterGroupPropertyType">
//   <annotation>
//     <documentation>
//       gml:OperationParameterPropertyType is a property type for association roles to an operation parameter group,
//       either referencing or containing the definition of that parameter group.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:OperationParameterGroup"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
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

  //[XmlInclude(typeof(ML_OperationParameterGroup_Type))] // GMX
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
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
