
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
// <complexType name="OrientableCurveType">
//   <complexContent>
//     <extension base="gml:AbstractCurveType">
//       <sequence>
//         <element ref="gml:baseCurve"/>
//       </sequence>
//       <attribute name="orientation" type="gml:SignType" default="+"/>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OrientableCurveType")]
  public class OrientableCurveType : AbstractCurveType {
    #region Private fields
    private CurvePropertyType _baseCurve;
    private SignType _orientation;
    #endregion

    /// <summary>
    /// OrientableCurveType class constructor
    /// </summary>
    public OrientableCurveType() {
      _baseCurve = new CurvePropertyType();
      _orientation = SignType.Plus;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("baseCurve", Order = 0)]
    public CurvePropertyType BaseCurve {
      get {
        return _baseCurve;
      }
      set {
        if (_baseCurve == value) {
          return;
        }
        if (_baseCurve == null || _baseCurve.Equals(value) != true) {
          _baseCurve = value;
          OnPropertyChanged("BaseCurve");
        }
      }
    }

    [XmlAttribute]
    [DefaultValue(SignType.Plus)]
    [JsonProperty("orientation")]
    public SignType Orientation {
      get {
        return _orientation;
      }
      set {
        if (_orientation.Equals(value) != true) {
          _orientation = value;
          OnPropertyChanged("Orientation");
        }
      }
    }
  }

}
