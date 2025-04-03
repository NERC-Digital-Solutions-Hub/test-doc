
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
// 
// <element name="decimalMinutes" type="gml:DecimalMinutesType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
// </element>
// <simpleType name="DecimalMinutesType">
//   <annotation>
//     <appinfo>deprecated</appinfo>
//   </annotation>
//   <restriction base="decimal">
//     <minInclusive value="0.00"/>
//     <maxExclusive value="60.00"/>
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
  /// Represents a deprecated GML <c>DMSAngleType</c>, storing an angle in degrees-minutes-seconds format.
  /// Inherits from <see cref="ObservableDbEntity"/> to track property changes and database persistence details.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     According to <c>/2005/gml/measures.xsd</c>, <see cref="DMSAngleType"/> is marked as <c>deprecated</c>.
  ///     It separates the angle into <see cref="Degrees"/>,
  ///     plus optional minutes and seconds via <see cref="MinutesSecondsValues"/>.
  ///   </para>
  ///   <para>
  ///     This class enables storing the DMS components as distinct properties (e.g., <c>degrees</c>,
  ///     <c>decimalMinutes</c>, <c>minutes</c>, <c>seconds</c>), matching the older GML approach.
  ///     Due to deprecation, consider using <see cref="AngleType"/> or another modern representation for new designs.
  ///   </para>
  /// </remarks>
  //[Serializable]
  //[XmlType("DMSAngleType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DMSAngleType")]
  public class DMSAngleType : ObservableDbEntity, IAngle {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DMSAngleType"/>.
    /// </summary>
    public DMSAngleType() {
      _degrees = new DegreesType();
    }

    #endregion

    #region Public Properties

    private DegreesType _degrees;

    /// <summary>
    /// Gets/Sets the degrees component of the angle.
    /// This property corresponds to the deprecated <c>gml:degrees</c> element.
    /// </summary>
    //[XmlElement("degrees", Order = 0)]
    [JsonProperty("degrees", Order = 0)]
    public DegreesType Degrees {
      get => _degrees;
      set {
        if (_degrees == value) {
          return;
        }
        if (_degrees == null || _degrees.Equals(value) != true) {
          _degrees = value;
          OnPropertyChanged();
        }
      }
    }

    private object[] _minutesSecondsValues;

    /// <summary>
    /// Gets or sets the degrees component of the angle.
    /// This property corresponds to the deprecated <c>gml:degrees</c> element.
    /// </summary>
    //[XmlElement("decimalMinutes", typeof(decimal), Order = 1)]
    //[XmlElement("minutes", typeof(string), DataType = "nonNegativeInteger", Order = 1)]
    //[XmlElement("seconds", typeof(decimal), Order = 1)]
    //[XmlChoiceIdentifier("MinutesSecondsValueTypes")]
    public object[] MinutesSecondsValues {
      get => _minutesSecondsValues;
      set {
        if (_minutesSecondsValues == value) {
          return;
        }
        if (_minutesSecondsValues == null || _minutesSecondsValues.Equals(value) != true) {
          _minutesSecondsValues = value;
          OnPropertyChanged();
        }
      }
    }

    private MinutesSecondsValueType[] _minutesSecondsValueTypes;

    /// <summary>
    /// Gets/Sets the type identifiers for each entry in <see cref="MinutesSecondsValues"/>
    /// (e.g., <c>decimalMinutes</c>, <c>minutes</c>, or <c>seconds</c>).
    /// This is used internally to help differentiate the stored objects,
    /// especially if they need separate handling or serialization.
    /// </summary>
    //[XmlElement("MinutesSecondsValueTypes", Order = 2)]
    [XmlIgnore]
    public MinutesSecondsValueType[] MinutesSecondsValueTypes {
      get => _minutesSecondsValueTypes;
      set {
        if (_minutesSecondsValueTypes == value) {
          return;
        }
        if (_minutesSecondsValueTypes == null || _minutesSecondsValueTypes.Equals(value) != true) {
          _minutesSecondsValueTypes = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
