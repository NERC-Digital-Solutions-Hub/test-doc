
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
// <xs:complexType name="ClAlternativeExpression_Type">
//   <xs:annotation>
//     <xs:documentation>
//       XML attributes constraints:
//         - 1) Id is mandatory
//         - 2) codeSpace (type xsd:anyURI) is mandatory
//     </xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gml:DefinitionType">
//       <xs:sequence>
//         <xs:element name="locale" type="gmd:PT_Locale_PropertyType"/>
//       </xs:sequence>
//       <xs:attribute name="codeSpace" type="xs:anyURI" use="required"/>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ClAlternativeExpression" type="gmx:ClAlternativeExpression_Type"/>
// <xs:complexType name="ClAlternativeExpression_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ClAlternativeExpression"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml;
using NDSH.Geospatial.Gml.Dictionary;
using NDSH.Geospatial.Metadata.Localisation;
using NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.Codelist {

  // TODO: Add documentation summary here!!!
  /// <summary>
  /// 
  /// </summary>
  /// <remarks>
  ///   XML attributes constraints:
  ///   <list type="number">
  ///     <item>The <see cref="AbstractGMLType.Id">Id</see> is mandatory.</item>
  ///     <item>The <see cref="CodeSpace"/> (type xsd:anyURI) is mandatory.</item>
  ///   </list>
  /// </remarks>
  [Serializable]
  //[XmlType("ClAlternativeExpression", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ClAlternativeExpression", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ClAlternativeExpression")]
  public class ClAlternativeExpression_Type : DefinitionType, IAlternative {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ClAlternativeExpression_Type"/>.
    /// </summary>
    public ClAlternativeExpression_Type() {
      _locale = default; //  new PT_Locale_Type();
    }

    #endregion

    #region IAlternative Interface

    // WARNING: Apply the constraints described in the XSD definition and the remarks of the class !!!

    // Most probably this needs an AbstractGMLType.Id override with the [Required] attribute applied on it.

    private PT_Locale_Type _locale;

    //[XmlElement("locale", Order = 0)]
    [JsonProperty("locale", Order = 0)]
    public PT_Locale_Type Locale {
      get => _locale;
      set => SetProperty(ref _locale, value);
    }

    private string? _codeSpace;

    //[XmlAttribute("codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    [Required()] // TODO: codeSpace (type xsd:anyURI) is mandatory
    public string? CodeSpace {
      get => _codeSpace;
      set => SetProperty(ref _codeSpace, value);
    }

    #endregion

  }

}
