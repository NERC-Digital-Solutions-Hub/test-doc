
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
// XSD               : /2005/gml/gmlBase.xsd
//                     /2005/gml/coordinateOperations.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="modifiedCoordinate" type="positiveInteger">
//   <annotation>
//     <documentation>gml:modifiedCoordinate is a positive integer defining a position in a coordinate tuple.</documentation>
//   </annotation>
// </element>
//
// <element name="coordOperation" type="gml:CoordinateOperationPropertyType">
//   <annotation>
//     <documentation>gml:coordOperation is an association role to a coordinate operation.</documentation>
//   </annotation>
// </element>
//
// <element name="usesSingleOperation" type="gml:CoordinateOperationPropertyType" substitutionGroup="gml:coordOperation">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <attributeGroup name="AggregationAttributeGroup">
//   <annotation>
//     <documentation>
//       A GML Object Collection is any GML Object with a property element in its content model whose content model is derived by extension from gml:AbstractMemberType.
//       In addition, the complex type describing the content model of the GML Object Collection may also include a reference to the attribute group gml:AggregationAttributeGroup to provide additional information about the semantics of the object collection.  This information may be used by applications to group GML objects, and optionally to order and index them.
//       The allowed values for the aggregationType attribute are defined by gml:AggregationType. See 8.4 of ISO/IEC 11404:1996 for the meaning of the values in the enumeration.
//     </documentation>
//   </annotation>
//   <attribute name="aggregationType" type="gml:AggregationType"/>
// </attributeGroup>
// 
// <simpleType name="AggregationType" final="#all">
//   <restriction base="string">
//     <enumeration value="set"/>
//     <enumeration value="bag"/>
//     <enumeration value="sequence"/>
//     <enumeration value="array"/>
//     <enumeration value="record"/>
//     <enumeration value="table"/>
//   </restriction>
// </simpleType>
// 
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
// 
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
// 
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
  /// gml:PassThroughOperation is a pass-through operation specifies that a subset of a coordinate tuple is
  /// subject to a specific coordinate operation.
  /// The modifiedCoordinate property elements are an ordered sequence of positive integers defining
  /// the positions in a coordinate tuple of the coordinates affected by this pass-through operation.
  /// The AggregationAttributeGroup should be used to specify that the modifiedCoordinate elements are ordered.
  /// </summary>
  /// <remarks>
  /// Maps to <c>PassThroughOperationType</c> ( /2005/gml/coordinateOperations.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_PassThroughOperation_Type))] // GMX
  [IsoType("PassThroughOperationType", WrapperName = "PassThroughOperationPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PassThroughOperationType")]
  public class PassThroughOperationType : AbstractCoordinateOperationType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes <see cref="PassThroughOperationType"/>.
    /// </summary>
    public PassThroughOperationType() {
      _coordOperation = default; //  new CoordinateOperationPropertyType();
      _modifiedCoordinate = default; //  new List<string>();
    }

    #endregion

    #region Public Properties

    private List<string> _modifiedCoordinate;

    /// <summary>
    /// gml:modifiedCoordinate is a positive integer defining a position in a coordinate tuple.
    /// </summary>
    // [XmlElement("modifiedCoordinate", DataType = "positiveInteger", Order = 0)]
    [JsonProperty("modifiedCoordinate", Order = 0)]
    public List<string> ModifiedCoordinate {
      get => _modifiedCoordinate;
      set => SetProperty(ref _modifiedCoordinate, value, "ModifiedCoordinate");
    }

    private CoordinateOperationPropertyType _coordOperation;

    /// <summary>
    /// gml:coordOperation is an association role to a coordinate operation.
    /// </summary>
    // [XmlElement(Order = 1)]
    [JsonProperty("coordOperation", Order = 1)]
    public CoordinateOperationPropertyType CoordOperation {
      get => _coordOperation;
      set => SetProperty(ref _coordOperation, value, "CoordOperation");
    }

    private AggregationType _aggregationType;

    /// <summary>
    /// A GML Object Collection is any GML Object with a property element in its content model whose content model is derived by extension from gml:AbstractMemberType.
    /// In addition, the complex type describing the content model of the GML Object Collection may also include a reference to the attribute group gml:AggregationAttributeGroup to provide additional information about the semantics of the object collection.  This information may be used by applications to group GML objects, and optionally to order and index them.
    /// The allowed values for the aggregationType attribute are defined by gml:AggregationType. See 8.4 of ISO/IEC 11404:1996 for the meaning of the values in the enumeration.
    /// </summary>
    // [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get => _aggregationType;
      // TODO: SetProperty
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }

    #endregion
  }

}
