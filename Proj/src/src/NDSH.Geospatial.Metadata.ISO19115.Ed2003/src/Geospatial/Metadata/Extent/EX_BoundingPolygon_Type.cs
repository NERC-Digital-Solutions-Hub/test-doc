
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 22/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/extent.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="EX_BoundingPolygon_Type">
//   <xs:annotation>
//     <xs:documentation>
//       Boundary enclosing the dataset expressed as the closed set of (x,y)
//       coordinates of the polygon (last point replicates first point)
//     </xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmd:AbstractEX_GeographicExtent_Type">
//       <xs:sequence>
//         <xs:element name="polygon" type="gss:GM_Object_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="EX_BoundingPolygon"
//             type="gmd:EX_BoundingPolygon_Type"
//             substitutionGroup="gmd:AbstractEX_GeographicExtent"/>
// <xs:complexType name="EX_BoundingPolygon_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:EX_BoundingPolygon"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Schema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Extent {

  /// <summary>
  /// Boundary enclosing the dataset expressed as the closed set of (x,y)
  /// coordinates of the polygon (last point replicates first point).
  /// </summary>
  [Serializable]
  //[XmlType("EX_BoundingPolygon", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[XmlRoot("EX_BoundingPolygon", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("EX_BoundingPolygon")]
  public class EX_BoundingPolygon_Type : AbstractEX_GeographicExtent_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EX_BoundingPolygon_Type"/>.
    /// </summary>
    public EX_BoundingPolygon_Type() {
      _polygon = default; //  new List<GM_Object_PropertyType>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<GM_Object_PropertyType> _polygon; // TODO: LIST

    /// <summary>
    /// Sets of points defining the bounding polygon.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("polygon", Order = 0)]
    [JsonProperty("polygon", Order = 0)]
    public ObservableCollection<GM_Object_PropertyType> Polygon {
      get => _polygon;
      set => SetProperty(ref _polygon, value);
    }

    #endregion

  }

}
