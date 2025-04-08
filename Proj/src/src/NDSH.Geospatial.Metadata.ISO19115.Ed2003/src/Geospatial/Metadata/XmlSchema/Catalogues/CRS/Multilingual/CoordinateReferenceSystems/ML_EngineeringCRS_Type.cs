
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
// <xs:complexType name="ML_EngineeringCRS_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:EngineeringCRSType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:CrsAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_EngineeringCRS" type="gmx:ML_EngineeringCRS_Type" substitutionGroup="gml:EngineeringCRS"/>
// <xs:complexType name="ML_EngineeringCRS_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_EngineeringCRS"/>
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
  //[XmlType("ML_EngineeringCRS", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_EngineeringCRS", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_EngineeringCRS")]
  public class ML_EngineeringCRS_Type : EngineeringCRSType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_EngineeringCRS_Type"/>.
    /// </summary>
    public ML_EngineeringCRS_Type() {
      _alternativeExpression = default; //  new List<CrsAlt_Type>();
    }

    #endregion

    #region Private Properties

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
