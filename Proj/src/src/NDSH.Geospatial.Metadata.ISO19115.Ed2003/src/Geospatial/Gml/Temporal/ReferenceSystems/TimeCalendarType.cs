
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
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.ReferenceSystems {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCalendarType")]
  public class TimeCalendarType : TimeReferenceSystemType {
    #region Private fields
    private List<TimeCalendarEraPropertyType> _referenceFrame;
    #endregion

    /// <summary>
    /// TimeCalendarType class constructor
    /// </summary>
    public TimeCalendarType() {
      _referenceFrame = new List<TimeCalendarEraPropertyType>();
    }

    [XmlElement("referenceFrame", Order = 0)]
    [JsonProperty("referenceFrame", Order = 0)]
    public List<TimeCalendarEraPropertyType> ReferenceFrame {
      get {
        return _referenceFrame;
      }
      set {
        if (_referenceFrame == value) {
          return;
        }
        if (_referenceFrame == null || _referenceFrame.Equals(value) != true) {
          _referenceFrame = value;
          OnPropertyChanged("ReferenceFrame");
        }
      }
    }
  }
}
