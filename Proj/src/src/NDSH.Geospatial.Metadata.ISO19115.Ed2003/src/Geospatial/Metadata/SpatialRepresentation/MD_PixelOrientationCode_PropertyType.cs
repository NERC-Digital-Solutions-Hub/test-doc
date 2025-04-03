
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 04:02, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmd/spatialRepresentation.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:simpleType name="MD_PixelOrientationCode_Type">
//   <xs:restriction base="xs:string">
//     <xs:enumeration value="center"/>
//     <xs:enumeration value="lowerLeft"/>
//     <xs:enumeration value="lowerRight"/>
//     <xs:enumeration value="upperRight"/>
//     <xs:enumeration value="upperLeft"/>
//   </xs:restriction>
// </xs:simpleType>
// <xs:element name="MD_PixelOrientationCode"
//             type="gmd:MD_PixelOrientationCode_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MD_PixelOrientationCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:MD_PixelOrientationCode"/>
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

namespace NDSH.Geospatial.Metadata.SpatialRepresentation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_PixelOrientationCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_PixelOrientationCode_PropertyType")]
  public class MD_PixelOrientationCode_PropertyType : ObservableDbEntity { // WARNING: DANGER !!! - Why this inherits only from NilModel? IS this because it is an enum?

    // WARNING: MD_PixelOrientationCode_Type is an enum rather than code list.
    #region Public Properties

    private MD_PixelOrientationCode_Type _md_PixelOrientationCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_PixelOrientationCode", Order = 0)]
    [JsonProperty("MD_PixelOrientationCode", Order = 0)]
    public MD_PixelOrientationCode_Type MD_PixelOrientationCode {
      get {
        return _md_PixelOrientationCode;
      }
      // TODO: SetProperty
      set {
        if (_md_PixelOrientationCode.Equals(value) != true) {
          _md_PixelOrientationCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
