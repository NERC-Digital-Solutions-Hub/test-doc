
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/02/2023, @gisvlasta
// History           : 02/04/2025, @gisvlasta - Renamed enumeration, commented out XML attributes,
//                                               and added documentation.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Temporal {

  /// <summary>
  /// Defines the possible relative temporal relationships between time primitives as per
  /// <see href="https://en.wikipedia.org/wiki/Allen%27s_interval_algebra">
  /// Allen's (1983) 13 temporal relationships
  /// </see>.
  /// This enumeration is used in the GML (Geography Markup Language) temporal model to
  /// describe how one time primitive (e.g., an instant or period) relates to another
  /// in terms of their relative positions.
  /// </summary>
  /// <seealso href="https://ics.uci.edu/~alspaugh/cls/shr/allen.html">Allen's Interval Algebra</seealso>
  //[Serializable]
  //[XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  public enum RelatedTimeRelativePosition {

    /// <summary>
    /// Indicates that the time primitive occurs entirely before another time primitive, with no overlap.
    /// </summary>
    //[XmlEnum(Name = "Before")]
    [EnumMember(Value = "Before")]
    Before,

    /// <summary>
    /// Indicates that the time primitive occurs entirely after another time primitive, with no overlap.
    /// </summary>
    //[XmlEnum(Name = "After")]
    [EnumMember(Value = "After")]
    After,

    /// <summary>
    /// Indicates that the time primitive starts at the same moment as another time primitive begins.
    /// </summary>
    //[XmlEnum(Name = "Begins")]
    [EnumMember(Value = "Begins")]
    Begins,

    /// <summary>
    /// Indicates that the time primitive ends at the same moment as another time primitive ends.
    /// </summary>
    //[XmlEnum(Name = "Ends")]
    [EnumMember(Value = "Ends")]
    Ends,

    /// <summary>
    /// Indicates that the time primitive occurs entirely within the duration of another time primitive.
    /// </summary>
    //[XmlEnum(Name = "During")]
    [EnumMember(Value = "During")]
    During,

    /// <summary>
    /// Indicates that the time primitive is exactly the same as another time primitive in both start and end.
    /// </summary>
    //[XmlEnum(Name = "Equals")]
    [EnumMember(Value = "Equals")]
    Equals,

    /// <summary>
    /// Indicates that the time primitive fully contains another time primitive.
    /// </summary>
    //[XmlEnum(Name = "Contains")]
    [EnumMember(Value = "Contains")]
    Contains,

    /// <summary>
    /// Indicates that the time primitive partially overlaps with another time primitive, sharing some duration.
    /// </summary>
    //[XmlEnum(Name = "Overlaps")]
    [EnumMember(Value = "Overlaps")]
    Overlaps,

    /// <summary>
    /// Indicates that the time primitive ends exactly when another time primitive begins, with no gap or overlap.
    /// </summary>
    //[XmlEnum(Name = "Meets")]
    [EnumMember(Value = "Meets")]
    Meets,

    /// <summary>
    /// Indicates that the time primitive is partially overlapped by another time primitive.
    /// </summary>
    //[XmlEnum(Name = "OverlappedBy")]
    [EnumMember(Value = "OverlappedBy")]
    OverlappedBy,

    /// <summary>
    /// Indicates that the time primitive begins exactly when another time primitive ends, with no gap or overlap.
    /// </summary>
    //[XmlEnum(Name = "MetBy")]
    [EnumMember(Value = "MetBy")]
    MetBy,

    /// <summary>
    /// Indicates that the time primitive is started by the beginning of another time primitive.
    /// </summary>
    //[XmlEnum(Name = "BegunBy")]
    [EnumMember(Value = "BegunBy")]
    BegunBy,

    /// <summary>
    /// Indicates that the time primitive is ended by the end of another time primitive.
    /// </summary>
    //[XmlEnum(Name = "EndedBy")]
    [EnumMember(Value = "EndedBy")]
    EndedBy,

  }

}
