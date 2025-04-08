
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

using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  /// <summary>
  /// gml:OperationParameterPropertyType is a property type for association roles to an operation parameter group, either referencing or containing the definition of that parameter group.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationParameterGroupPropertyType")]
  public class OperationParameterGroupPropertyType : ObservableModel {

    #region Private fields
    private OperationParameterGroupType _operationParameterGroup;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// OperationParameterGroupPropertyType class constructor
    /// </summary>
    public OperationParameterGroupPropertyType() {
      _operationParameterGroup = default; // new OperationParameterGroupType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("OperationParameterGroup", Order = 0)]
    public OperationParameterGroupType OperationParameterGroup {
      get {
        return _operationParameterGroup;
      }
      set {
        if (_operationParameterGroup == value) {
          return;
        }
        if (_operationParameterGroup == null || _operationParameterGroup.Equals(value) != true) {
          _operationParameterGroup = value;
          OnPropertyChanged("OperationParameterGroup");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("RemoteSchema");
        }
      }
    }

  }

}
