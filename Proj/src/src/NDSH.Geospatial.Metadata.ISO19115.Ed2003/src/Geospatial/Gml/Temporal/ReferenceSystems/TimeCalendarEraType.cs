
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/02/2023, 03:43, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/temporalReferenceSystems.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="TimeCalendarEra" type="gml:TimeCalendarEraType">
//   <annotation>
//     <documentation>
//       gml:TimeCalendarEra inherits basic properties from gml:DefinitionType and has the following additional properties:
//       -  gml:referenceEvent is the name or description of a mythical or historic event which fixes the position of the base scale of the calendar era.  This is given as text or using a link to description held elsewhere.
//       -  gml:referenceDate specifies the date of the referenceEvent expressed as a date in the given calendar.  In most calendars, this date is the origin (i.e., the first day) of the scale, but this is not always true.
//       -  gml:julianReference specifies the Julian date that corresponds to the reference date.  The Julian day number is an integer value; the Julian date is a decimal value that allows greater resolution.  Transforming calendar dates to and from Julian dates provides a relatively simple basis for transforming dates from one calendar to another.
//       -  gml:epochOfUse is the period for which the calendar era was used as a basis for dating.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeCalendarEraType">
//   <complexContent>
//     <extension base="gml:DefinitionType">
//       <sequence>
//         <element name="referenceEvent" type="gml:StringOrRefType"/>
//         <element name="referenceDate" type="gml:CalDate"/>
//         <element name="julianReference" type="decimal"/>
//         <element name="epochOfUse" type="gml:TimePeriodPropertyType"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeCalendarEraPropertyType">
//   <annotation>
//     <documentation>gml:TimeCalendarEraPropertyType provides for associating a gml:TimeCalendarEra with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeCalendarEra"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Dictionary;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.ReferenceSystems {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCalendarEraType")]
  public class TimeCalendarEraType : DefinitionType {
    #region Private fields
    private StringOrRefType _referenceEvent;
    private string _referenceDate;
    private decimal _julianReference;
    private TimePeriodPropertyType _epochOfUse;
    #endregion

    /// <summary>
    /// TimeCalendarEraType class constructor
    /// </summary>
    public TimeCalendarEraType() {
      _epochOfUse = new TimePeriodPropertyType();
      _referenceEvent = new StringOrRefType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("referenceEvent", Order = 0)]
    public StringOrRefType ReferenceEvent {
      get {
        return _referenceEvent;
      }
      set {
        if (_referenceEvent == value) {
          return;
        }
        if (_referenceEvent == null || _referenceEvent.Equals(value) != true) {
          _referenceEvent = value;
          OnPropertyChanged("ReferenceEvent");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("referenceDate", Order = 1)]
    public string ReferenceDate {
      get {
        return _referenceDate;
      }
      set {
        if (_referenceDate == value) {
          return;
        }
        if (_referenceDate == null || _referenceDate.Equals(value) != true) {
          _referenceDate = value;
          OnPropertyChanged("ReferenceDate");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("julianReference", Order = 2)]
    public decimal JulianReference {
      get {
        return _julianReference;
      }
      set {
        if (_julianReference.Equals(value) != true) {
          _julianReference = value;
          OnPropertyChanged("JulianReference");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("epochOfUse", Order = 3)]
    public TimePeriodPropertyType EpochOfUse {
      get {
        return _epochOfUse;
      }
      set {
        if (_epochOfUse == value) {
          return;
        }
        if (_epochOfUse == null || _epochOfUse.Equals(value) != true) {
          _epochOfUse = value;
          OnPropertyChanged("EpochOfUse");
        }
      }
    }
  }
}
