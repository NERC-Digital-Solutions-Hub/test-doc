
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/02/2023, @gisvlasta
// History           : 02/04/2025, @gisvlasta - Updated code and documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="timePosition" type="gml:TimePositionType">
//   <annotation>
//     <documentation>
//       This element is used directly as a property of gml:TimeInstant (see 15.2.2.3),
//       and may also be used in application schemas.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="TimeInstant" type="gml:TimeInstantType" substitutionGroup="gml:AbstractTimeGeometricPrimitive">
//   <annotation>
//     <documentation>
//       gml:TimeInstant acts as a zero-dimensional geometric primitive that
//       represents an identifiable position in time.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="TimeInstantType" final="#all">
//   <complexContent>
//     <extension base="gml:AbstractTimeGeometricPrimitiveType">
//       <sequence>
//         <element ref="gml:timePosition"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// 
// <complexType name="TimeInstantPropertyType">
//   <annotation>
//     <documentation>
//       gml:TimeInstantPropertyType provides for associating a gml:TimeInstant with an object.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeInstant"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Temporal {

  /// <summary>
  /// The <see cref="TimeInstantType"/> acts as a zero-dimensional geometric primitive that
  /// represents an identifiable position in time.
  /// </summary>
  [IsoType("TimeInstantType", WrapperName = "TimeInstantPropertyType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeInstantType")]
  public sealed class TimeInstantType : AbstractTimeGeometricPrimitiveType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TimeInstantType"/>.
    /// </summary>
    public TimeInstantType() {
      _timePosition = new TimePositionType();
    }

    #endregion

    #region Public Properties

    private TimePositionType _timePosition;

    /// <summary>
    /// This element is used directly as a property of <see cref="TimeInstantType"/>,
    /// and may also be used in application schemas.
    /// </summary>
    //[XmlElement(Order = 0)]
    [JsonProperty("timePosition", Order = 0)]
    public TimePositionType TimePosition {
      get => _timePosition;
      set => SetProperty(ref _timePosition, value);
    }

    #endregion

  }

}
