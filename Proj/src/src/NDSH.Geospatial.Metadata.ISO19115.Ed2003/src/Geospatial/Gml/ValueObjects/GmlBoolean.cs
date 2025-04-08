
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 12/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/gmlBase.xsd
//                     /2005/gml/valueObjects.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <attributeGroup name="AssociationAttributeGroup">
//  <attributeGroup ref="xlink:simpleLink"/>
//  <attribute name="nilReason" type="gml:NilReasonType"/>
//  <attribute ref="gml:remoteSchema"/>
// </attributeGroup>
// <attribute name="remoteSchema" type="anyURI">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </attribute>
// 
// <element name="Boolean" substitutionGroup="gml:AbstractScalarValue" nillable="true">
//   <complexType>
//     <simpleContent>
//       <extension base="boolean">
//         <attribute name="nilReason" type="gml:NilReasonType"/>
//       </extension>
//     </simpleContent>
//   </complexType>
// </element>
// 
// <complexType name="BooleanPropertyType">
//   <sequence minOccurs="0">
//     <element ref="gml:Boolean"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.ValueObjects {

  /// <summary>
  /// Represents an entity that maps an <see cref="bool"/> value to a dedicated database table,
  /// aligning with the <c>BooleanPropertyType</c> definition for GML objects.
  /// </summary>
  /// <remarks>
  /// Use the <see cref="bool"/> type whenever boolean values are required in a POCO.<br></br>
  /// If the <see cref="bool"/> property must be stored in its own table (for example, to satisfy
  /// advanced gml metadata requirements) map it to this <see cref="GmlBoolean"/>.<br></br>
  /// This design helps ensure consistent handling of <see cref="bool"/> values according to the GML standard.
  /// </remarks>
  [Serializable]
  //[XmlType("Boolean", AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("Boolean")]
  // WARNING: The GmlBoolean object is decorated with an Association Object, while the BooleanDbEntity is decorated with NilReasonEntity. We may need to remove the inheritance from Association and replace it with an ObservableDbEntity, and let a serializer decide how to use the Association decoration.
  public class GmlBoolean : AssociationEntity, INullableValue<bool> {

    #region INullableValue<T> Interface

    private bool? _value;

    /// <summary>
    /// Gets/Sets the <see cref="bool"/> value.
    /// </summary>
    //[XmlElement("Boolean", IsNullable = true, Order = 0)]
    [JsonProperty("Boolean", Order = 0)]
    public bool? Value {
      get => _value;
      set => SetProperty(ref _value, value);
    }

    #endregion

  }

}
