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
// XSD               : /2005/gml/geometryAggregates.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="CurveArrayPropertyType">
//   <annotation>
//     <documentation>
//       A container for an array of curves. The elements are always contained in the array property, referencing 
//       geometry elements or arrays of geometry elements via XLinks is not supported.
//     </documentation>
//   </annotation>
//   <sequence minOccurs="0" maxOccurs="unbounded">
//     <element ref="gml:AbstractCurve"/>
//   </sequence>
//   <attributeGroup ref="gml:OwnershipAttributeGroup"/>
// </complexType>
// <element name="curveArrayProperty" type="gml:CurveArrayPropertyType">
//   <annotation>
//     <documentation>
//        This property element contains a list of curve elements. curveArrayProperty is the predefined
//        property which may be used by GML Application Schemas whenever a GML feature has a property with a 
//        value that is substitutable for a list of curves.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Apps;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {


  /// <summary>
  /// A container for an array of curves. The elements are always contained in the array property, referencing geometry elements or arrays of geometry elements via XLinks is not supported.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CurveArrayPropertyType")]
  public class CurveArrayPropertyType : ObservableModel {
    #region Private fields
    private List<AbstractCurveType> _abstractCurve;
    private bool _owns;
    #endregion

    /// <summary>
    /// CurveArrayPropertyType class constructor
    /// </summary>
    public CurveArrayPropertyType() {
      _abstractCurve = new List<AbstractCurveType>();
      _owns = false;
    }

    [XmlElement("AbstractCurve", Order = 0)]
    [JsonProperty("AbstractCurve", Order = 0)]
    public List<AbstractCurveType> AbstractCurve {
      get {
        return _abstractCurve;
      }
      set {
        if (_abstractCurve == value) {
          return;
        }
        if (_abstractCurve == null || _abstractCurve.Equals(value) != true) {
          _abstractCurve = value;
          OnPropertyChanged("AbstractCurve");
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
  }
}
