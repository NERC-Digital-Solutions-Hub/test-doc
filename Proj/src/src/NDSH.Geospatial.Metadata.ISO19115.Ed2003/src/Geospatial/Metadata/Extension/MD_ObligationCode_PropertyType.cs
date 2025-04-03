
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 29/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/metadataExtension.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="MD_ObligationCode_Type">
//   <xs:restriction base="xs:string">
//     <xs:enumeration value="mandatory"/>
//     <xs:enumeration value="optional"/>
//     <xs:enumeration value="conditional"/>
//   </xs:restriction>
// </xs:simpleType>
// <xs:element name="MD_ObligationCode" type="gmd:MD_ObligationCode_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MD_ObligationCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_ObligationCode"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;

using Newtonsoft.Json;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Extension {

  [Serializable]
  //[XmlType("MD_ObligationCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ObligationCode_PropertyType")]
  public class MD_ObligationCode_PropertyType : ObservableDbEntity {

    #region Public Properties

    private MD_ObligationCode_Type _md_ObligationCode;

    //[XmlElement("MD_ObligationCode", Order = 0)]
    [JsonProperty("MD_ObligationCode", Order = 0)]
    public MD_ObligationCode_Type MD_ObligationCode {
      get => _md_ObligationCode;
      // TODO: SetProperty
      set {
        if (_md_ObligationCode.Equals(value) != true) {
          _md_ObligationCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
