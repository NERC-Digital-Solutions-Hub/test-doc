
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
// XSD               : /2005/gmx/catalogues.xsd
//                     /2005/gmx/codelistItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="CT_CodelistCatalogue_Type">
//   <xs:complexContent>
//     <xs:extension base="gmx:AbstractCT_Catalogue_Type">
//       <xs:sequence>
//         <xs:element name="codelistItem" type="gmx:CT_Codelist_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CT_CodelistCatalogue"
//             type="gmx:CT_CodelistCatalogue_Type" substitutionGroup="gmx:AbstractCT_Catalogue"/>
// <xs:complexType name="CT_CodelistCatalogue_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:CT_CodelistCatalogue"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// 
// <xs:complexType name="CodeListDictionary_Type">
//   <xs:annotation>
//     <xs:documentation>Constraints: - 1) metadataProperty.card = 0 - 2) dictionaryEntry.card = 0</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gml:DictionaryType">
//       <xs:sequence>
//         <xs:element name="codeEntry" type="gmx:CodeDefinition_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// xs:complexType>
// <xs:complexType name="CT_Codelist_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:CodeListDictionary"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.XmlSchema.Catalogues.Codelist;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues {

  // WARNING: REVISIT

  [Serializable]
  //[XmlType("CT_CodelistCatalogue", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("CT_CodelistCatalogue", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CT_CodelistCatalogue")]
  public class CT_CodelistCatalogue_Type : AbstractCT_Catalogue_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_CodelistCatalogue_Type"/>.
    /// </summary>
    public CT_CodelistCatalogue_Type() {
      _codelistItem = default; //  new List<CT_Codelist_PropertyType>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CodeListDictionary_Type>? _codelistItem;

    /// <summary>
    /// Provides the list of codelist items described in the catalogue.
    /// </summary>
    // TODO: OBL - M
    // TODO: CAR - N
    //[XmlElement("codelistItem", Order = 0)]
    [JsonProperty("codelistItem", Order = 0)]
    public ObservableCollection<CodeListDictionary_Type>? CodelistItem {
      get => _codelistItem;
      set => SetProperty(ref _codelistItem, value);
    }

    #endregion

  }

}
