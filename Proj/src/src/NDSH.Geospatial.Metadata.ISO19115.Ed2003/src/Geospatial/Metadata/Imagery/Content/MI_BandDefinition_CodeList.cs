
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 26/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmi/contentInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="MI_BandDefinition" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MI_BandDefinition_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:MI_BandDefinition" minOccurs="0"/>
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

namespace NDSH.Geospatial.Metadata.Imagery.Content {

  [Serializable]
  //[XmlType("MI_BandDefinition_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_BandDefinition_PropertyType")]
  public class MI_BandDefinition_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_BandDefinition_CodeList"/>.
    /// </summary>
    public MI_BandDefinition_CodeList() {
      //_mi_BandDefinition = default; //  new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
