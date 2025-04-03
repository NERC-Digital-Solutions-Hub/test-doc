
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/measures.xsd
// ---------------------------------------------------------------------------------------------------------------------
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
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

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
  /// Represents a deprecated GML <c>DegreesType</c>, storing a numeric degree measurement
  /// in the range of 0–359, plus an optional directional attribute (<c>N, E, S, W, +, -</c>).
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     Defined in <c>/2005/gml/measures.xsd</c>, <see cref="DegreesType"/> is marked as
  ///     <c>deprecated</c> in the schema. It inherits from <see cref="ObservableDbEntity"/>,
  ///     allowing property change notifications for the
  ///     <see cref="Value"/> and <see cref="Direction"/> properties.
  ///   </para>
  ///   <para>
  ///     The <see cref="Direction"/> attribute can designate cardinal directions 
  ///     (<c>N</c>, <c>E</c>, <c>S</c>, <c>W</c>) or sign indicators (<c>+</c>, <c>-</c>).
  ///     The <see cref="Value"/> property represents degrees as a string-constrained to
  ///     non-negative integers up to 359, reflecting the <c>DegreeValueType</c> base.
  ///   </para>
  ///   <para>
  ///     While still recognized for backward compatibility, this type is discouraged in modern GML-based applications; 
  ///     consider using alternative angle representations as recommended by updated GML or ISO 19115 specifications.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("DegreesType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DegreesType")]
  public class DegreesType : ObservableDbEntity {

    #region Public Properties

    private DegreesTypeDirection _direction;

    /// <summary>
    /// Gets or sets the direction attribute for this degrees measurement, 
    /// allowing cardinal directions (<c>N, E, S, W</c>) or sign indicators (<c>+, -</c>).
    /// </summary>
    //[XmlAttribute("direction")]
    public DegreesTypeDirection Direction {
      get => _direction;
      set {
        if (_direction.Equals(value) != true) {
          _direction = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// Gets or sets the numeric component of the degrees measurement as a string,
    /// restricted to non-negative integers up to 359. This reflects the
    /// <c>DegreeValueType</c> base type in the GML schema.
    /// </summary>
    //[XmlText(DataType = "nonNegativeInteger")]
    [JsonProperty("Value")]
    public string Value {
      get => _value;
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
