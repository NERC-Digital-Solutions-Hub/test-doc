
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 27/12/2022, @gisvlasta
// History           : 21/03/2025, @gisvlasta - Added IAssociated interface,
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coordinateSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="AbstractCoordinateSystem"
//          type="gml:AbstractCoordinateSystemType" abstract="true" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       gml:AbstractCoordinateSystem is a coordinate system (CS) is the non-repeating sequence of
//       coordinate system axes that spans a given coordinate space. A CS is derived from a set of
//       mathematical rules for specifying how coordinates in a given space are to be assigned to points.
//       The coordinate values in a coordinate tuple shall be recorded in the order in which
//       the coordinate system axes associations are recorded. This abstract complex type shall not be used,
//       extended, or restricted, in an Application Schema, to define a concrete subtype with a meaning equivalent
//       to a concrete subtype specified in this document.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="AbstractCoordinateSystemType" abstract="true">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:axis" maxOccurs="unbounded"/>
//       </sequence>
//       <attributeGroup ref="gml:AggregationAttributeGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="CoordinateSystemPropertyType">
//   <annotation>
//     <documentation>
//       gml:CoordinateSystemPropertyType is a property type for association roles to a coordinate system, 
//       either referencing or containing the definition of that coordinate system.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractCoordinateSystem"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// 
// <element name="coordinateSystemRef" type="gml:CoordinateSystemPropertyType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Systems {

  #region XmlIncludes
  //[XmlInclude(typeof(ML_AffineCS_Type))] // GMX
  //[XmlInclude(typeof(ML_CartesianCS_Type))] // GMX
  //[XmlInclude(typeof(ML_CylindricalCS_Type))] // GMX
  //[XmlInclude(typeof(ML_EllipsoidalCS_Type))] // GMX
  //[XmlInclude(typeof(ML_LinearCS_Type))] // GMX
  //[XmlInclude(typeof(ML_PolarCS_Type))] // GMX
  //[XmlInclude(typeof(ML_SphericalCS_Type))] // GMX
  //[XmlInclude(typeof(ML_TimeCS_Type))] // GMX
  //[XmlInclude(typeof(ML_UserDefinedCS_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalCS_Type))] // GMX
  //[XmlInclude(typeof(ObliqueCartesianCSType))]
  //[XmlInclude(typeof(AffineCSType))]
  //[XmlInclude(typeof(CylindricalCSType))]
  //[XmlInclude(typeof(PolarCSType))]
  //[XmlInclude(typeof(SphericalCSType))]
  //[XmlInclude(typeof(UserDefinedCSType))]
  //[XmlInclude(typeof(LinearCSType))]
  //[XmlInclude(typeof(TemporalCSType))]
  //[XmlInclude(typeof(TimeCSType))]
  //[XmlInclude(typeof(VerticalCSType))]
  //[XmlInclude(typeof(CartesianCSType))]
  //[XmlInclude(typeof(EllipsoidalCSType))]
  #endregion

  /// <summary>
  /// The <see cref="AbstractCoordinateSystemType"/> is a coordinate system that is the non-repeating sequence of
  /// coordinate system axes that spans a given coordinate space. A coordinate system is derived from a set of
  /// mathematical rules for specifying how coordinates in a given space are to be assigned to points.
  /// The coordinate values in a coordinate tuple shall be recorded in the order in which
  /// the coordinate system axes associations are recorded. This abstract complex type shall not be used,
  /// extended, or restricted, in an Application Schema, to define a concrete subtype with a meaning equivalent
  /// to a concrete subtype specified in this document.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractCoordinateSystemType</c> ( /2005/gml/coordinateSystems.xsd )
  /// </remarks>
  [IsoType(
    "AbstractCoordinateSystemType",
    WrapperName = "CoordinateSystemPropertyType",
    IsAbstract = true,
    IsoType = IsoTypes.ComplexType
  )]
  //[XmlType("AbstractCoordinateSystemType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCoordinateSystemType")]
  public abstract class AbstractCoordinateSystemType : IdentifiedObjectType, IAggregation, IAssociated {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractCoordinateSystemType"/>.
    /// </summary>
    public AbstractCoordinateSystemType() {
      _axis = new ObservableCollection<CoordinateSystemAxisType>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CoordinateSystemAxisType> _axis;

    /// <summary>
    /// Gets/Sets the list of axes that define the coordinate system.
    /// </summary>
    /// <remarks>
    /// Each axis represents one dimension of the coordinate space. The order of axes
    /// determines the order of coordinate values in a coordinate tuple.
    /// </remarks>
    //[XmlElement("axis", Order = 0)]
    [JsonProperty("axis", Order = 0)]
    public ObservableCollection<CoordinateSystemAxisType> Axis {
      get => _axis;
      set => SetProperty(ref _axis, value);
    }

    #endregion

    #region IAggregation Interface

    private AggregationType _aggregationType;

    /// <summary>
    /// Gets/Sets the aggregation type that specifies how multiple coordinate systems may be grouped.
    /// </summary>
    //[XmlAttribute("aggregationType")]
    [JsonProperty("aggregationType")]
    public AggregationType AggregationType {
      get => _aggregationType;
      set => SetProperty(ref _aggregationType, value);
    }

    #endregion

    #region IAssociated Interface

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> to a
    /// <see cref="AbstractCoordinateSystemType">coordinate system</see>.
    /// </summary>
    public abstract AssociationEntity? Association {
      get;
      set;
    }

    #endregion

  }

}
