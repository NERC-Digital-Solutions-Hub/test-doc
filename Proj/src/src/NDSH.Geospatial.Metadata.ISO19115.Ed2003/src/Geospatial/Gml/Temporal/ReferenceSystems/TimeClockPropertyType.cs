
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
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.ReferenceSystems {


  /// <summary>
  /// gml:TimeClockPropertyType provides for associating a gml:TimeClock with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeClockPropertyType")]
  public class TimeClockPropertyType : ObservableModel {
    #region Private fields
    private TimeClockType _timeClock;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TimeClockPropertyType class constructor
    /// </summary>
    public TimeClockPropertyType() {
      _timeClock = default; // new TimeClockType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeClock", Order = 0)]
    public TimeClockType TimeClock {
      get {
        return _timeClock;
      }
      set {
        if (_timeClock == value) {
          return;
        }
        if (_timeClock == null || _timeClock.Equals(value) != true) {
          _timeClock = value;
          OnPropertyChanged("TimeClock");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty("owns")]
    public bool Owns {
      get {
        return _owns;
      }
      set {
        if (_owns.Equals(value) != true) {
          _owns = value;
          OnPropertyChanged("Owns");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("nilReason")]
    public string NilReason {
      get {
        return _nilReason;
      }
      set {
        if (_nilReason == value) {
          return;
        }
        if (_nilReason == null || _nilReason.Equals(value) != true) {
          _nilReason = value;
          OnPropertyChanged("NilReason");
        }
      }
    }

    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "anyURI")]
    [JsonProperty("remoteSchema")]
    public string RemoteSchema {
      get {
        return _remoteSchema;
      }
      set {
        if (_remoteSchema == value) {
          return;
        }
        if (_remoteSchema == null || _remoteSchema.Equals(value) != true) {
          _remoteSchema = value;
          OnPropertyChanged("RemoteSchema");
        }
      }
    }
  }
}
