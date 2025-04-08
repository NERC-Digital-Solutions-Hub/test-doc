
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/citation.xsd
// --------------------------------------------------------------------------------
// <xs:element name="CI_DateTypeCode" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="CI_DateTypeCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_DateTypeCode"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CI_DateTypeCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_DateTypeCode_PropertyType")]
  public class CI_DateTypeCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_DateTypeCode_PropertyType"/>.
    /// </summary>
    public CI_DateTypeCode_PropertyType() {
      _ci_DateTypeCode = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _ci_DateTypeCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_DateTypeCode", Order = 0)]
    [JsonProperty("CI_DateTypeCode", Order = 0)]
    public CodeListValue_Type CI_DateTypeCode {
      get => _ci_DateTypeCode;
      set {
        if (_ci_DateTypeCode == value) {
          return;
        }
        if (_ci_DateTypeCode == null || !_ci_DateTypeCode.Equals(value)) {
          _ci_DateTypeCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
