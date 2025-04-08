
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
// <element name="AbstractGeneralOperationParameter" type="gml:AbstractGeneralOperationParameterType" abstract="true" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>gml:GeneralOperationParameter is the abstract definition of a parameter or group of parameters used by an operation method.</documentation>
//   </annotation>
// </element>
// <complexType name="AbstractGeneralOperationParameterType" abstract="true">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:minimumOccurs" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="AbstractGeneralOperationParameterPropertyType">
//   <annotation>
//     <documentation>gml:AbstractGeneralOperationParameterPropertyType is a property type for association roles to an operation parameter or group, either referencing or containing the definition of that parameter or group.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractGeneralOperationParameter"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(ML_OperationParameter_Type))] // GMX
  //[XmlInclude(typeof(ML_OperationParameterGroup_Type))] // GMX
  //[XmlInclude(typeof(OperationParameterAlt_Type))] // GMX
  //[XmlInclude(typeof(OperationParameterGroupType))]
  //[XmlInclude(typeof(OperationParameterType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeneralOperationParameterType")]
  public abstract class AbstractGeneralOperationParameterType : IdentifiedObjectType {

    #region Private fields
    private string _minimumOccurs;
    #endregion

    [XmlElement(DataType = "nonNegativeInteger", Order = 0)]
    [JsonProperty("minimumOccurs", Order = 0)]
    public string MinimumOccurs {
      get {
        return _minimumOccurs;
      }
      set {
        if (_minimumOccurs == value) {
          return;
        }
        if (_minimumOccurs == null || _minimumOccurs.Equals(value) != true) {
          _minimumOccurs = value;
          OnPropertyChanged("MinimumOccurs");
        }
      }
    }

  }

}
