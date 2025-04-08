
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
// <element name="TimeReferenceSystem" type="gml:TimeReferenceSystemType" substitutionGroup="gml:Definition">
//   <annotation>
//     <documentation>
//       A reference system is characterized in terms of its domain of validity: the spatial and temporal
//       extent over which it is applicable. The basic GML element for temporal reference systems is gml:TimeReferenceSystem.
//       Its content model extends gml:DefinitionType with one additional property, gml:domainOfValidity.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeReferenceSystemType">
//   <complexContent>
//     <extension base="gml:DefinitionType">
//       <sequence>
//         <element name="domainOfValidity" type="string"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Dictionary;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal.ReferenceSystems {


  //[XmlInclude(typeof(TimeOrdinalReferenceSystemType))]
  //[XmlInclude(typeof(TimeClockType))]
  //[XmlInclude(typeof(TimeCalendarType))]
  //[XmlInclude(typeof(TimeCoordinateSystemType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeReferenceSystemType")]
  public class TimeReferenceSystemType : DefinitionType {
    #region Private fields
    private string _domainOfValidity;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("domainOfValidity", Order = 0)]
    public string DomainOfValidity {
      get {
        return _domainOfValidity;
      }
      set {
        if (_domainOfValidity == value) {
          return;
        }
        if (_domainOfValidity == null || _domainOfValidity.Equals(value) != true) {
          _domainOfValidity = value;
          OnPropertyChanged("DomainOfValidity");
        }
      }
    }
  }
}
