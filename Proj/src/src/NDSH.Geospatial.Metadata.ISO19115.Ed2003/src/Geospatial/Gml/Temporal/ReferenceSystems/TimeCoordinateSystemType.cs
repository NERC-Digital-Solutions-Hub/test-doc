
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
// <element name="TimeCoordinateSystem" type="gml:TimeCoordinateSystemType" substitutionGroup="gml:TimeReferenceSystem">
//   <annotation>
//     <documentation>
//       A temporal coordinate system shall be based on a continuous interval scale defined in terms of a single time interval.
//       The differences to ISO 19108 TM_CoordinateSystem are:
//       -  the origin is specified either using the property gml:originPosition whose value is a direct time position, or using the property gml:origin whose model is gml:TimeInstantPropertyType; this permits more flexibility in representation and also supports referring to a value fixed elsewhere;
//       -  the interval uses gml:TimeIntervalLengthType.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeCoordinateSystemType">
//   <complexContent>
//     <extension base="gml:TimeReferenceSystemType">
//       <sequence>
//         <choice>
//           <element name="originPosition" type="gml:TimePositionType"/>
//           <element name="origin" type="gml:TimeInstantPropertyType"/>
//         </choice>
//         <element name="interval" type="gml:TimeIntervalLengthType"/>
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
  [JsonObject("TimeCoordinateSystemType")]
  public class TimeCoordinateSystemType : TimeReferenceSystemType {
    #region Private fields
    private object _item;
    private TimeIntervalLengthType _interval;
    #endregion

    /// <summary>
    /// TimeCoordinateSystemType class constructor
    /// </summary>
    public TimeCoordinateSystemType() {
      _interval = new TimeIntervalLengthType();
    }

    [XmlElement("origin", typeof(TimeInstantPropertyType), Order = 0)]
    [XmlElement("originPosition", typeof(TimePositionType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

    [XmlElement(Order = 1)]
    [JsonProperty("interval", Order = 1)]
    public TimeIntervalLengthType Interval {
      get {
        return _interval;
      }
      set {
        if (_interval == value) {
          return;
        }
        if (_interval == null || _interval.Equals(value) != true) {
          _interval = value;
          OnPropertyChanged("Interval");
        }
      }
    }
  }
}
