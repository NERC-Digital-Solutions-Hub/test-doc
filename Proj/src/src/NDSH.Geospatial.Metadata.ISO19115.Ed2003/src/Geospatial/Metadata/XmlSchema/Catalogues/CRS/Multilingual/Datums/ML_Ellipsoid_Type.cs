
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/crsItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="ML_Ellipsoid_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:EllipsoidType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:EllipsoidAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_Ellipsoid" type="gmx:ML_Ellipsoid_Type" substitutionGroup="gml:Ellipsoid"/>
// <xs:complexType name="ML_Ellipsoid_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_Ellipsoid"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.Datums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual.Datums {

  [Serializable]
  //[XmlType("ML_Ellipsoid", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_Ellipsoid", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_Ellipsoid")]
  public class ML_Ellipsoid_Type : EllipsoidType, IEllipsoidsAlternativeExpression {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_Ellipsoid_Type"/>.
    /// </summary>
    public ML_Ellipsoid_Type() {
      _alternativeExpression = default; //  new List<EllipsoidAlt_Type>();
    }

    #endregion

    #region IEllipsoidsAlternativeExpression Interface

    private List<EllipsoidAlt_Type> _alternativeExpression;

    //[XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<EllipsoidAlt_Type> AlternativeExpression {
      get => _alternativeExpression;
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
