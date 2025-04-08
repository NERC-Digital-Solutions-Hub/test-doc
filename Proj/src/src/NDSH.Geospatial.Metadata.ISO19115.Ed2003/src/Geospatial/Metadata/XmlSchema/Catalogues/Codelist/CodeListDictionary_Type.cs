
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
// <xs:complexType name="CodeListDictionary_Type">
//   <xs:annotation>
//     <xs:documentation>
//       Constraints:
//         - 1) metadataProperty.card = 0
//         - 2) dictionaryEntry.card = 0
//     </xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gml:DictionaryType">
//       <xs:sequence>
//         <xs:element name="codeEntry" type="gmx:CodeDefinition_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="CodeListDictionary" type="gmx:CodeListDictionary_Type" substitutionGroup="gml:Dictionary"/>
// <xs:complexType name="CodeListDictionary_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:CodeListDictionary"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Dictionary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.Codelist {

  // WARNING: REVISIT

  // WARNING: Add the summary here!!!
  /// <summary>
  /// 
  /// </summary>
  /// <remarks>
  /// XML attributes constraints:
  /// <list type="number">
  ///   <item>metadataProperty.card = 0</item>
  ///   <item>dictionaryEntry.card = 0</item>
  /// </list>
  /// </remarks>
  // WARNING: What are these constraints applied here???
  //[XmlInclude(typeof(ML_CodeListDictionary_Type))]
  [Serializable]
  //[XmlType("CodeListDictionary", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("CodeListDictionary", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CodeListDictionary")]
  public class CodeListDictionary_Type : DictionaryType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CodeListDictionary_Type"/>.
    /// </summary>
    public CodeListDictionary_Type() {
      _codeEntry = default; //  new List<CodeDefinition_Type>();
    }

    #endregion

    #region Public Properties

    // WARNING: Apply the constraints described in the XSD definition and the remarks of the class !!!

    private ObservableCollection<CodeDefinition_Type> _codeEntry;

    //[XmlElement("codeEntry", Order = 0)]
    [JsonProperty("codeEntry", Order = 0)]
    public ObservableCollection<CodeDefinition_Type> CodeEntry {
      get => _codeEntry;
      set => SetProperty(ref _codeEntry, value);
    }

    #endregion

  }

}
