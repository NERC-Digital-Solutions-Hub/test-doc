
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="abstractAssociationRole" type="gml:AssociationRoleType" abstract="true">
//   <annotation>
//     <documentation>
//       Applying this pattern shall restrict the multiplicity of objects in a property element
//       using this content model to exactly one. An instance of this type shall contain an element
//       representing an object, or serve as a pointer to a remote object.
//       Applying the pattern to define an application schema specific property type allows to restrict
//         - the inline object to specified object types, 
//         - the encoding to „by-reference only“ (see 7.2.3.7),
//         - the encoding to „inline only“ (see 7.2.3.8).
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="AssociationRoleType">
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractObject"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// 
// <element name="member" type="gml:AssociationRoleType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
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

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from AssociationRoleType to AssociationRole.

  /// <summary>
  /// Represents an association role within a GML object.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>AssociationRoleType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")]
  [IsoType("AssociationRoleType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("AssociationRoleType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AssociationRoleType")]
  public class AssociationRoleType : AssociationAndOwnership {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="AssociationRoleType"/>.
    /// </summary>
    public AssociationRoleType() {
      _abstractObject = default;
    }

    #endregion

    #region Public Properties

    private GmlObject? _abstractObject;

    /// <summary>
    /// Gets/Sets the associated GML object.
    /// </summary>
    /// <remarks>
    /// This property holds a reference to an instance of <see cref="AbstractObject"/>, 
    /// allowing association between GML elements.
    /// </remarks>
    /// <value>
    /// An instance of <see cref="AbstractObject"/> representing the associated object.
    /// </value>
    //[XmlElement("AbstractObject", Order = 0)]
    [JsonProperty("AbstractObject", Order = 0)]
    public GmlObject? AbstractObject { // WARNING: Does AbstractObject needs to be called GmlObject?
      get => _abstractObject;
      set {
        if (_abstractObject == value) {
          return;
        }
        if (_abstractObject == null || _abstractObject.Equals(value) != true) {
          _abstractObject = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
