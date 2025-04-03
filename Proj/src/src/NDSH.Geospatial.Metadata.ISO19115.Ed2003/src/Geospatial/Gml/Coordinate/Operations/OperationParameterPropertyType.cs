
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
// <element name="OperationParameter" type="gml:OperationParameterType" substitutionGroup="gml:AbstractGeneralOperationParameter">
//   <annotation>
//     <documentation>
//       gml:OperationParameter is the definition of a parameter used by an operation method.
//       Most parameter values are numeric, but other types of parameter values are possible.
//       This complex type is expected to be used or extended for all operation methods,
//       without defining operation-method-specialized element names.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="OperationParameterType">
//   <complexContent>
//     <extension base="gml:AbstractGeneralOperationParameterType">
//       <sequence/>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="OperationParameterPropertyType">
//   <annotation>
//     <documentation>
//       gml:OperationParameterPropertyType is a property type for association roles to an operation parameter,
//       either referencing or containing the definition of that parameter.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:OperationParameter"/>
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
  /// gml:OperationParameterPropertyType is a property type for association roles to an operation parameter, either referencing or containing the definition of that parameter.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationParameterPropertyType")]
  public class OperationParameterPropertyType : ObservableModel {

    #region Private fields
    private OperationParameterType _operationParameter;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// OperationParameterPropertyType class constructor
    /// </summary>
    public OperationParameterPropertyType() {
      _operationParameter = default; // new OperationParameterType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("OperationParameter", Order = 0)]
    public OperationParameterType OperationParameter {
      get {
        return _operationParameter;
      }
      set {
        if (_operationParameter == value) {
          return;
        }
        if (_operationParameter == null || _operationParameter.Equals(value) != true) {
          _operationParameter = value;
          OnPropertyChanged("OperationParameter");
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
