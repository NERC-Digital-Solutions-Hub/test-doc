
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
// <complexType name="AbstractGriddedSurfaceType" abstract="true">
//   <complexContent>
//     <extension base="gml:AbstractParametricCurveSurfaceType">
//       <sequence>
//         <group ref="gml:PointGrid"/>
//       </sequence>
//       <attribute name="rows" type="integer"/>
//       <attribute name="columns" type="integer"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="AbstractGriddedSurface" type="gml:AbstractGriddedSurfaceType" abstract="true" substitutionGroup="gml:AbstractParametricCurveSurface">
//   <annotation>
//     <documentation>
//       If provided, rows gives the number of rows, columns the number of columns in the parameter grid.
//       The parameter grid is represented by an instance of the gml:PointGrid group.
//       The element provides a substitution group head for the surface patches based on a grid.
//       All derived subtypes shall conform to the constraints specified in ISO 19107:2003, 6.4.41.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion


using Newtonsoft.Json;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(SphereType))]
  //[XmlInclude(typeof(CylinderType))]
  //[XmlInclude(typeof(ConeType))]
  [Serializable]
  //[XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGriddedSurfaceType")]
  public abstract class AbstractGriddedSurfaceType : AbstractParametricCurveSurfaceType {
    #region Private fields
    private List<AbstractGriddedSurfaceTypeRow> _rows;
    private string _rows1;
    private string _columns;
    #endregion

    /// <summary>
    /// AbstractGriddedSurfaceType class constructor
    /// </summary>
    public AbstractGriddedSurfaceType() {
      _rows = new List<AbstractGriddedSurfaceTypeRow>();
    }

    [XmlArray(Order = 0)]
    [XmlArrayItem("Row", IsNullable = false)]
    [JsonProperty("Row", Order = 0)]
    public List<AbstractGriddedSurfaceTypeRow> Rows {
      get {
        return _rows;
      }
      set {
        if (_rows == value) {
          return;
        }
        if (_rows == null || _rows.Equals(value) != true) {
          _rows = value;
          OnPropertyChanged("Rows");
        }
      }
    }

    [XmlAttribute("rows", DataType = "integer")]
    public string Rows1 {
      get {
        return _rows1;
      }
      set {
        if (_rows1 == value) {
          return;
        }
        if (_rows1 == null || _rows1.Equals(value) != true) {
          _rows1 = value;
          OnPropertyChanged("Rows1");
        }
      }
    }

    [XmlAttribute(DataType = "integer")]
    [JsonProperty("columns")]
    public string Columns {
      get {
        return _columns;
      }
      set {
        if (_columns == value) {
          return;
        }
        if (_columns == null || _columns.Equals(value) != true) {
          _columns = value;
          OnPropertyChanged("Columns");
        }
      }
    }
  }

}
