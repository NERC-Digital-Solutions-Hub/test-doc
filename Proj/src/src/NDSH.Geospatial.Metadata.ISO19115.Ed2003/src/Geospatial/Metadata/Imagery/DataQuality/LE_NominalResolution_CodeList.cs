
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
// XSD               : /2005/gmi/dataQualityInformation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="LE_NominalResolution" type="gmi:LE_NominalResolution_Type"/>
// <xs:complexType name="LE_NominalResolution_PropertyType">
//   <xs:sequence>
//     <xs:element ref="gmi:LE_NominalResolution" minOccurs="0"/>
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

namespace NDSH.Geospatial.Metadata.Imagery.DataQuality {

  [Serializable]
  //[XmlType("LE_NominalResolution_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("LE_NominalResolution_PropertyType")]
  public class LE_NominalResolution_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_NominalResolution_CodeList"/>.
    /// </summary>
    public LE_NominalResolution_CodeList() {
      //_le_NominalResolution = default; //  new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
