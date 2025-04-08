
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
// <element name="TimeCalendar" type="gml:TimeCalendarType" substitutionGroup="gml:TimeReferenceSystem">
//   <annotation>
//     <documentation>
//       A calendar is a discrete temporal reference system that provides a
//       basis for defining temporal position to a resolution of one day.
//       gml:TimeCalendar adds one property to those inherited from gml:TimeReferenceSystem.
//       A gml:referenceFrame provides a link to a gml:TimeCalendarEra that it uses.
//       A gml:TimeCalendar may reference more than one calendar era. 
//       The referenceFrame element follows the standard GML property model,
//       allowing the association to be instantiated either using an inline description using
//       the gml:TimeCalendarEra element, or a link to a gml:TimeCalendarEra which is explicit elsewhere.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeCalendarType">
//   <complexContent>
//     <extension base="gml:TimeReferenceSystemType">
//       <sequence>
//         <element name="referenceFrame" type="gml:TimeCalendarEraPropertyType" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimeCalendarPropertyType">
//   <annotation>
//     <documentation>gml:TimeCalendarPropertyType provides for associating a gml:TimeCalendar with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimeCalendar"/>
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
  /// gml:TimeCalendarPropertyType provides for associating a gml:TimeCalendar with an object.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCalendarPropertyType")]
  public class TimeCalendarPropertyType : ObservableModel {
    #region Private fields
    private TimeCalendarType _timeCalendar;
    private bool _owns;
    private string _nilReason;
    private string _remoteSchema;
    #endregion

    /// <summary>
    /// TimeCalendarPropertyType class constructor
    /// </summary>
    public TimeCalendarPropertyType() {
      _timeCalendar = default; // new TimeCalendarType();
      _owns = false;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("TimeCalendar", Order = 0)]
    public TimeCalendarType TimeCalendar {
      get {
        return _timeCalendar;
      }
      set {
        if (_timeCalendar == value) {
          return;
        }
        if (_timeCalendar == null || _timeCalendar.Equals(value) != true) {
          _timeCalendar = value;
          OnPropertyChanged("TimeCalendar");
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
