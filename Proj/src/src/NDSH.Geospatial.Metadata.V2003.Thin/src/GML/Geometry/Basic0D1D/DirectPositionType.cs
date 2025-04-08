
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/02/2023, 05:33, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gml/geometryBasic0d1d.xsd
//                     /2005/gml/basicTypes.xsd
// --------------------------------------------------------------------------------
// <complexType name="DirectPositionType">
//   <simpleContent>
//     <extension base="gml:doubleList">
//       <attributeGroup ref="gml:SRSReferenceGroup"/>
//     </extension>
//   </simpleContent>
// </complexType>
//
// <element name="pos" type="gml:DirectPositionType">
//   <annotation>
//     <appinfo>
//       <sch:pattern name="CRS attributes constraints">
//         <sch:rule id="CRSLabelsPos">
//           <sch:report test="not(@srsDimension) or @srsName">The presence of a dimension attribute implies the presence of the srsName attribute.</sch:report>
//           <sch:report test="not(@axisLabels) or @srsName">The presence of an axisLabels attribute implies the presence of the srsName attribute.</sch:report>
//           <sch:report test="not(@uomLabels) or @srsName">The presence of an uomLabels attribute implies the presence of the srsName attribute.</sch:report>
//           <sch:report test="(not(@uomLabels) and not(@axisLabels)) or (@uomLabels and @axisLabels)">The presence of an uomLabels attribute implies the presence of the axisLabels attribute and vice versa.</sch:report>
//         </sch:rule>
//       </sch:pattern>
//     </appinfo>
//   </annotation>
// </element>
//
// <simpleType name="doubleList">
//   <list itemType="double"/>
// </simpleType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.GML.Geometry.Basic0D1D {

  /// <summary>
  /// Direct position instances hold the coordinates for a position within
  /// some coordinate reference system (CRS). Since direct positions,
  /// as data types, will often be included in larger objects
  /// (such as geometry elements) that have references to CRS,
  /// the srsName attribute will in general be missing, if this particular
  /// direct position is included in a larger element with such a reference to a CRS.
  /// In this case, the CRS is implicitly assumed to take on the value of the
  /// containing object's CRS. If no srsName attribute is given,
  /// the CRS shall be specified as part of the larger context this geometry
  /// element is part of, typically a geometric object like a point, curve, etc.
  /// </summary>
  [XmlInclude(typeof(VectorType))]
  [Serializable]
  [XmlType("DirectPositionType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DirectPositionType")]
  public class DirectPositionType : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DirectPositionType"/>.
    /// </summary>
    public DirectPositionType() {
      _text = new List<double>();
    }

    #endregion

    #region Public Properties

    private string _srsName;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("srsName", DataType = "anyURI")]
    [JsonProperty("srsName")]
    public string SrsName {
      get {
        return _srsName;
      }
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

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("srsDimension", DataType = "positiveInteger")]
    [JsonProperty("srsDimension")]
    public string SrsDimension {
      get {
        return _srsDimension;
      }
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

    private List<double> _text;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute] // TODO: DANGER !!! It seems that the previous one I made is incorrect!!!
    public List<double> Text {
      get {
        return _text;
      }
      set {
        if (_text == value) {
          return;
        }
        if (_text == null || _text.Equals(value) != true) {
          _text = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
