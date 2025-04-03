
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// History           : 17/03/2025, @gisvlasta - Added IsoTypeAttribute and updated code.
//                   : 21/03/2025, @gisvlasta - Updated IsoTypeAttribute, updated XML Doc in IAssociated interface,
//                                              and added class XML Doc.
//                   : 27/03/2025, @gisvlasta - Changed implemented interface from IAssociated to ITypeAssociated and
//                                               updated documentation in DomainOfValidity and Scope properties.
//                   : 31/03/2025, @gisvlasta - Updated documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/referenceSystems.xsd
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
// <element name="scope" type="string">
//   <annotation>
//     <documentation>
//       The gml:scope property provides a description of the usage, or limitations of usage,
//       for which this CRS-related object is valid. If unknown, enter "not known".
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="AbstractCRSType" abstract="true">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:domainOfValidity" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:scope" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <element name="AbstractCRS" type="gml:AbstractCRSType" abstract="true" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       gml:AbstractCRS specifies a coordinate reference system which is usually single but may be compound.
//       This abstract complex type shall not be used, extended, or restricted, in a GML Application Schema,
//       to define a concrete subtype with a meaning equivalent to a concrete subtype specified in this document.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="CRSPropertyType">
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractCRS"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata;
using NDSH.Geospatial.Metadata.Extent;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.ReferenceSystems {

  #region XmlIncludes
  //[XmlInclude(typeof(CrsAlt_Type))] // GMX
  //[XmlInclude(typeof(ML_CompoundCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_DerivedCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_EngineeringCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_GeodeticCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_ImageCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_ProjectedCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_TemporalCRS_Type))] // GMX
  //[XmlInclude(typeof(ML_VerticalCRS_Type))] // GMX
  //[XmlInclude(typeof(GeocentricCRSType))]
  //[XmlInclude(typeof(TemporalCRSType))]
  //[XmlInclude(typeof(ImageCRSType))]
  //[XmlInclude(typeof(EngineeringCRSType))]
  //[XmlInclude(typeof(VerticalCRSType))]
  //[XmlInclude(typeof(CompoundCRSType))]
  //[XmlInclude(typeof(GeographicCRSType))]
  //[XmlInclude(typeof(GeodeticCRSType))]
  //[XmlInclude(typeof(AbstractGeneralDerivedCRSType))]
  //[XmlInclude(typeof(DerivedCRSType))]
  //[XmlInclude(typeof(ProjectedCRSType))]
  #endregion

  /// <summary>
  /// The <see cref="AbstractCRSType"/> specifies a coordinate reference system which is usually single
  /// but may be compound. This abstract complex type shall not be used, extended, or restricted,
  /// in a GML Application Schema, to define a concrete subtype with a meaning equivalent to a
  /// concrete subtype specified in this document.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AbstractCRSType</c> ( /2005/gml/referenceSystems.xsd )
  /// </remarks>
  [IsoType("AbstractCRSType", WrapperName = "CRSPropertyType", IsAbstract = true, IsoType = IsoTypes.ComplexType)]
  //[XmlType("AbstractCRSType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractCRSType")]
  public abstract class AbstractCRSType : IdentifiedObjectType, ITypeAssociated {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AbstractCRSType"/>.
    /// </summary>
    public AbstractCRSType() {
      _domainOfValidity = default;
      _scope = [];
    }

    #endregion

    #region Public Properties

    private ObservableCollection<EX_Extent_Type>? _domainOfValidity;

    /// <summary>
    /// Gets/Sets an association role to an <see cref="EX_Extent_Type"/> object as encoded in ISO/TS 19139,
    /// either referencing or containing the definition of that extent.
    /// </summary>
    //[XmlElement("domainOfValidity", Order = 0)]
    [JsonProperty("domainOfValidity", Order = 0)]
    public ObservableCollection<EX_Extent_Type>? DomainOfValidity {
      get => _domainOfValidity;
      set => SetProperty(ref _domainOfValidity, value);
    }

    private ObservableCollection<string> _scope;

    /// <summary>
    /// Gets/Sets the description of the usage, or limitations of usage,
    /// for which this coordinate reference system related object is valid.
    /// </summary>
    /// <remarks>
    /// If unknown, enter "not known".
    /// </remarks>
    // WARNING: Add a validation rule to make sure the behaviour described in remarks is observed.
    //[XmlElement("scope", Order = 1)]
    [JsonProperty("scope", Order = 1)]
    public ObservableCollection<string> Scope {
      get => _scope;
      set => SetProperty(ref _scope, value);
    }

    #endregion

    #region ITypeAssociated Interface

    /// <summary>
    /// Gets/Sets a <see cref="TypeAssociationMetadata">union association</see>
    /// of <see cref="AssociationEntity"/> or <see cref="ReferenceEntity"/>.
    /// </summary>
    public abstract TypeAssociationMetadata? TypeAssociation {
      get;
      set;
    }

    #endregion

  }

}
