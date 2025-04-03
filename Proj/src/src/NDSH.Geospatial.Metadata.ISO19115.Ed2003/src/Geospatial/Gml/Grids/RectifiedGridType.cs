
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : data, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/grids.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="RectifiedGrid" type="gml:RectifiedGridType" substitutionGroup="gml:Grid">
//   <annotation>
//     <documentation>
//       A rectified grid is a grid for which there is an affine transformation between
//       the grid coordinates and the coordinates of an external coordinate reference system.
//       It is defined by specifying the position (in some geometric space) of the grid “origin”
//       and of the vectors that specify the post locations.
//       Note that the grid limits (post indexes) and axis name properties are inherited
//       from gml:GridType and that gml:RectifiedGrid adds a gml:origin property
//       (contains or references a gml:Point) and a set of gml:offsetVector properties.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="RectifiedGridType">
//   <complexContent>
//     <extension base="gml:GridType">
//       <sequence>
//         <element name="origin" type="gml:PointPropertyType"/>
//         <element name="offsetVector" type="gml:VectorType" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using Newtonsoft.Json;
using System.Xml.Serialization;
#endregion

namespace NDSH.Geospatial.Gml.Grids {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("RectifiedGridType")]
  public class RectifiedGridType : GridType {
    #region Private fields
    private PointPropertyType _origin;
    private List<VectorType> _offsetVector;
    #endregion

    /// <summary>
    /// RectifiedGridType class constructor
    /// </summary>
    public RectifiedGridType() {
      _offsetVector = new List<VectorType>();
      _origin = new PointPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("origin", Order = 0)]
    public PointPropertyType Origin {
      get {
        return _origin;
      }
      set {
        if (_origin == value) {
          return;
        }
        if (_origin == null || _origin.Equals(value) != true) {
          _origin = value;
          OnPropertyChanged("Origin");
        }
      }
    }

    [XmlElement("offsetVector", Order = 1)]
    [JsonProperty("offsetVector", Order = 1)]
    public List<VectorType> OffsetVector {
      get {
        return _offsetVector;
      }
      set {
        if (_offsetVector == value) {
          return;
        }
        if (_offsetVector == null || _offsetVector.Equals(value) != true) {
          _offsetVector = value;
          OnPropertyChanged("OffsetVector");
        }
      }
    }
  }
}
