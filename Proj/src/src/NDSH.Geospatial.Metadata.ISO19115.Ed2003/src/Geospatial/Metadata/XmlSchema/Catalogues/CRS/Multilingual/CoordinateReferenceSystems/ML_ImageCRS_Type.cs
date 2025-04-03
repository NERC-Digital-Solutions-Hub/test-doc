
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 04/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/crsItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="ML_ImageCRS_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:ImageCRSType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:CrsAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_ImageCRS" type="gmx:ML_ImageCRS_Type" substitutionGroup="gml:ImageCRS"/>
// <xs:complexType name="ML_ImageCRS_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_ImageCRS"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Coordinate.ReferenceSystems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems {

  [Serializable]
  //[XmlType("ML_ImageCRS", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_ImageCRS", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_ImageCRS")]
  public class ML_ImageCRS_Type : ImageCRSType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_ImageCRS_Type"/>.
    /// </summary>
    public ML_ImageCRS_Type() {
      _alternativeExpression = default; //  new List<CrsAlt_Type>();
    }

    #endregion

    #region Public Properties

    private List<CrsAlt_Type> _alternativeExpression;

    //[XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<CrsAlt_Type> AlternativeExpression {
      get => _alternativeExpression;
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
