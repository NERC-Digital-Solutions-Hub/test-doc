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
// <complexType name="PointType">
//   <complexContent>
//     <extension base="gml:AbstractGeometricPrimitiveType">
//       <sequence>
//         <choice>
//           <element ref="gml:pos"/>
//           <element ref="gml:coordinates"/>
//         </choice>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// <element name="Point" type="gml:PointType" substitutionGroup="gml:AbstractGeometricPrimitive">
//   <annotation>
//     <documentation>
//       A Point is defined by a single coordinate tuple. The direct position of a point is specified by the pos element 
//       which is of type DirectPositionType.
//     </documentation>
//   </annotation>
// </element>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

using NDSH.Geospatial.Gml.BasicTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Gml.Geometry.Basic0D1D {

  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("PointType")]
  public class PointType : AbstractGeometricPrimitiveType {
    #region Private fields
    private object _item;
    #endregion

    [XmlElement("coordinates", typeof(CoordinatesType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }
  }
}
