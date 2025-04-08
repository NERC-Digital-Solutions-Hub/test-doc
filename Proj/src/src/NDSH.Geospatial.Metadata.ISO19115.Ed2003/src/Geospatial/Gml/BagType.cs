
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 20/12/2022, @gisvlasta
// History           : 10/03/2025, @gisvlasta - Updated code and documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AssociationRoleType">
//   <sequence minOccurs="0">
//     <element ref="gml:AbstractObject"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// <element name="member" type="gml:AssociationRoleType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="ArrayAssociationType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence>
//     <element ref="gml:AbstractObject" minOccurs="0" maxOccurs="unbounded"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="members" type="gml:ArrayAssociationType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <element name="Bag" type="gml:BagType" substitutionGroup="gml:AbstractGML">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// <complexType name="BagType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractGMLType">
//       <sequence>
//         <element ref="gml:member" minOccurs="0" maxOccurs="unbounded"/>
//         <element ref="gml:members" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from BagType to Bag.

  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")] // RESOURCE
  [IsoType("BagType", IsoType = IsoTypes.ComplexType)]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("BagType")]
  public class BagType : AbstractGMLType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="BagType"/>.
    /// </summary>
    public BagType() {
      _members = default; // new ArrayAssociationType();
      _member = default; // new List<AssociationRoleType>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<AssociationRoleType>? _member;

    //[XmlElement("member", Order = 0)]
    [JsonProperty("member", Order = 0)]
    public ObservableCollection<AssociationRoleType>? Member {
      get => _member;
      set {
        if (_member == value) {
          return;
        }
        if (_member == null || _member.Equals(value) != true) {
          _member = value;
          OnPropertyChanged();
        }
      }
    }

    private ArrayAssociationType? _members;

    //[XmlElement(Order = 1)]
    [JsonProperty("members", Order = 1)]
    public ArrayAssociationType? Members {
      get => _members;
      set {
        if (_members == value) {
          return;
        }
        if (_members == null || _members.Equals(value) != true) {
          _members = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
