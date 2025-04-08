
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 01/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/measures.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AngleType">
//   <simpleContent>
//     <extension base="gml:MeasureType"/>
//   </simpleContent>
// </complexType>
// <element name="angle" type="gml:AngleType">
//   <annotation>
//     <documentation>
//       The gml:angle property element is used to record the value of an angle quantity as a single number,
//       with its units.
//     </documentation>
//   </annotation>
// </element>
//
// <element name="dmsAngle" type="gml:DMSAngleType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// <complexType name="DMSAngleType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <sequence>
//     <element ref="gml:degrees"/>
//     <choice minOccurs="0">
//       <element ref="gml:decimalMinutes"/>
//       <sequence>
//         <element ref="gml:minutes"/>
//         <element ref="gml:seconds" minOccurs="0"/>
//       </sequence>
//     </choice>
//   </sequence>
// </complexType>
// <element name="degrees" type="gml:DegreesType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// <complexType name="DegreesType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <simpleContent>
//     <extension base="gml:DegreeValueType">
//       <attribute name="direction">
//         <simpleType>
//           <restriction base="string">
//             <enumeration value="N"/>
//             <enumeration value="E"/>
//             <enumeration value="S"/>
//             <enumeration value="W"/>
//             <enumeration value="+"/>
//             <enumeration value="-"/>
//           </restriction>
//         </simpleType>
//       </attribute>
//     </extension>
//   </simpleContent>
// </complexType>
// <simpleType name="DegreeValueType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <restriction base="nonNegativeInteger">
//     <maxInclusive value="359"/>
//   </restriction>
// </simpleType>
//
// <complexType name="AngleChoiceType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <choice>
//     <element ref="gml:angle"/>
//     <element ref="gml:dmsAngle"/>
//   </choice>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Database.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Measures {

  /// <summary>
  /// Represents the GML <c>AngleChoiceType</c> as defined by
  /// <see href="http://www.opengis.net/gml">GML</see> specification.
  /// This type has been marked as deprecated (obsolete) in the underlying schema.<br></br>
  /// It provides a choice between specifying an angle as a single numeric measurement 
  /// <see cref="AngleType"/> or as a degrees-minutes-seconds representation <see cref="DMSAngleType"/>.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Per the schema definitions in <c>/2005/gml/measures.xsd</c>, 
  ///     <see cref="AngleChoiceType"/> includes two potential XML elements:
  ///     <list type="bullet">
  ///       <item><see cref="AngleType"/> serialized as <c>angle</c></item>
  ///       <item><see cref="DMSAngleType"/> serialized as <c>dmsAngle</c></item>
  ///     </list>
  ///     Both <see cref="AngleType"/> and <see cref="DMSAngleType"/> are also marked deprecated.
  ///     This class is therefore provided primarily for backward compatibility with
  ///     legacy GML data and is not recommended for use in new designs.
  ///   </para>
  ///   <para>
  ///     The choice of angle representation is stored in the <see cref="Angle"/> property, 
  ///     which can contain an instance of either <c>AngleType</c> or <c>DMSAngleType</c>. 
  ///     Although this class inherits from <see cref="ObservableModel"/>, 
  ///     it is marked <see cref="ObsoleteAttribute"/> to reflect the GML schema's deprecation notice.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("AngleChoiceType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AngleChoiceType")]
  [Obsolete]
  public class AngleChoiceType : ObservableDbEntity {

    #region Public Properties

    private IAngle _item;

    /// <summary>
    /// Gets or sets the angle representation for this choice.
    /// This property may store either an <see cref="AngleType"/> (single numeric measurement) 
    /// or a <see cref="DMSAngleType"/> (degrees-minutes-seconds format), 
    /// both of which implement <see cref="IAngle"/>.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///     In the underlying GML schema, this property corresponds to either
    ///     the <see cref="AngleType"/> or the <see cref="DMSAngleType"/>.
    ///     Both formats are marked deprecated in the specification but are
    ///     preserved here for compatibility with legacy datasets.
    ///   </para>
    ///   <para>
    ///     Because <see cref="AngleChoiceType"/> is itself marked <see cref="ObsoleteAttribute">Obsolete</see>,
    ///     and its usage in new designs is discouraged, consider modern alternatives for representing angles
    ///     if forward-compatibility and standardization are a priority.
    ///   </para>
    /// </remarks>
    //[XmlElement("angle", typeof(AngleType), Order = 0)]
    //[XmlElement("dmsAngle", typeof(DMSAngleType), Order = 0)]
    public IAngle Angle {
      get => _item;
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
