
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : date, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/coverage.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="SequenceRuleType">
//   <annotation>
//     <documentation>
//       The gml:SequenceRuleType is derived from the gml:SequenceRuleEnumeration through the addition of
//       an axisOrder attribute.  The gml:SequenceRuleEnumeration is an enumerated type.
//       The rule names are defined in ISO 19123. If no rule name is specified the default is “Linear”.
//     </documentation>
//   </annotation>
//   <simpleContent>
//     <extension base="gml:SequenceRuleEnumeration">
//       <attribute name="order" type="gml:IncrementOrder">
//         <annotation>
//           <appinfo>deprecated</appinfo>
//         </annotation>
//       </attribute>
//       <attribute name="axisOrder" type="gml:AxisDirectionList"/>
//     </extension>
//   </simpleContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Coverage {

  /// <summary>
  /// The gml:SequenceRuleType is derived from the gml:SequenceRuleEnumeration through the addition of an axisOrder attribute.  The gml:SequenceRuleEnumeration is an enumerated type. The rule names are defined in ISO 19123. If no rule name is specified the default is “Linear”.
  /// </summary>
  [IsoType("SequenceRuleType", IsoType = IsoTypes.ComplexType)]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("SequenceRuleType")]
  public class SequenceRuleType : ObservableModel {

    #region Private fields
    private IncrementOrder _order;
    private List<string> _axisOrder;
    private SequenceRuleEnumeration _value;
    #endregion

    /// <summary>
    /// SequenceRuleType class constructor
    /// </summary>
    public SequenceRuleType() {
      _axisOrder = new List<string>();
    }

    [XmlAttribute]
    [JsonProperty("order")]
    public IncrementOrder Order {
      get {
        return _order;
      }
      set {
        if (_order.Equals(value) != true) {
          _order = value;
          OnPropertyChanged("Order");
        }
      }
    }

    [XmlAttribute]
    [JsonProperty("axisOrder")]
    public List<string> AxisOrder {
      get {
        return _axisOrder;
      }
      set {
        if (_axisOrder == value) {
          return;
        }
        if (_axisOrder == null || _axisOrder.Equals(value) != true) {
          _axisOrder = value;
          OnPropertyChanged("AxisOrder");
        }
      }
    }

    [XmlTextAttribute]
    [JsonProperty("Value")]
    public SequenceRuleEnumeration Value {
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
