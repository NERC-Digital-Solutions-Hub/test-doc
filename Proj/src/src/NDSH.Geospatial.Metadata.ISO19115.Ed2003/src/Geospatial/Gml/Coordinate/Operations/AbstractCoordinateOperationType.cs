
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 30/01/2023, @gisvlasta
// History           : 17/03/2025, @gisvlasta - Added IsoTypeAttribute, changed type in SourceCRS and targetCRS
//                                               properties, and updated code.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/referenceSystems.xsd
//                     /2005/gml/coordinateOperations.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="domainOfValidity">
//   <annotation>
//     <documentation>
//       The gml:domainOfValidity property implements an association role to an EX_Extent object
//       as encoded in ISO/TS 19139, either referencing or containing the definition of that extent.
//     </documentation>
//   </annotation>
//   <complexType>
//     <sequence minOccurs="0">
//       <element ref="gmd:EX_Extent"/>
//     </sequence>
//     <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   </complexType>
// </element>
// 
// <element name="AbstractCoordinateOperation"
//          type="gml:AbstractCoordinateOperationType" abstract="true" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       gml:AbstractCoordinateOperation is a mathematical operation on coordinates that transforms or
//       converts coordinates to another coordinate reference system. Many but not all coordinate operations
//       (from CRS A to CRS B) also uniquely define the inverse operation (from CRS B to CRS A).
//       In some cases, the operation method algorithm for the inverse operation is the same
//       as for the forward algorithm, but the signs of some operation parameter values shall be reversed.
//       In other cases, different algorithms are required for the forward and inverse operations,
//       but the same operation parameter values are used. If (some) entirely different parameter values are needed,
//       a different coordinate operation shall be defined. The optional coordinateOperationAccuracy
//       property elements provide estimates of the impact of this coordinate operation on point position accuracy.
//     </documentation>
//   </annotation>
// </element>
// 
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
// 
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

using NDSH.Geospatial.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata.Extent;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Operations {

  #region XmlIncludes
  //[XmlInclude(typeof(ML_ConcatenatedOperation_Type))] // GMX
  //[XmlInclude(typeof(ML_Conversion_Type))] // GMX
  //[XmlInclude(typeof(ML_PassThroughOperation_Type))] // GMX
  //[XmlInclude(typeof(ML_Transformation_Type))] // GMX
  //[XmlInclude(typeof(OperationAlt_Type))] // GMX
  //[XmlInclude(typeof(PassThroughOperationType))]
  //[XmlInclude(typeof(ConcatenatedOperationType))]
  //[XmlInclude(typeof(AbstractGeneralTransformationType))]
  //[XmlInclude(typeof(TransformationType))]
  //[XmlInclude(typeof(AbstractGeneralConversionType))]
  //[XmlInclude(typeof(ConversionType))]
  #endregion

  [IsoType("AbstractCoordinateOperationType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType("AbstractCoordinateOperationType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCoordinateOperationType")]
  public abstract class AbstractCoordinateOperationType : IdentifiedObjectType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractCoordinateOperationType"/>.
    /// </summary>
    public AbstractCoordinateOperationType() {
      _domainOfValidity = default; //  new domainOfValidity();
      _scope = default; //  new List<string>();
      _coordinateOperationAccuracy = default; //  new List<coordinateOperationAccuracy>();
      _sourceCRS = default; //  new CRSPropertyType();
      _targetCRS = default; //  new CRSPropertyType();
    }

    #endregion

    #region Public Properties

    private EX_Extent_Type _domainOfValidity;

    //[XmlElement("domainOfValidity", Order = 0)]
    [JsonProperty("domainOfValidity", Order = 0)]
    public EX_Extent_Type DomainOfValidity {
      get => _domainOfValidity;
      set => SetProperty(ref _domainOfValidity, value);
    }

    private ObservableCollection<string> _scope;

    //[XmlElement("scope", Order = 1)]
    [JsonProperty("scope", Order = 1)]
    public ObservableCollection<string> Scope {
      get => _scope;
      set => SetProperty(ref _scope, value);
    }

    private string _operationVersion;

    //[XmlElement("operationVersion", Order = 2)]
    [JsonProperty("operationVersion", Order = 2)]
    public string OperationVersion {
      get => _operationVersion;
      set => SetProperty(ref _operationVersion, value);
    }

    private ObservableCollection<CoordinateOperationAccuracy> _coordinateOperationAccuracy;

    //[XmlElement("coordinateOperationAccuracy", Order = 3)]
    [JsonProperty("coordinateOperationAccuracy", Order = 3)]
    public ObservableCollection<CoordinateOperationAccuracy> CoordinateOperationAccuracy {
      get => _coordinateOperationAccuracy;
      set => SetProperty(ref _coordinateOperationAccuracy, value);
    }

    private AbstractCRSType _sourceCRS;

    //[XmlElement("sourceCRS", Order = 4)]
    [JsonProperty("sourceCRS", Order = 4)]
    public AbstractCRSType SourceCRS {
      get => _sourceCRS;
      set => SetProperty(ref _sourceCRS, value);
    }

    private AbstractCRSType _targetCRS;

    //[XmlElement("targetCRS", Order = 5)]
    [JsonProperty("targetCRS", Order = 5)]
    public AbstractCRSType TargetCRS {
      get => _targetCRS;
      set => SetProperty(ref _targetCRS, value);
    }

    #endregion

  }

}
