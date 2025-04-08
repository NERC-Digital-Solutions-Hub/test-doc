
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
// <element name="timeInterval" type="gml:TimeIntervalLengthType">
//   <annotation>
//     <documentation>
//       gml:timeInterval conforms to ISO 11404 which is based on floating point values for temporal length.
//       ISO 11404 syntax specifies the use of a positiveInteger together with appropriate values for radix and factor.
//       The resolution of the time interval is to one radix ^(-factor) of the specified time unit.
//       The value of the unit is either selected from the units for time intervals from ISO 31-1:1992, or is another suitable unit.
//       The encoding is defined for GML in gml:TimeUnitType. The second component of this union type provides a method for
//       indicating time units other than the six standard units given in the enumeration.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="TimeIntervalLengthType" final="#all">
//   <simpleContent>
//     <extension base="decimal">
//       <attribute name="unit" type="gml:TimeUnitType" use="required"/>
//       <attribute name="radix" type="positiveInteger"/>
//       <attribute name="factor" type="integer"/>
//     </extension>
//   </simpleContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Temporal {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeIntervalLengthType")]
  public class TimeIntervalLengthType : ObservableModel {
    #region Private fields
    private string _unit;
    private string _radix;
    private string _factor;
    private decimal _value;
    #endregion

    [XmlAttribute]
    [JsonProperty("unit")]
    public string Unit {
      get {
        return _unit;
      }
      set {
        if (_unit == value) {
          return;
        }
        if (_unit == null || _unit.Equals(value) != true) {
          _unit = value;
          OnPropertyChanged("Unit");
        }
      }
    }

    [XmlAttribute(DataType = "positiveInteger")]
    [JsonProperty("radix")]
    public string Radix {
      get {
        return _radix;
      }
      set {
        if (_radix == value) {
          return;
        }
        if (_radix == null || _radix.Equals(value) != true) {
          _radix = value;
          OnPropertyChanged("Radix");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [JsonProperty("factor")]
    public string Factor {
      get {
        return _factor;
      }
      set {
        if (_factor == value) {
          return;
        }
        if (_factor == null || _factor.Equals(value) != true) {
          _factor = value;
          OnPropertyChanged("Factor");
        }
      }
    }

    [XmlTextAttribute]
    [JsonProperty("Value")]
    public decimal Value {
      get {
        return _value;
      }
      set {
        if (_value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged("Value");
        }
      }
    }
  }

}
