
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/02/2023, 20:45, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryPrimitives.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="ArcStringByBulgeType">
//   <complexContent>
//     <extension base="gml:AbstractCurveSegmentType">
//       <sequence>
//         <choice>
//           <choice minOccurs="2" maxOccurs="unbounded">
//             <element ref="gml:pos"/>
//             <element ref="gml:pointProperty"/>
//             <element ref="gml:pointRep"/>
//           </choice>
//           <element ref="gml:posList"/>
//           <element ref="gml:coordinates"/>
//         </choice>
//         <element name="bulge" type="double" maxOccurs="unbounded"/>
//         <element name="normal" type="gml:VectorType" maxOccurs="unbounded"/>
//       </sequence>
//       <attribute name="interpolation" type="gml:CurveInterpolationType" fixed="circularArc2PointWithBulge"/>
//       <attribute name="numArc" type="integer"/>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="ArcStringByBulge" type="gml:ArcStringByBulgeType" substitutionGroup="gml:AbstractCurveSegment">
//   <annotation>
//     <documentation>
//       This variant of the arc computes the mid points of the arcs instead of storing the coordinates directly.
//       The control point sequence consists of the start and end points of each arc plus the bulge (see ISO 19107:2003, 6.4.17.2).
//       The normal is a vector normal (perpendicular) to the chord of the arc (see ISO 19107:2003, 6.4.17.4).
//       The interpolation is fixed as "circularArc2PointWithBulge".
//       The number of arcs in the arc string may be explicitly stated in the attribute numArc.
//       The number of control points in the arc string shall be numArc + 1.
//       The content model follows the general pattern for the encoding of curve segments.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
using NDSH.Geospatial.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Primitives {

  /// <summary>
  /// 
  /// </summary>
  //[XmlInclude(typeof(ArcByBulgeType))]
  [Serializable]
  //[XmlType("ArcStringByBulgeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ArcStringByBulgeType")]
  public class ArcStringByBulgeType : AbstractCurveSegmentType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ArcStringByBulgeType"/>.
    /// </summary>
    public ArcStringByBulgeType() {
      _normal = new List<VectorType>();
      _bulge = new List<double>();
      _interpolation = CurveInterpolationType.circularArc2PointWithBulge;
    }

    #endregion

    #region Public Properties

    private object[] _positionTypeItems;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("coordinates", typeof(CoordinatesType), Order = 0)]
    [XmlElement("pointProperty", typeof(PointPropertyType), Order = 0)]
    [XmlElement("pointRep", typeof(PointPropertyType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("posList", typeof(DirectPositionListType), Order = 0)]
    [XmlChoiceIdentifier("PositionTypeItemsElementName")]
    public object[] PositionTypeItems {
      get {
        return _positionTypeItems;
      }
      set {
        if (_positionTypeItems == value) {
          return;
        }
        if (_positionTypeItems == null || _positionTypeItems.Equals(value) != true) {
          _positionTypeItems = value;
          OnPropertyChanged();
        }
      }
    }

    private PositionType[] _positionTypeItemsElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PositionTypeItemsElementName", Order = 1)]
    [XmlIgnore]
    public PositionType[] PositionTypeItemsElementName {
      get {
        return _positionTypeItemsElementName;
      }
      set {
        if (_positionTypeItemsElementName == value) {
          return;
        }
        if (_positionTypeItemsElementName == null || _positionTypeItemsElementName.Equals(value) != true) {
          _positionTypeItemsElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private List<double> _bulge;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("bulge", Order = 2)]
    [JsonProperty("bulge", Order = 2)]
    public List<double> Bulge {
      get {
        return _bulge;
      }
      set {
        if (_bulge == value) {
          return;
        }
        if (_bulge == null || _bulge.Equals(value) != true) {
          _bulge = value;
          OnPropertyChanged();
        }
      }
    }

    private List<VectorType> _normal;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("normal", Order = 3)]
    [JsonProperty("normal", Order = 3)]
    public List<VectorType> Normal {
      get {
        return _normal;
      }
      set {
        if (_normal == value) {
          return;
        }
        if (_normal == null || _normal.Equals(value) != true) {
          _normal = value;
          OnPropertyChanged();
        }
      }
    }

    private CurveInterpolationType _interpolation;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("interpolation")]
    [JsonProperty("interpolation")]
    public CurveInterpolationType Interpolation {
      get {
        return _interpolation;
      }
      set {
        if (_interpolation.Equals(value) != true) {
          _interpolation = value;
          OnPropertyChanged();
        }
      }
    }

    private string _numArc;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("numArc", DataType = "integer")]
    [JsonProperty("numArc")]
    public string NumArc {
      get {
        return _numArc;
      }
      set {
        if (_numArc == value) {
          return;
        }
        if (_numArc == null || _numArc.Equals(value) != true) {
          _numArc = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
