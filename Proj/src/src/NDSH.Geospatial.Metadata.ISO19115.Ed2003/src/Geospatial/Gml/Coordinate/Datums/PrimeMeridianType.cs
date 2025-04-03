
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/datums.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="greenwichLongitude" type="gml:AngleType">
//   <annotation>
//     <documentation>
//       gml:greenwichLongitude is the longitude of the prime meridian measured from the Greenwich meridian,
//       positive eastward. If the value of the prime meridian “name” is "Greenwich" then the value of
//       greenwichLongitude shall be 0 degrees.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="PrimeMeridian" type="gml:PrimeMeridianType" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       A gml:PrimeMeridian defines the origin from which longitude values are determined.
//       The default value for the prime meridian gml:identifier value is "Greenwich".
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="PrimeMeridianType">
//   <complexContent>
//     <extension base="gml:IdentifiedObjectType">
//       <sequence>
//         <element ref="gml:greenwichLongitude"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="PrimeMeridianPropertyType">
//   <annotation>
//     <documentation>
//       gml:PrimeMeridianPropertyType is a property type for association roles to a prime meridian,
//       either referencing or containing the definition of that meridian.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:PrimeMeridian"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Measures;
using NDSH.Geospatial.Gml.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Datums {

  /// <summary>
  /// The <see cref="PrimeMeridianType"/> defines the origin from which longitude values are determined.
  /// The default value for the prime meridian gml:identifier value is "Greenwich".
  /// </summary>
  /// <remarks>
  /// Maps to: <c>PrimeMeridianType</c> ( /2005/gml/datums.xsd )
  /// </remarks>
  //[XmlInclude(typeof(ML_PrimeMeridian_Type))] // GMX
  [IsoType("PrimeMeridianType", WrapperName = "PrimeMeridianPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PrimeMeridianType")]
  public class PrimeMeridianType : IdentifiedObjectType, IAssociated {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PrimeMeridianType"/>.
    /// </summary>
    public PrimeMeridianType() {
      _greenwichLongitude = new AngleType();
    }

    #endregion

    #region Public Properties

    private AngleType _greenwichLongitude;

    /// <summary>
    /// Gets/Sets the longitude of the prime meridian measured from the Greenwich meridian, positive eastward.
    /// If the value of the prime meridian "name" is "Greenwich" then the value of <see cref="GreenwichLongitude"/>
    /// shall be <c>0</c> degrees.
    /// </summary>
    //[XmlElement(Order = 0)]
    [JsonProperty("greenwichLongitude", Order = 0)]
    public AngleType GreenwichLongitude {
      get => _greenwichLongitude;
      set => SetProperty(ref _greenwichLongitude, value);
    }

    #endregion

    #region IAssociated Interface

    private AssociationEntity? _associationEntity;

    /// <summary>
    /// Gets/Sets an <see cref="Gml.AssociationEntity">Association</see> role to a <see cref="PrimeMeridianType"/>,
    /// either referencing or containing the definition of that meridian.
    /// </summary>
    public AssociationEntity? Association {
      get => _associationEntity;
      set => SetProperty(ref _associationEntity, value);
    }

    #endregion

  }

}
