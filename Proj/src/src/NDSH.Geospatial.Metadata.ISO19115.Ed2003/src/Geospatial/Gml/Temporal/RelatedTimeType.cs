
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/02/2023, @gisvlasta
// History           : 02/04/2025, @gisvlasta - 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="RelatedTimeType">
//   <annotation>
//     <documentation>
//       gml:RelatedTimeType provides a content model for indicating the relative position of an arbitrary
//       member of the substitution group whose head is gml:AbstractTimePrimitive. It extends the generic
//       gml:TimePrimitivePropertyType with an XML attribute relativePosition, whose value is selected
//       from the set of 13 temporal relationships identified by Allen (1983)
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:TimePrimitivePropertyType">
//       <attribute name="relativePosition">
//         <simpleType>
//           <restriction base="string">
//             <enumeration value="Before"/>
//             <enumeration value="After"/>
//             <enumeration value="Begins"/>
//             <enumeration value="Ends"/>
//             <enumeration value="During"/>
//             <enumeration value="Equals"/>
//             <enumeration value="Contains"/>
//             <enumeration value="Overlaps"/>
//             <enumeration value="Meets"/>
//             <enumeration value="OverlappedBy"/>
//             <enumeration value="MetBy"/>
//             <enumeration value="BegunBy"/>
//             <enumeration value="EndedBy"/>
//           </restriction>
//         </simpleType>
//       </attribute>
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

#endregion

namespace NDSH.Geospatial.Gml.Temporal {

  /// <summary>
  /// The <see cref="RelatedTimeType"/> provides a content model for indicating the relative position of
  /// an arbitrary member of the substitution group whose head is <see cref="AbstractTimePrimitiveType"/>.
  /// It extends the generic <see cref="TimePrimitivePropertyType"/> with a <see cref="RelativePosition"/> property
  /// (XML attribute relativePosition), whose value is selected from the set of
  /// <see href="https://en.wikipedia.org/wiki/Allen%27s_interval_algebra">
  /// 13 temporal relationships identified by Allen (1983)
  /// </see>.
  /// </summary>
  /// <remarks>
  /// Maps to: <c>RelatedTimeType</c> ( /2005/gml/temporal.xsd )
  /// </remarks>
  [IsoType("RelatedTimeType", IsoType = IsoTypes.ComplexType)]
  //[XmlType("RelatedTimeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RelatedTimeType")]
  public class RelatedTimeType : TimePrimitivePropertyType {

    #region Public Properties

    private RelatedTimeRelativePosition _relativePosition;

    /// <summary>
    ///   <para>
    ///     Gets/Sets the relative position of a temporal primitive with respect to another.
    ///   </para>
    ///   <para>
    ///     The value is one of the 13 temporal relationships defined by Allen’s interval algebra,
    ///     such as <see cref="RelatedTimeRelativePosition.Before">Before</see>,
    ///     <see cref="RelatedTimeRelativePosition.After">Afer</see>,
    ///     <see cref="RelatedTimeRelativePosition.During">During</see>,
    ///     or <see cref="RelatedTimeRelativePosition.Overlaps">Overlaps</see>.
    ///   </para>
    /// </summary>
    /// <remarks>
    /// This property corresponds to the XML attribute <c>relativePosition</c> in GML.
    /// </remarks>
    //[XmlAttribute("relativePosition")]
    [JsonProperty("relativePosition")]
    public RelatedTimeRelativePosition RelativePosition {
      get => _relativePosition;
      set => SetProperty(ref _relativePosition, value);
    }

    #endregion

  }

}
