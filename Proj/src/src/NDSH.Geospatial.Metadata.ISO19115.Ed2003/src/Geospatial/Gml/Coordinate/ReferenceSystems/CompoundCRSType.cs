
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 25/03/2025, @gisvlasta
// History           : 30/03/2025, @gisvlasta - Changed the override of the TypeAssociation property
//                                              inherited from AbstractCRSType.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateReferenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="CompoundCRS" type="gml:CompoundCRSType" substitutionGroup="gml:AbstractCRS">
//   <annotation>
//     <documentation>
//       gml:CompundCRS is a coordinate reference system describing the position of points through two
//       or more independent coordinate reference systems. It is associated with a non-repeating
//       sequence of two or more instances of SingleCRS.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="CompoundCRSType">
//   <complexContent>
//     <extension base="gml:AbstractCRSType">
//       <sequence>
//         <element ref="gml:componentReferenceSystem" minOccurs="2" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="CompoundCRSPropertyType">
//   <annotation>
//     <documentation>
//       gml:CompoundCRSPropertyType is a property type for association roles to a compound coordinate reference system,
//       either referencing or containing the definition of that reference system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:CompoundCRS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.ReferenceSystems;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.ReferenceSystems {

  /// <summary>
  /// The <see cref="CompoundCRSType"/> is a coordinate reference system that describes the position of points
  /// through two or more independent coordinate reference systems. It is associated with a non-repeating
  /// sequence of two or more instances of single coordinate reference systems, typically concrete classes
  /// that inherit from <see cref="AbstractSingleCRS"/> and implement the <see cref="ISingleCRS"/> interface.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>CompoundCRSType</c> ( /2005/gml/coordinateReferenceSystems.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_CompoundCRS_Type))] // GMX
  [IsoType("CompoundCRSType", WrapperName = "CompoundCRSPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CompoundCRSType")]
  public class CompoundCRSType : AbstractCRSType, IAggregation {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CompoundCRSType"/>.
    /// </summary>
    public CompoundCRSType() {

    }

    #endregion

    #region Public Properties

    private ObservableCollection<AbstractSingleCRS> _componentReferenceSystem;

    /// <summary>
    /// Gets/Sets the collection of component reference systems
    /// that make up this compound coordinate reference system.
    /// A compound coordinate reference system must contain
    /// a non-repeating sequence of two or more <see cref="ISingleCRS"/>.
    /// </summary>
    /// <remarks>
    /// Corresponds to the XML element <c>gml:componentReferenceSystem</c>.  
    /// This property has <c>minOccurs=2</c> in the GML schema, meaning at least two components are required.
    /// </remarks>
    //[XmlElement("componentReferenceSystem", Order = 0)]
    [Required()]
    [JsonProperty("componentReferenceSystem", Order = 0)]
    // WARNING: This property has minOccurs = 2
    public required ObservableCollection<AbstractSingleCRS> ComponentReferenceSystem {
      get => _componentReferenceSystem;
      set {
        if (_componentReferenceSystem == value) {
          return;
        }
        if (_componentReferenceSystem == null || _componentReferenceSystem.Equals(value) != true) {
          ValidationContext validatorPropContext = new(this, null, null);
          validatorPropContext.MemberName = nameof(ComponentReferenceSystem);
          Validator.ValidateProperty(value, validatorPropContext);
          _componentReferenceSystem = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region IAggregation Interface

    private AggregationType _aggregationType;

    /// <summary>
    /// Gets/Sets the aggregation type indicating how the component reference systems are aggregated.
    /// </summary>
    //[XmlAttribute]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get => _aggregationType;
      set => SetProperty(ref _aggregationType, value);
    }

    #endregion

    #region Public Overrides

    private TypeAssociationMetadata? _typeAssociationMetadata;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="CompoundCRSType">compound coordinate reference system</see>.
    /// </summary>
    public override TypeAssociationMetadata? TypeAssociation {
      get => _typeAssociationMetadata;
      set {
        _typeAssociationMetadata = value switch {
          null => null,
          TypeAssociationMetadata.Association => value,
          TypeAssociationMetadata.Reference => throw new InvalidOperationException(
            $"{nameof(ReferenceEntity)} is not allowed in this context. Only {nameof(AssociationEntity)} is supported." // RESOURCE
          ),
          TypeAssociationMetadata.NilReason => throw new InvalidOperationException(
            $"{nameof(NilReasonEntity)} is not allowed in this context. Only {nameof(AssociationEntity)} is supported." // RESOURCE
          ),
          _ => throw new ArgumentException(
            $"Unsupported subtype of {nameof(TypeAssociationMetadata)}: {value.GetType().Name}" // RESOURCE
          ),
        };
      }
    }

    #endregion

  }

}
