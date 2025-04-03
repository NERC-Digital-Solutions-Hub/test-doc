
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
// <xs:complexType name="FileName_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attribute name="src" type="xs:anyURI"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// <xs:element name="FileName" type="gmx:FileName_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="FileName_PropertyType">
//   <xs:sequence minOccurs="0">
// 	   <xs:element ref="gmx:FileName"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Apps;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
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
  //[XmlType("FileName", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("FileName", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("FileName")]
  public class FileName_Type : CharacterString {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="FileName_Type"/>.
    /// </summary>
    public FileName_Type() {

    }

    #endregion

    #region Public Properties

    private string _src;

    //[XmlAttribute("src", DataType = "anyURI")]
    [JsonProperty("src")]
    public string Src {
      get => _src;
      set => SetProperty(ref _src, value);
    }

    private string _value;

    //[XmlText()]
    public string Value {
      get => _value;
      set => SetProperty(ref _value, value);
    }

    #endregion

  }

}
