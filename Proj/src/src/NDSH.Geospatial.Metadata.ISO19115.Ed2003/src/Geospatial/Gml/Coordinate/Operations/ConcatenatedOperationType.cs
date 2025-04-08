
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

  /// <summary>
  /// gml:ConcatenatedOperation is an ordered sequence of two or more coordinate operations.
  /// This sequence of operations is constrained by the requirement that the source coordinate
  /// reference system of step (n+1) must be the same as the target coordinate reference system of step (n).
  /// The source coordinate reference system of the first step and the target coordinate reference system
  /// of the last step are the source and target coordinate reference system associated with the concatenated operation.
  /// Instead of a forward operation, an inverse operation may be used for one or more of the operation steps
  /// mentioned above, if the inverse operation is uniquely defined by the forward operation.
  /// The gml:coordOperation property elements are an ordered sequence of associations to the two or
  /// more operations used by this concatenated operation. The AggregationAttributeGroup should be used
  /// to specify that the coordOperation associations are ordered.
  /// </summary>
  //[XmlInclude(typeof(ML_ConcatenatedOperation_Type))] // GMX
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConcatenatedOperationType")]
  public class ConcatenatedOperationType : AbstractCoordinateOperationType {

    #region Private fields
    private List<CoordinateOperationPropertyType> _coordOperation;
    private AggregationType _aggregationType;
    #endregion

    /// <summary>
    /// ConcatenatedOperationType class constructor
    /// </summary>
    public ConcatenatedOperationType() {
      _coordOperation = default; //  new List<CoordinateOperationPropertyType>();
    }

    [XmlElement("coordOperation", Order = 0)]
    [Required()]
    [JsonProperty("coordOperation", Order = 0)]
    public List<CoordinateOperationPropertyType> CoordOperation {
      get {
        return _coordOperation;
      }
      set {
        if (_coordOperation == value) {
          return;
        }
        if (_coordOperation == null || _coordOperation.Equals(value) != true) {
          ValidationContext validatorPropContext = new ValidationContext(this, null, null);
          validatorPropContext.MemberName = "CoordOperation";
          Validator.ValidateProperty(value, validatorPropContext);
          _coordOperation = value;
          OnPropertyChanged("CoordOperation");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get {
        return _aggregationType;
      }
      set {
        if (_aggregationType.Equals(value) != true) {
          _aggregationType = value;
          OnPropertyChanged("AggregationType");
        }
      }
    }

  }

}
