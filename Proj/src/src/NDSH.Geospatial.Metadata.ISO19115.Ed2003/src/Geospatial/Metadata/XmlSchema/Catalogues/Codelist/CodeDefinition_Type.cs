
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
// XSD               : /2005/gmx/codelistItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="CodeDefinition_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:DefinitionType"/>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CodeDefinition" type="gmx:CodeDefinition_Type" substitutionGroup="gml:Definition"/>
// <xs:complexType name="CodeDefinition_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:CodeDefinition"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Dictionary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.Codelist {

  //[XmlInclude(typeof(ML_CodeDefinition_Type))]
  [Serializable]
  //[XmlType("CodeDefinition", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("CodeDefinition", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CodeDefinition")]
  public class CodeDefinition_Type : DefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CodeDefinition_Type"/>.
    /// </summary>
    public CodeDefinition_Type() {

    }

    #endregion

  }

}
