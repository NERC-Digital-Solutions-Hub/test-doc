
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
// <complexType name="OrientableSurfaceType">
//   <complexContent>
//     <extension base="gml:AbstractSurfaceType">
//       <sequence>
//         <element ref="gml:baseSurface"/>
//       </sequence>
//       <attribute name="orientation" type="gml:SignType" default="+"/>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Geometry.Basic2D;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("OrientableSurfaceType")]
  public class OrientableSurfaceType : AbstractSurfaceType {
    #region Private fields
    private SurfacePropertyType _baseSurface;
    private SignType _orientation;
    #endregion

    /// <summary>
    /// OrientableSurfaceType class constructor
    /// </summary>
    public OrientableSurfaceType() {
      _baseSurface = new SurfacePropertyType();
      _orientation = SignType.Plus;
    }

    [XmlElement(Order = 0)]
    [JsonProperty("baseSurface", Order = 0)]
    public SurfacePropertyType BaseSurface {
      get {
        return _baseSurface;
      }
      set {
        if (_baseSurface == value) {
          return;
        }
        if (_baseSurface == null || _baseSurface.Equals(value) != true) {
          _baseSurface = value;
          OnPropertyChanged("BaseSurface");
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
