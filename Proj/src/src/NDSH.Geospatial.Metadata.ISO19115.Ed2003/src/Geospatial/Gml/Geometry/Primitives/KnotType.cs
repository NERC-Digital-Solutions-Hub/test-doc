
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
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="KnotType">
//   <sequence>
//     <element name="value" type="double"/>
//     <element name="multiplicity" type="nonNegativeInteger"/>
//     <element name="weight" type="double"/>
//   </sequence>
// </complexType>
// <complexType name="KnotPropertyType">
//   <annotation>
//     <documentation>gml:KnotPropertyType encapsulates a knot to use it in a geometric type.</documentation>
//   </annotation>
//   <sequence>
//     <element name="Knot" type="gml:KnotType">
//       <annotation>
//         <documentation>
//           A knot is a breakpoint on a piecewise spline curve.
//           value is the value of the parameter at the knot of the spline (see ISO 19107:2003, 6.4.24.2).
//           multiplicity is the multiplicity of this knot used in the definition of the spline (with the same weight).
//           weight is the value of the averaging weight used for this knot of the spline.
//         </documentation>
//       </annotation>
//     </element>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("KnotType")]
  public class KnotType : ObservableModel {
    #region Private fields
    private double _value;
    private string _multiplicity;
    private double _weight;
    #endregion

    [XmlElement(Order = 0)]
    [JsonProperty("value", Order = 0)]
    public double Value {
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

    [XmlElement(DataType = "nonNegativeInteger", Order = 1)]
    [JsonProperty("multiplicity", Order = 1)]
    public string Multiplicity {
      get {
        return _multiplicity;
      }
      set {
        if (_multiplicity == value) {
          return;
        }
        if (_multiplicity == null || _multiplicity.Equals(value) != true) {
          _multiplicity = value;
          OnPropertyChanged("Multiplicity");
        }
      }
    }

    [XmlElement(Order = 2)]
    [JsonProperty("weight", Order = 2)]
    public double Weight {
      get {
        return _weight;
      }
      set {
        if (_weight.Equals(value) != true) {
          _weight = value;
          OnPropertyChanged("Weight");
        }
      }
    }
  }

}
