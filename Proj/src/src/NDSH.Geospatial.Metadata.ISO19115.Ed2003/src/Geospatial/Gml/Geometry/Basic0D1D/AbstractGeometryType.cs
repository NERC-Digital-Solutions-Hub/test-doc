
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 31/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryAggregates.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="AbstractGeometryType" abstract="true">
//   <annotation>
//     <documentation>
//       All geometry elements are derived directly or indirectly from this abstract supertype. A geometry element may have an identifying attribute 
//       (gml:id), one or more names (elements identifier and name) and a description (elements description and descriptionReference) . 
//       It may be associated with a spatial reference system (attribute group gml:SRSReferenceGroup).
//       The following rules shall be adhered to:
//       -	Every geometry type shall derive from this abstract type.
//       -	Every geometry element (i.e. an element of a geometry type) shall be directly or indirectly in the substitution group of AbstractGeometry.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:AbstractGMLType">
//       <attributeGroup ref="gml:SRSReferenceGroup"/>
//     </extension>
//   </complexContent>
// </complexType>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {

  #region XmlIncludes
  //[XmlInclude(typeof(GridType))]
  //[XmlInclude(typeof(RectifiedGridType))]
  //[XmlInclude(typeof(GeometricComplexType))]
  //[XmlInclude(typeof(AbstractGeometricAggregateType))]
  //[XmlInclude(typeof(MultiSolidType))]
  //[XmlInclude(typeof(MultiSurfaceType))]
  //[XmlInclude(typeof(MultiCurveType))]
  //[XmlInclude(typeof(MultiPointType))]
  //[XmlInclude(typeof(MultiGeometryType))]
  //[XmlInclude(typeof(AbstractGeometricPrimitiveType))]
  //[XmlInclude(typeof(AbstractSolidType))]
  //[XmlInclude(typeof(CompositeSolidType))]
  //[XmlInclude(typeof(SolidType))]
  //[XmlInclude(typeof(AbstractSurfaceType))]
  //[XmlInclude(typeof(CompositeSurfaceType))]
  //[XmlInclude(typeof(OrientableSurfaceType))]
  //[XmlInclude(typeof(SurfaceType))]
  //[XmlInclude(typeof(TriangulatedSurfaceType))]
  //[XmlInclude(typeof(TinType))]
  //[XmlInclude(typeof(PolyhedralSurfaceType))]
  //[XmlInclude(typeof(PolygonType))]
  //[XmlInclude(typeof(AbstractCurveType))]
  //[XmlInclude(typeof(CompositeCurveType))]
  //[XmlInclude(typeof(OrientableCurveType))]
  //[XmlInclude(typeof(CurveType))]
  //[XmlInclude(typeof(LineStringType))]
  //[XmlInclude(typeof(PointType))]
  #endregion

  // WARNING: REVISIT

  /// <summary>
  /// <para>
  /// All geometry elements are derived directly or indirectly from this abstract supertype.
  /// A geometry element may have an identifying attribute (gml:id), one or more names
  /// (elements identifier and name) and a description (elements description and
  /// descriptionReference) . It may be associated with a spatial reference system
  /// (attribute group gml:SRSReferenceGroup).
  /// </para>
  /// <para>
  /// The following rules shall be adhered to: <br></br>
  /// <list type="bullet">
  /// <item>Every geometry type shall derive from this abstract type.</item>
  /// <item>
  /// Every geometry element (i.e. an element of a geometry type) shall be
  /// directly or indirectly in the substitution group of AbstractGeometry.
  /// </item>
  /// </list>
  /// </para>
  /// </summary>
  [Serializable]
  //[XmlType("AbstractGeometryType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("AbstractGeometryType")]
  public abstract class AbstractGeometryType : AbstractGMLType, ISrsReference {

    #region ISrsReference Interface

    // WARNING: ISrsReference needs implementation or removal !!!

    List<string> ISrsInformation.AxisLabel {
      get => throw new NotImplementedException();
      set => throw new NotImplementedException();
    }
    List<string> ISrsInformation.UomLabels {
      get => throw new NotImplementedException();
      set => throw new NotImplementedException();
    }


    private string _srsName;

    //[XmlAttribute("srsName", DataType = "anyURI")]
    [JsonProperty("srsName")]
    public string SrsName {
      get => _srsName;
      set {
        if (_srsName == value) {
          return;
        }
        if (_srsName == null || _srsName.Equals(value) != true) {
          _srsName = value;
          OnPropertyChanged();
        }
      }
    }

    private string _srsDimension;

    //[XmlAttribute("srsDimension", DataType = "positiveInteger")]
    [JsonProperty("srsDimension")]
    public string SrsDimension {
      get => _srsDimension;
      set {
        if (_srsDimension == value) {
          return;
        }
        if (_srsDimension == null || _srsDimension.Equals(value) != true) {
          _srsDimension = value;
          OnPropertyChanged();
        }
      }
    }

    // WARNING: How to implement NCName:
    // https://stackoverflow.com/questions/1631396/what-is-an-xsncname-type-and-when-should-it-be-used

    private ObservableCollection<string> _axisLabel;

    //[XmlAttribute("axisLabel")]
    [JsonProperty("axisLabel")]
    // TODO: IMPORTANT!!! - This is a List of NCName(s)
    // TODO: Check List Serialization here!
    public ObservableCollection<string> AxisLabel {
      get => _axisLabel;
      set {
        if (_axisLabel == value) {
          return;
        }
        if (_axisLabel == null || _axisLabel.Equals(value) != true) {
          _axisLabel = value;
          OnPropertyChanged();
        }
      }
    }

    private ObservableCollection<string> _uomLabels;

    //[XmlAttribute("uomLabels")]
    [JsonProperty("uomLabels")]
    // TODO: IMPORTANT!!! - This is a List of NCName(s)
    // TODO: Check List Serialization here!
    public ObservableCollection<string> UomLabels {
      get => _uomLabels;
      set {
        if (_uomLabels == value) {
          return;
        }
        if (_uomLabels == null || _uomLabels.Equals(value) != true) {
          _uomLabels = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
