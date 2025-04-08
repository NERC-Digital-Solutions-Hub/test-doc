
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gmx/crsItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="OperationParameterAlt_Type">
//   <xs:annotation>
//     <xs:documentation>XML attributes constraints: - 1) Id is mandatory - 2) codeSpace (type xsd:anyURI) is mandatory</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gml:OperationParameterType">
//       <xs:sequence>
//         <xs:element name="locale" type="gmd:PT_Locale_PropertyType"/>
//       </xs:sequence>
//       <xs:attribute name="codeSpace" type="xs:anyURI" use="required"/>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="OperationParameterAlt" type="gmx:OperationParameterAlt_Type"/>
// <xs:complexType name="OperationParameterAlt_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:OperationParameterAlt"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml;
using NDSH.Geospatial.Gml.Coordinate.Operations;
using NDSH.Geospatial.Metadata.Localisation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.CRS.Multilingual {

  // TODO: REFACTOR

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
  //[XmlType("OperationParameterAlt", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("OperationParameterAlt", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("OperationParameterAlt")]
  public class OperationParameterAlt_Type : OperationParameterType, IAlternative {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="OperationParameterAlt_Type"/>.
    /// </summary>
    public OperationParameterAlt_Type() {
      _locale = default; //  new PT_Locale_Type();
    }

    #endregion

    #region IAlternative Interface

    private PT_Locale_Type _locale;

    //[XmlElement("locale", Order = 0)]
    [JsonProperty("locale", Order = 0)]
    public PT_Locale_Type Locale { // TODO: Compare with CodeListValue_Type - Extract Interface???
      get => _locale;
      set => SetProperty(ref _locale, value);
    }

    private string? _codeSpace;

    //[XmlAttribute("codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    [Required()] // TODO: codeSpace (type xsd:anyURI) is mandatory - Should this be in the interface?
    public string? CodeSpace { // TODO: Compare with CodeListValue_Type - Extract Interface???
      get => _codeSpace;
      set => SetProperty(ref _codeSpace, value);
    }

    #endregion

  }

}
