﻿
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
// <xs:complexType name="ML_TemporalCRS_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:TemporalCRSType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression" type="gmx:CrsAlt_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_TemporalCRS" type="gmx:ML_TemporalCRS_Type" substitutionGroup="gml:TemporalCRS"/>
// <xs:complexType name="ML_TemporalCRS_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_TemporalCRS"/>
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
  //[XmlType("ML_TemporalCRS", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_TemporalCRS", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  public class ML_TemporalCRS_Type : TemporalCRSType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_TemporalCRS_Type"/>.
    /// </summary>
    public ML_TemporalCRS_Type() {
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
