
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 24/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="MD_DimensionNameTypeCode" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MD_DimensionNameTypeCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_DimensionNameTypeCode"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.SpatialRepresentation {

  [Serializable]
  //[XmlType("MD_DimensionNameTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_DimensionNameTypeCode_PropertyType")]
  public class MD_DimensionNameTypeCode_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DimensionNameTypeCode_CodeList"/>.
    /// </summary>
    public MD_DimensionNameTypeCode_CodeList() {
      //_md_DimensionNameTypeCode = default; //  new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
