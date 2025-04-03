
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
// XSD               : /2005/gml/temporal.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="TimePeriod" type="gml:TimePeriodType" substitutionGroup="gml:AbstractTimeGeometricPrimitive">
//   <annotation>
//     <documentation>
//       gml:TimePeriod acts as a one-dimensional geometric primitive that represents an identifiable extent in time.
//       The location in of a gml:TimePeriod is described by the temporal positions of the instants at which it begins and ends.
//       The length of the period is equal to the temporal distance between the two bounding temporal positions. 
//       Both beginning and end may be described in terms of their direct position using gml:TimePositionType which is an
//       XML Schema simple content type, or by reference to an indentifiable time instant using gml:TimeInstantPropertyType.
//       Alternatively a limit of a gml:TimePeriod may use the conventional GML property model to make a reference to a
//       time instant described elsewhere, or a limit may be indicated as a direct position.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimePeriodType">
//   <complexContent>
//     <extension base="gml:AbstractTimeGeometricPrimitiveType">
//       <sequence>
//         <choice>
//           <element name="beginPosition" type="gml:TimePositionType"/>
//           <element name="begin" type="gml:TimeInstantPropertyType"/>
//         </choice>
//         <choice>
//           <element name="endPosition" type="gml:TimePositionType"/>
//           <element name="end" type="gml:TimeInstantPropertyType"/>
//         </choice>
//         <group ref="gml:timeLength" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <complexType name="TimePeriodPropertyType">
//   <annotation>
//     <documentation>gml:TimePeriodPropertyType provides for associating a gml:TimePeriod with an object.</documentation>
//   </annotation>
//   <sequence minOccurs="0">
//     <element ref="gml:TimePeriod"/>
//   </sequence>
//   <attributeGroup ref="gml:AssociationAttributeGroup"/>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimePeriodType")]
  public class TimePeriodType : AbstractTimeGeometricPrimitiveType {
    #region Private fields
    private object _item;
    private object _item1;
    private string _duration;
    private TimeIntervalLengthType _timeInterval;
    #endregion

    /// <summary>
    /// TimePeriodType class constructor
    /// </summary>
    public TimePeriodType() {
      _timeInterval = new TimeIntervalLengthType();
    }

    [XmlElement("begin", typeof(TimeInstantPropertyType), Order = 0)]
    [XmlElement("beginPosition", typeof(TimePositionType), Order = 0)]
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

    [XmlElement("end", typeof(TimeInstantPropertyType), Order = 1)]
    [XmlElement("endPosition", typeof(TimePositionType), Order = 1)]
    public object Item1 {
      get {
        return _item1;
      }
      set {
        if (_item1 == value) {
          return;
        }
        if (_item1 == null || _item1.Equals(value) != true) {
          _item1 = value;
          OnPropertyChanged("Item1");
        }
      }
    }

    [XmlElement(DataType = "duration", Order = 2)]
    [JsonProperty("duration", Order = 2)]
    public string Duration {
      get {
        return _duration;
      }
      set {
        if (_duration == value) {
          return;
        }
        if (_duration == null || _duration.Equals(value) != true) {
          _duration = value;
          OnPropertyChanged("Duration");
        }
      }
    }

    [XmlElement(Order = 3)]
    [JsonProperty("timeInterval", Order = 3)]
    public TimeIntervalLengthType TimeInterval {
      get {
        return _timeInterval;
      }
      set {
        if (_timeInterval == value) {
          return;
        }
        if (_timeInterval == null || _timeInterval.Equals(value) != true) {
          _timeInterval = value;
          OnPropertyChanged("TimeInterval");
        }
      }
    }
  }

}
