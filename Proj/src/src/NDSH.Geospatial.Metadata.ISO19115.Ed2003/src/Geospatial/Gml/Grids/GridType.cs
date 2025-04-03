
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/grids.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="Grid" type="gml:GridType" substitutionGroup="gml:AbstractImplicitGeometry">
//   <annotation>
//     <documentation>
//       The gml:Grid implicitly defines an unrectified grid, which is a network
//       composed of two or more sets of curves in which the members of each set
//       intersect the members of the other sets in an algorithmic way.
//       The region of interest within the grid is given in terms of its gml:limits,
//       being the grid coordinates of  diagonally opposed corners of a rectangular region.
//       gml:axisLabels is provided with a list of labels of the axes of the grid
//       (gml:axisName has been deprecated). gml:dimension specifies the dimension of the grid.  
//       The gml:limits element contains a single gml:GridEnvelope.
//       The gml:low and gml:high property elements of the envelope are each integerLists,
//       which are coordinate tuples, the coordinates being measured as offsets from the origin
//       of the grid along each axis, of the diagonally opposing corners of a “rectangular” region of interest.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="GridType">
//   <complexContent>
//     <extension base="gml:AbstractGeometryType">
//       <sequence>
//         <element name="limits" type="gml:GridLimitsType"/>
//         <choice>
//           <element name="axisLabels" type="gml:NCNameList"/>
//           <element name="axisName" type="string" maxOccurs="unbounded"/>
//         </choice>
//       </sequence>
//       <attribute name="dimension" type="positiveInteger" use="required"/>
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

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(RectifiedGridType))]
  [Serializable]
  //[XmlType("GridType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("GridType")]
  public class GridType : AbstractGeometryType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GridType"/>.
    /// </summary>
    public GridType() {
      _limits = new GridLimitsType();
    }

    #endregion

    #region Public Properties

    private GridLimitsType _limits;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("limits", Order = 0)]
    [JsonProperty("limits", Order = 0)]
    public GridLimitsType Limits {
      get {
        return _limits;
      }
      set {
        if (_limits == value) {
          return;
        }
        if (_limits == null || _limits.Equals(value) != true) {
          _limits = value;
          OnPropertyChanged();
        }
      }
    }

    private string[] _axisItems;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("axisLabels", DataType = "NCName", Order = 1)]
    [XmlElement("axisName", Order = 1)]
    [XmlChoiceIdentifier("AxisItemsElementName")]
    public string[] AxisItems {
      get {
        return _axisItems;
      }
      set {
        if (_axisItems == value) {
          return;
        }
        if (_axisItems == null || _axisItems.Equals(value) != true) {
          _axisItems = value;
          OnPropertyChanged();
        }
      }
    }

    private AxisEnumeration[] _axisItemsElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AxisItemsElementName", Order = 2)]
    [XmlIgnore]
    public AxisEnumeration[] AxisItemsElementName {
      get {
        return _axisItemsElementName;
      }
      set {
        if (_axisItemsElementName == value) {
          return;
        }
        if (_axisItemsElementName == null || _axisItemsElementName.Equals(value) != true) {
          _axisItemsElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _dimension;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("dimension", DataType = "positiveInteger")]
    [JsonProperty("dimension")]
    public string Dimension {
      get {
        return _dimension;
      }
      set {
        if (_dimension == value) {
          return;
        }
        if (_dimension == null || _dimension.Equals(value) != true) {
          _dimension = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
