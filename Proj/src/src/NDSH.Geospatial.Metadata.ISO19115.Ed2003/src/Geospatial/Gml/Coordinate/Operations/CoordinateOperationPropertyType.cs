
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
// <element name="AbstractCoordinateOperation" type="gml:AbstractCoordinateOperationType" abstract="true" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       gml:AbstractCoordinateOperation is a mathematical operation on coordinates that transforms or converts coordinates to another coordinate reference system.
//       Many but not all coordinate operations (from CRS A to CRS B) also uniquely define the inverse operation (from CRS B to CRS A).
//       In some cases, the operation method algorithm for the inverse operation is the same as for the forward algorithm,
//       but the signs of some operation parameter values shall be reversed. In other cases, different algorithms are required for the forward and inverse operations,
//       but the same operation parameter values are used. If (some) entirely different parameter values are needed, a different coordinate operation shall be defined.
//       The optional coordinateOperationAccuracy property elements provide estimates of the impact of this coordinate operation on point position accuracy.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="AbstractCoordinateOperationType" abstract="true">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:domainOfValidity" minOccurs="0"/>
//         <element ref="gml:scope" maxOccurs="unbounded"/>
//         <element ref="gml:operationVersion" minOccurs="0"/>
//         <element ref="gml:coordinateOperationAccuracy" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:sourceCRS" minOccurs="0"/>
//         <element ref="gml:targetCRS" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="CoordinateOperationPropertyType">
//   <annotation>
//     <documentation>
//       gml:CoordinateOperationPropertyType is a property type for association roles to a coordinate operation,
//       either referencing or containing the definition of that coordinate operation.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractCoordinateOperation"/>
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
  /// gml:CoordinateOperationPropertyType is a property type for association roles to a coordinate operation,
  /// either referencing or containing the definition of that coordinate operation.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CoordinateOperationPropertyType")]
  public class CoordinateOperationPropertyType : ObservableModel {

    #region Private fields
    private AbstractCoordinateOperationType _abstractCoordinateOperation;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("AbstractCoordinateOperation", Order = 0)]
    public AbstractCoordinateOperationType AbstractCoordinateOperation {
      get {
        return _abstractCoordinateOperation;
      }
      set {
        if (_abstractCoordinateOperation == value) {
          return;
        }
        if (_abstractCoordinateOperation == null || _abstractCoordinateOperation.Equals(value) != true) {
          _abstractCoordinateOperation = value;
          OnPropertyChanged("AbstractCoordinateOperation");
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
