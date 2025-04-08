
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
  /// gml:OperationMethodPropertyType is a property type for association roles to a concrete general-purpose
  /// operation method, either referencing or containing the definition of that method.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OperationMethodPropertyType")]
  public class OperationMethodPropertyType : ObservableModel {

    #region Private fields
    private OperationMethodType _operationMethod;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// OperationMethodPropertyType class constructor
    /// </summary>
    public OperationMethodPropertyType() {
      _operationMethod = default; // new OperationMethodType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("OperationMethod", Order = 0)]
    public OperationMethodType OperationMethod {
      get {
        return _operationMethod;
      }
      set {
        if (_operationMethod == value) {
          return;
        }
        if (_operationMethod == null || _operationMethod.Equals(value) != true) {
          _operationMethod = value;
          OnPropertyChanged("OperationMethod");
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
