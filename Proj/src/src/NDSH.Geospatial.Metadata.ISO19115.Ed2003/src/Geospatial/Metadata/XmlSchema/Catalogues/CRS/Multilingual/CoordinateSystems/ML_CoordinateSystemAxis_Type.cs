
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/crsItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="ML_CoordinateSystemAxis_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:CoordinateSystemAxisType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:CoordinateSystemAxisAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_CoordinateSystemAxis" type="gmx:ML_CoordinateSystemAxis_Type" substitutionGroup="gml:CoordinateSystemAxis"/>
// <xs:complexType name="ML_CoordinateSystemAxis_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_CoordinateSystemAxis"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.Systems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems {

  [Serializable]
  //[XmlType("ML_CoordinateSystemAxis", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_CoordinateSystemAxis", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_CoordinateSystemAxis")]
  public class ML_CoordinateSystemAxis_Type : CoordinateSystemAxisType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_CoordinateSystemAxis_Type"/>.
    /// </summary>
    public ML_CoordinateSystemAxis_Type() {
      _alternativeExpression = default; //  new List<CoordinateSystemAxisAlt_Type>();
    }

    #endregion

    #region Public Properties

    private List<CoordinateSystemAxisAlt_Type> _alternativeExpression;

    //[XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<CoordinateSystemAxisAlt_Type> AlternativeExpression {
      get => _alternativeExpression;
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
