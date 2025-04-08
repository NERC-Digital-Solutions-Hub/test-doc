
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
// <complexType name="ArrayAssociationType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence>
//     <element ref="gml:AbstractObject" minOccurs="0" maxOccurs="unbounded"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// 
// <element name="members" type="gml:ArrayAssociationType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// 
// <complexType name="ArrayType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractGMLType">
//       <sequence>
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml {

  // WARNING: Rename from ArrayType to GmlArray.

  /// <summary>
  /// Represents a GML array structure that extends the <see cref="AbstractGMLType"/>.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>ArrayType</c> ( /2005/gml/gmlBase.xsd )
  /// </remarks>
  [Obsolete("Marked 'deprecated' in /gml/gmlBase.xsd")]
  [IsoType("ArrayType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("ArrayType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArrayType")]
  public class ArrayType : AbstractGMLType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ArrayType"/>.
    /// </summary>
    public ArrayType() {
      _members = default; //  new ArrayAssociationType();
    }

    #endregion

    #region Public Properties

    private ArrayAssociationType? _members;

    /// <summary>
    /// Gets/Sets the <see cref="ArrayAssociationType"/> containing the GML objects.
    /// </summary>
    //[XmlElement("members", Order = 0)]
    [JsonProperty("members", Order = 0)]
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
