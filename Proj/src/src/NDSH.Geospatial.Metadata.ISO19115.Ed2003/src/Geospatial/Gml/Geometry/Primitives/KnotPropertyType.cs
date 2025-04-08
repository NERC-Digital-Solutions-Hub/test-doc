
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
  /// gml:KnotPropertyType encapsulates a knot to use it in a geometric type.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("KnotPropertyType")]
  public class KnotPropertyType : ObservableModel {
    #region Private fields
    private KnotType _knot;
    #endregion

    /// <summary>
    /// KnotPropertyType class constructor
    /// </summary>
    public KnotPropertyType() {
      _knot = new KnotType();
    }

    /// <summary>
    /// A knot is a breakpoint on a piecewise spline curve.
    /// value is the value of the parameter at the knot of the spline (see ISO 19107:2003, 6.4.24.2).
    /// multiplicity is the multiplicity of this knot used in the definition of the spline (with the same weight).
    /// weight is the value of the averaging weight used for this knot of the spline.
    /// </summary>
    [XmlElement(Order = 0)]
    [JsonProperty("Knot", Order = 0)]
    public KnotType Knot {
      get {
        return _knot;
      }
      set {
        if (_knot == value) {
          return;
        }
        if (_knot == null || _knot.Equals(value) != true) {
          _knot = value;
          OnPropertyChanged("Knot");
        }
      }
    }
  }


}
