
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
// <element name="PassThroughOperation" type="gml:PassThroughOperationType" substitutionGroup="gml:AbstractSingleOperation">
//   <annotation>
//     <documentation>
//       gml:PassThroughOperation is a pass-through operation specifies that a subset of a coordinate tuple is
//       subject to a specific coordinate operation.
//       The modifiedCoordinate property elements are an ordered sequence of positive integers defining
//       the positions in a coordinate tuple of the coordinates affected by this pass-through operation.
//       The AggregationAttributeGroup should be used to specify that the modifiedCoordinate elements are ordered.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="PassThroughOperationType">
//   <complexContent>
//     <extension base="gml:AbstractCoordinateOperationType">
//       <sequence>
//         <element ref="gml:modifiedCoordinate" maxOccurs="unbounded"/>
//         <element ref="gml:coordOperation"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="PassThroughOperationPropertyType">
//   <annotation>
//     <documentation>
//       gml:PassThroughOperationPropertyType is a property type for association roles to a pass through operation,
//       either referencing or containing the definition of that pass through operation.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:PassThroughOperation"/>
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
  /// gml:PassThroughOperationPropertyType is a property type for association roles to a pass through operation, either referencing or containing the definition of that pass through operation.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PassThroughOperationPropertyType")]
  public class PassThroughOperationPropertyType : ObservableModel {

    #region Private fields
    private PassThroughOperationType _passThroughOperation;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// PassThroughOperationPropertyType class constructor
    /// </summary>
    public PassThroughOperationPropertyType() {
      _passThroughOperation = default; // new PassThroughOperationType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("PassThroughOperation", Order = 0)]
    public PassThroughOperationType PassThroughOperation {
      get {
        return _passThroughOperation;
      }
      set {
        if (_passThroughOperation == value) {
          return;
        }
        if (_passThroughOperation == null || _passThroughOperation.Equals(value) != true) {
          _passThroughOperation = value;
          OnPropertyChanged("PassThroughOperation");
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
