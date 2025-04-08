
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
// <element name="OperationMethod" type="gml:OperationMethodType" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       gml:OperationMethod is a method (algorithm or procedure) used to perform a coordinate operation.
//       Most operation methods use a number of operation parameters, although some coordinate conversions use none.
//       Each coordinate operation using the method assigns values to these parameters.
//       The generalOperationParameter elements are an unordered list of associations to the
//       set of operation parameters and parameter groups used by this operation method.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="OperationMethodType">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:formula"/>
//         <element ref="gml:sourceDimensions" minOccurs="0"/>
//         <element ref="gml:targetDimensions" minOccurs="0"/>
//         <element ref="gml:generalOperationParameter" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="OperationMethodPropertyType">
//   <annotation>
//     <documentation>
//       gml:OperationMethodPropertyType is a property type for association roles to a concrete general-purpose operation method,
//       either referencing or containing the definition of that method.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:OperationMethod"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  //[XmlInclude(typeof(ML_OperationMethod_Type))] // GMX
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationMethodType")]
  public class OperationMethodType : IdentifiedObjectType {

    #region Private fields
    private CodeType _formula;
    private string _sourceDimensions;
    private string _targetDimensions;
    private List<AbstractGeneralOperationParameterPropertyType> _generalOperationParameter;
    #endregion

    /// <summary>
    /// OperationMethodType class constructor
    /// </summary>
    public OperationMethodType() {
      _generalOperationParameter = default; //  new List<AbstractGeneralOperationParameterPropertyType>();
      _formula = default; //  new CodeType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("formula", Order = 0)]
    public CodeType Formula {
      get {
        return _formula;
      }
      set {
        if (_formula == value) {
          return;
        }
        if (_formula == null || _formula.Equals(value) != true) {
          _formula = value;
          OnPropertyChanged("Formula");
        }
      }
    }

    [XmlElement(DataType = "positiveInteger", Order = 1)]
    [JsonProperty("sourceDimensions", Order = 1)]
    public string SourceDimensions {
      get {
        return _sourceDimensions;
      }
      set {
        if (_sourceDimensions == value) {
          return;
        }
        if (_sourceDimensions == null || _sourceDimensions.Equals(value) != true) {
          _sourceDimensions = value;
          OnPropertyChanged("SourceDimensions");
        }
      }
    }

    [XmlElement(DataType = "positiveInteger", Order = 2)]
    [JsonProperty("targetDimensions", Order = 2)]
    public string TargetDimensions {
      get {
        return _targetDimensions;
      }
      set {
        if (_targetDimensions == value) {
          return;
        }
        if (_targetDimensions == null || _targetDimensions.Equals(value) != true) {
          _targetDimensions = value;
          OnPropertyChanged("TargetDimensions");
        }
      }
    }

    [XmlElement("generalOperationParameter", Order = 3)]
    [JsonProperty("generalOperationParameter", Order = 3)]
    public List<AbstractGeneralOperationParameterPropertyType> GeneralOperationParameter {
      get {
        return _generalOperationParameter;
      }
      set {
        if (_generalOperationParameter == value) {
          return;
        }
        if (_generalOperationParameter == null || _generalOperationParameter.Equals(value) != true) {
          _generalOperationParameter = value;
          OnPropertyChanged("GeneralOperationParameter");
        }
      }
    }

  }

}
