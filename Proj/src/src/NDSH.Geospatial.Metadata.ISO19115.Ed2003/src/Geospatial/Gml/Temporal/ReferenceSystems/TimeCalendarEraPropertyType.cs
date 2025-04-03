
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
using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.ReferenceSystems {


  /// <summary>
  /// gml:TimeCalendarEraPropertyType provides for associating a gml:TimeCalendarEra with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCalendarEraPropertyType")]
  public class TimeCalendarEraPropertyType : ObservableModel {
    #region Private fields
    private TimeCalendarEraType _timeCalendarEra;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TimeCalendarEraPropertyType class constructor
    /// </summary>
    public TimeCalendarEraPropertyType() {
      _timeCalendarEra = default; // new TimeCalendarEraType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeCalendarEra", Order = 0)]
    public TimeCalendarEraType TimeCalendarEra {
      get {
        return _timeCalendarEra;
      }
      set {
        if (_timeCalendarEra == value) {
          return;
        }
        if (_timeCalendarEra == null || _timeCalendarEra.Equals(value) != true) {
          _timeCalendarEra = value;
          OnPropertyChanged("TimeCalendarEra");
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
