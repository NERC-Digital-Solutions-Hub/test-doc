
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 07/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/uomItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="UomAlternativeExpression_Type">
//   <xs:annotation>
//     <xs:documentation>
//       XML attributes constraints:
//         - 1) Id is mandatory
//         - 2) codeSpace (type xsd:anyURI) is mandatory
//     </xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gml:UnitDefinitionType">
//       <xs:sequence>
//         <xs:element name="locale" type="gmd:PT_Locale_PropertyType"/>
//       </xs:sequence>
//       <xs:attribute name="codeSpace" type="xs:anyURI" use="required"/>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="UomAlternativeExpression" type="gmx:UomAlternativeExpression_Type"/>
// <xs:complexType name="UomAlternativeExpression_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:UomAlternativeExpression"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Units;
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

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  /// <remarks>
  /// XML attributes contraints: - 1) Id is mandatory - 2) codeSpace (type xsd:anyURI) is mandatory
  /// </remarks>
  [Serializable]
  [XmlType("UomAlternativeExpression", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("UomAlternativeExpression", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("UomAlternativeExpression")]
  public class UomAlternativeExpression_Type : UnitDefinitionType, IAlternative {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UomAlternativeExpression_Type"/>.
    /// </summary>
    public UomAlternativeExpression_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _locale = default; //  new PT_Locale_Type();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private PT_Locale_Type _locale;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("locale", Order = 0)]
    [JsonProperty("locale", Order = 0)]
    public PT_Locale_Type Locale {
      get {
        return _locale;
      }
      set => SetProperty(ref _locale, value);
    }

    private string _codeSpace;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    [Required] // TODO: codeSpace (type xsd:anyURI) is mandatory
    public string CodeSpace {
      get {
        return _codeSpace;
      }
      set => SetProperty(ref _codeSpace, value);
    }

    #endregion

  }

}
