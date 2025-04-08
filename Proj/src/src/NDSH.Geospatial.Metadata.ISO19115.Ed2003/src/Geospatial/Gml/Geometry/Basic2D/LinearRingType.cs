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
// XSD               : /2005/gml/geometryBasic2d.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <complexType name="LinearRingType">
//   <complexContent>
//     <extension base="gml:AbstractRingType">
//       <sequence>
//         <choice>
//           <choice minOccurs="4" maxOccurs="unbounded">
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
// <element name="LinearRing" type="gml:LinearRingType" substitutionGroup="gml:AbstractRing">
//   <annotation>
//     <documentation>
//       A LinearRing is defined by four or more coordinate tuples, with linear interpolation
//       between them; the first and last coordinates shall be coincident. The number of direct
//       positions in the list shall be at least four.
//     </documentation>
//   </annotation>
// </element>
// <complexType name="LinearRingPropertyType">
//   <annotation>
//     <documentation>
//       A property with the content model of gml:LinearRingPropertyType encapsulates a linear
//       ring to represent a component of a surface boundary.
//     </documentation>
//   </annotation>
//   <sequence>
//     <element ref="gml:LinearRing"/>
//   </sequence>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion


#region Imported Namespaces


using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Geometry.Basic0D1D;
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

namespace NDSH.Geospatial.Gml.Geometry.Basic2D {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LinearRingType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("LinearRingType")]
  public class LinearRingType : AbstractRingType {

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

    #endregion

  }

}
