
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 19:54, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="TimePositionType" final="#all">
//   <annotation>
//     <documentation>
//       The method for identifying a temporal position is specific to each temporal reference system.
//       gml:TimePositionType supports the description of temporal position according to the subtypes described in ISO 19108.
//       Values based on calendars and clocks use lexical formats that are based on ISO 8601, as described in XML Schema Part 2:2001.
//       A decimal value may be used with coordinate systems such as GPS time or UNIX time. A URI may be used to provide a reference
//       to some era in an ordinal reference system . 
//       In common with many of the components modelled as data types in the ISO 19100 series of International Standards,
//       the corresponding GML component has simple content. However, the content model gml:TimePositionType is defined in several steps.
//       Three XML attributes appear on gml:TimePositionType:
//       A time value shall be associated with a temporal reference system through the frame attribute that provides a URI reference
//       that identifies a description of the reference system. Following ISO 19108, the Gregorian calendar with UTC is the
//       default reference system, but others may also be used. Components for describing temporal reference systems are described in 14.4,
//       but it is not required that the reference system be described in this, as the reference may refer to anything that may be indentified with a URI.  
//       For time values using a calendar containing more than one era, the (optional) calendarEraName attribute provides the name of the calendar era.  
//       Inexact temporal positions may be expressed using the optional indeterminatePosition attribute. This takes a value from an enumeration.
//     </documentation>
//   </annotation>
//   <simpleContent>
//     <extension base="gml:TimePositionUnion">
//       <attribute name="frame" type="anyURI" default="#ISO-8601"/>
//       <attribute name="calendarEraName" type="string"/>
//       <attribute name="indeterminatePosition" type="gml:TimeIndeterminateValueType"/>
//     </extension>
//   </simpleContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;


#endregion

namespace NDSH.Geospatial.Gml.Temporal {

  /// <summary>
  /// The method for identifying a temporal position is specific to each temporal reference system.
  /// TimePositionType supports the description of temporal position according to the subtypes
  /// described in ISO 19108. Values based on calendars and clocks use lexical formats that are based
  /// on ISO 8601, as described in XML Schema Part 2:2001. A decimal value may be used with
  /// coordinate systems such as GPS time or UNIX time. A URI may be used to provide a reference
  /// to some era in an ordinal reference system. In common with many of the components modelled
  /// as data types in the ISO 19100 series of International Standards, the corresponding GML
  /// component has simple content. However, the content model TimePositionType is defined in
  /// several steps. Three XML attributes appear on TimePositionType:<br></br>
  /// A time value shall be associated with a temporal reference system through the frame attribute
  /// that provides a URI reference that identifies a description of the reference system.
  /// Following ISO 19108, the Gregorian calendar with UTC is the default reference system,
  /// but others may also be used. Components for describing temporal reference systems are
  /// described in 14.4, but it is not required that the reference system be described in this,
  /// as the reference may refer to anything that may be identified with a URI.
  /// For time values using a calendar containing more than one era, the (optional) calendarEraName
  /// attribute provides the name of the calendar era. Inexact temporal positions may be expressed
  /// using the optional indeterminatePosition attribute. This takes a value from an enumeration.
  /// </summary>
  [Serializable]
  [XmlType("TimePositionType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimePositionType")]
  public class TimePositionType : ObservableModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TimePositionType"/>.
    /// </summary>
    public TimePositionType() {
      _frame = "#ISO-8601";
    }

    #endregion

    #region Public Properties

    private string _frame;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("frame", DataType = "anyURI")]
    [DefaultValue("#ISO-8601")]
    [JsonProperty("frame")]
    public string Frame {
      get {
        return _frame;
      }
      set {
        if (_frame == value) {
          return;
        }
        if (_frame == null || _frame.Equals(value) != true) {
          _frame = value;
          OnPropertyChanged();
        }
      }
    }

    private string _calendarEraName;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("calendarEraName")]
    [JsonProperty("calendarEraName")]
    public string CalendarEraName {
      get {
        return _calendarEraName;
      }
      set {
        if (_calendarEraName == value) {
          return;
        }
        if (_calendarEraName == null || _calendarEraName.Equals(value) != true) {
          _calendarEraName = value;
          OnPropertyChanged();
        }
      }
    }

    private TimeIndeterminateValueType _indeterminatePosition;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("indeterminatePosition")]
    [JsonProperty("indeterminatePosition")]
    public TimeIndeterminateValueType IndeterminatePosition {
      get {
        return _indeterminatePosition;
      }
      set {
        if (_indeterminatePosition.Equals(value) != true) {
          _indeterminatePosition = value;
          OnPropertyChanged();
        }
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText()]
    [JsonProperty("Value")]
    public string Value {
      get {
        return _value;
      }
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
