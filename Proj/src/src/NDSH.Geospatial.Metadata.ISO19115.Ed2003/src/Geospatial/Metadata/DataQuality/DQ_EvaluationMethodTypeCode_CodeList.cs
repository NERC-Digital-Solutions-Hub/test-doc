
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 23/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/dataQuality.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="DQ_EvaluationMethodTypeCode"
//             type="gco:CodeListValue_Type"
//             substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="DQ_EvaluationMethodTypeCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:DQ_EvaluationMethodTypeCode"/>
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

namespace NDSH.Geospatial.Metadata.DataQuality {

  [Serializable]
  //[XmlType("DQ_EvaluationMethodTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_EvaluationMethodTypeCode_PropertyType")]
  public class DQ_EvaluationMethodTypeCode_CodeList : CodeListValue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_EvaluationMethodTypeCode_CodeList"/>.
    /// </summary>
    public DQ_EvaluationMethodTypeCode_CodeList() {
      //_dq_EvaluationMethodTypeCode = default; //  new CodeListValue_Type(); // WARNING: Set to the first member of the codelist.
    }

    #endregion

  }

}
