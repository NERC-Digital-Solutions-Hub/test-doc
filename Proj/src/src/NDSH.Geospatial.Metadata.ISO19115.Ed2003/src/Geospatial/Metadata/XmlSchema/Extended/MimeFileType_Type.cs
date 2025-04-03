
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 08/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/extendedTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="MimeFileType_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attribute name="type" type="xs:string" use="required"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// <xs:element name="MimeFileType" type="gmx:MimeFileType_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="MimeFileType_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:MimeFileType"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Extended {

  [Serializable]
  //[XmlType("MimeFileType", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("MimeFileType", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("MimeFileType")]
  public class MimeFileType_Type : ObservableModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MimeFileType_Type"/>.
    /// </summary>
    public MimeFileType_Type() {

    }

    #endregion

    #region Public Properties

    private string _type;

    /// <summary>
    /// Provides the mime media type name and subtype name.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - 1
    //[XmlAttribute("type")]
    [JsonProperty("type")]
    public string Type {
      get => _type;
      set => SetProperty(ref _type, value);
    }

    private string _value;

    //[XmlText]
    public string Value {
      get => _value;
      set => SetProperty(ref _value, value);
    }

    #endregion

  }

}
