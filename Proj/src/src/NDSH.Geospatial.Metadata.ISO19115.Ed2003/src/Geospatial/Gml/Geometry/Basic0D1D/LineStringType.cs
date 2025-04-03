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
// <complexType name="LineStringType">
//   <complexContent>
//     <extension base="gml:AbstractCurveType">
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
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="LineString" type="gml:LineStringType" substitutionGroup="gml:AbstractCurve">
//   <annotation>
//     <documentation>
//       A LineString is a special curve that consists of a single segment with linear interpolation. It is defined 
//       by two or more coordinate tuples, with linear interpolation between them. The number of direct positions in the list 
//       shall be at least two.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Geometry.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LineStringType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("LineStringType")]
  public class LineStringType : AbstractCurveType {

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
    // TODO: Danger !!! What about a [JsonPropertyAttribute here??? Why is this missing?
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

    #endregion

  }

}
