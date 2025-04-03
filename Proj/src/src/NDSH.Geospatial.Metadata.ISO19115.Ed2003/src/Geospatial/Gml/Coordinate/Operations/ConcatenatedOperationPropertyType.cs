
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
// <element name="ConcatenatedOperation" type="gml:ConcatenatedOperationType" substitutionGroup="gml:AbstractCoordinateOperation"/>
// <complexType name="ConcatenatedOperationType">
//   <annotation>
//     <documentation>
//       gml:ConcatenatedOperation is an ordered sequence of two or more coordinate operations.
//       This sequence of operations is constrained by the requirement that the source coordinate reference system
//       of step (n+1) must be the same as the target coordinate reference system of step (n).
//       The source coordinate reference system of the first step and the target coordinate reference system
//       of the last step are the source and target coordinate reference system associated with the concatenated operation.
//       Instead of a forward operation, an inverse operation may be used for one or more of the operation steps mentioned above,
//       if the inverse operation is uniquely defined by the forward operation.
//       The gml:coordOperation property elements are an ordered sequence of associations to the two or more operations used by
//       this concatenated operation. The AggregationAttributeGroup should be used to specify that the coordOperation associations are ordered.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractCoordinateOperationType">
//       <sequence>
//         <element ref="gml:coordOperation" minOccurs="2" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="ConcatenatedOperationPropertyType">
//   <annotation>
//     <documentation>
//       gml:ConcatenatedOperationPropertyType is a property type for association roles to a concatenated operation,
//       either referencing or containing the definition of that concatenated operation.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:ConcatenatedOperation"/>
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
  /// gml:ConcatenatedOperationPropertyType is a property type for association roles to a concatenated operation,
  /// either referencing or containing the definition of that concatenated operation.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConcatenatedOperationPropertyType")]
  public class ConcatenatedOperationPropertyType : ObservableModel {

    #region Private fields
    private ConcatenatedOperationType _concatenatedOperation;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// ConcatenatedOperationPropertyType class constructor
    /// </summary>
    public ConcatenatedOperationPropertyType() {
      _concatenatedOperation = default; // new ConcatenatedOperationType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("ConcatenatedOperation", Order = 0)]
    public ConcatenatedOperationType ConcatenatedOperation {
      get {
        return _concatenatedOperation;
      }
      set {
        if (_concatenatedOperation == value) {
          return;
        }
        if (_concatenatedOperation == null || _concatenatedOperation.Equals(value) != true) {
          _concatenatedOperation = value;
          OnPropertyChanged("ConcatenatedOperation");
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
