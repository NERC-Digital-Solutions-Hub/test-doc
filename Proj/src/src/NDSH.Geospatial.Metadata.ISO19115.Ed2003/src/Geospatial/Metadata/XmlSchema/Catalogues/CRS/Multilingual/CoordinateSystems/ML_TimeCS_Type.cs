
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
// <xs:complexType name="ML_TimeCS_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:TimeCSType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:CoordinateSystemAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_TimeCS" type="gmx:ML_TimeCS_Type" substitutionGroup="gml:TimeCS"/>
// <xs:complexType name="ML_TimeCS_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_TimeCS"/>
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
  //[XmlType("ML_TimeCS", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_TimeCS", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_TimeCS")]
  public class ML_TimeCS_Type : TimeCSType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_TimeCS_Type"/>.
    /// </summary>
    public ML_TimeCS_Type() {
      _alternativeExpression = default; //  new List<CoordinateSystemAlt_Type>();
    }

    #endregion

    #region Public Properties

    private List<CoordinateSystemAlt_Type> _alternativeExpression;

    //[XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<CoordinateSystemAlt_Type> AlternativeExpression {
      get => _alternativeExpression;
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
