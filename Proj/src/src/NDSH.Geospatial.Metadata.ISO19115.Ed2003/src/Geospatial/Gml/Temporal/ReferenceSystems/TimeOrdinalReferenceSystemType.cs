
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
// <element name="TimeOrdinalReferenceSystem" type="gml:TimeOrdinalReferenceSystemType" substitutionGroup="gml:TimeReferenceSystem">
//   <annotation>
//     <documentation>
//       In some applications of geographic information — such as geology and archaeology — relative
//       position in time is known more precisely than absolute time or duration.
//       The order of events in time can be well established, but the magnitude of the intervals
//       between them cannot be accurately determined; in such cases, the use of an ordinal temporal
//       reference system is appropriate. An ordinal temporal reference system is composed of a
//       sequence of named coterminous eras, which may in turn be composed of sequences of member
//       eras at a finer scale, giving the whole a hierarchical structure of eras of verying resolution. 
//       An ordinal temporal reference system whose component eras are not further subdivided is effectively
//       a temporal topological complex constrained to be a linear graph. An ordinal temporal reference
//       system some or all of whose component eras are subdivided is effectively a temporal topological
//       complex with the constraint that parallel branches may only be constructed in pairs where one is a
//       single temporal ordinal era and the other is a sequence of temporal ordinal eras that are called
//       "members" of the "group". This constraint means that within a single temporal ordinal reference system,
//       the relative position of all temporal ordinal eras is unambiguous.  
//       The positions of the beginning and end of a given era may calibrate the relative time scale.
//       gml:TimeOrdinalReferenceSystem adds one or more gml:component properties to the generic temporal reference system model.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeOrdinalReferenceSystemType">
//   <complexContent>
//     <extension base="gml:TimeReferenceSystemType">
//       <sequence>
//         <element name="component" type="gml:TimeOrdinalEraPropertyType" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
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
  [JsonObject("TimeOrdinalReferenceSystemType")]
  public class TimeOrdinalReferenceSystemType : TimeReferenceSystemType {
    #region Private fields
    private List<TimeOrdinalEraPropertyType> _component;
    #endregion

    /// <summary>
    /// TimeOrdinalReferenceSystemType class constructor
    /// </summary>
    public TimeOrdinalReferenceSystemType() {
      _component = new List<TimeOrdinalEraPropertyType>();
    }

    [XmlElement("component", Order = 0)]
    [JsonProperty("component", Order = 0)]
    public List<TimeOrdinalEraPropertyType> Component {
      get {
        return _component;
      }
      set {
        if (_component == value) {
          return;
        }
        if (_component == null || _component.Equals(value) != true) {
          _component = value;
          OnPropertyChanged("Component");
        }
      }
    }
  }
}
