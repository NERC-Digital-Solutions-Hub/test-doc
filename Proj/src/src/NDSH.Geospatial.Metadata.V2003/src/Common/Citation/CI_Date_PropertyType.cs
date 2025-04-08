
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------// --------------------------------------------------------------------------------
// XSD               : /2005/gmd/citation.xsd
// --------------------------------------------------------------------------------
// <xs:element name="CI_Date" type="gmd:CI_Date_Type"/>
//
// <xs:complexType name="CI_Date_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:CI_Date"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
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
  [XmlType("CI_Date_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_Date_PropertyType")]
  public class CI_Date_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Date_PropertyType"/>.
    /// </summary>
    public CI_Date_PropertyType() {
      _ci_Date = default; //  new CI_Date_Type();
    }

    #endregion

    #region Public Properties

    private CI_Date_Type _ci_Date;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CI_Date", Order = 0)]
    [JsonProperty("CI_Date", Order = 0)]
    public CI_Date_Type CI_Date {
      get => _ci_Date;
      set {
        if (_ci_Date == value) {
          return;
        }
        if (_ci_Date == null || !_ci_Date.Equals(value)) {
          _ci_Date = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
