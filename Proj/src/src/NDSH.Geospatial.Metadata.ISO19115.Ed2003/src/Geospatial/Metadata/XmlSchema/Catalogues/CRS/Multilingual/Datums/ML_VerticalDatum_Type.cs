
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
// <xs:complexType name="ML_VerticalDatum_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:VerticalDatumType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:DatumAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_VerticalDatum" type="gmx:ML_VerticalDatum_Type" substitutionGroup="gml:VerticalDatum"/>
// <xs:complexType name="ML_VerticalDatum_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_VerticalDatum"/>
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
  //[XmlType("ML_VerticalDatum", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_VerticalDatum", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_VerticalDatum")]
  public class ML_VerticalDatum_Type : VerticalDatumType, IDatumsAlternativeExpression {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_VerticalDatum_Type"/>.
    /// </summary>
    public ML_VerticalDatum_Type() {
      _alternativeExpression = default; //  new List<DatumAlt_Type>();
    }

    #endregion

    #region IDatumsAlternativeExpression Interface

    private List<DatumAlt_Type> _alternativeExpression;

    //[XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<DatumAlt_Type> AlternativeExpression {
      get => _alternativeExpression;
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
