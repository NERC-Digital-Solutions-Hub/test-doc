
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
// <element name="TimeClock" type="gml:TimeClockType" substitutionGroup="gml:TimeReferenceSystem">
//   <annotation>
//     <documentation>
//       A clock provides a basis for defining temporal position within a day.
//       A clock shall be used with a calendar in order to provide a complete description of a temporal
//       position within a specific day.
//       gml:TimeClock adds the following properties to those inherited from gml:TimeReferenceSystemType:
//       -  gml:referenceEvent is the name or description of an event, such as solar noon or sunrise, which fixes the position of the base scale of the clock.
//       -  gml:referenceTime specifies the time of day associated with the reference event expressed as a time of day in the given clock. The reference time is usually the origin of the clock scale. 
//       -  gml:utcReference specifies the 24 hour local or UTC time that corresponds to the reference time.
//       -  gml:dateBasis contains or references the calendars that use this clock.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeClockType" final="#all">
//   <complexContent>
//     <extension base="gml:TimeReferenceSystemType">
//       <sequence>
//         <element name="referenceEvent" type="gml:StringOrRefType"/>
//         <element name="referenceTime" type="time"/>
//         <element name="utcReference" type="time"/>
//         <element name="dateBasis" type="gml:TimeCalendarPropertyType" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeClockPropertyType">
//   <annotation>
//     <documentation>gml:TimeClockPropertyType provides for associating a gml:TimeClock with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeClock"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.ReferenceSystems {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeClockType")]
  public sealed class TimeClockType : TimeReferenceSystemType {
    #region Private fields
    private StringOrRefType _referenceEvent;
    private DateTime _referenceTime;
    private DateTime _utcReference;
    private List<TimeCalendarPropertyType> _dateBasis;
    #endregion

    /// <summary>
    /// TimeClockType class constructor
    /// </summary>
    public TimeClockType() {
      _dateBasis = new List<TimeCalendarPropertyType>();
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

    [XmlElement(DataType = "time", Order = 1)]
    [JsonProperty("referenceTime", Order = 1)]
    public DateTime ReferenceTime {
      get {
        return _referenceTime;
      }
      set {
        if (_referenceTime.Equals(value) != true) {
          _referenceTime = value;
          OnPropertyChanged("ReferenceTime");
        }
      }
    }

    [XmlElement(DataType = "time", Order = 2)]
    [JsonProperty("utcReference", Order = 2)]
    public DateTime UtcReference {
      get {
        return _utcReference;
      }
      set {
        if (_utcReference.Equals(value) != true) {
          _utcReference = value;
          OnPropertyChanged("UtcReference");
        }
      }
    }

    [XmlElement("dateBasis", Order = 3)]
    [JsonProperty("dateBasis", Order = 3)]
    public List<TimeCalendarPropertyType> DateBasis {
      get {
        return _dateBasis;
      }
      set {
        if (_dateBasis == value) {
          return;
        }
        if (_dateBasis == null || _dateBasis.Equals(value) != true) {
          _dateBasis = value;
          OnPropertyChanged("DateBasis");
        }
      }
    }
  }
}
