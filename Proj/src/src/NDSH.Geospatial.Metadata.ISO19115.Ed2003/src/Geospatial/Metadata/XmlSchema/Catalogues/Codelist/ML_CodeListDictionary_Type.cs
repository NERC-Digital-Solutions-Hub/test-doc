
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
// <xs:complexType name="ML_CodeListDictionary_Type">
//   <xs:annotation>
//     <xs:documentation>Constraint: codeEntry.type = ML_CodeListDefinition</xs:documentation>
//   </xs:annotation>
//   <xs:complexContent>
//     <xs:extension base="gmx:CodeListDictionary_Type">
//       <xs:sequence>
//         <xs:element name="alternativeExpression"
//                     type="gmx:ClAlternativeExpression_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_CodeListDictionary"
//             type="gmx:ML_CodeListDictionary_Type"
//             substitutionGroup="gmx:CodeListDictionary"/>
// <xs:complexType name="ML_CodeListDictionary_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_CodeListDictionary"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

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

  // TODO: Add the summary here!!!
  /// <summary>
  /// 
  /// </summary>
  /// <remarks>
  /// The <see langword="typeof"/> <see cref="CodeListDictionary_Type.CodeEntry">CodeEntry</see>
  /// must be: <see cref="ML_CodeDefinition_Type"/>.
  /// </remarks>
  [Serializable]
  //[XmlType("ML_CodeListDictionary", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_CodeListDictionary", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_CodeListDictionary")]
  public class ML_CodeListDictionary_Type : CodeListDictionary_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_CodeListDictionary_Type"/>.
    /// </summary>
    public ML_CodeListDictionary_Type() {
      _alternativeExpression = default; //  new List<ClAlternativeExpression_Type>();
    }

    #endregion

    #region Public Properties

    // WARNING: Apply the constraints described in the XSD definition and the remarks of the class !!!

    // WARNING: It seems that CodeListDictionary_Type.CodeEntry must be overridden here!!!

    private ObservableCollection<ClAlternativeExpression_Type> _alternativeExpression;

    //[XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public ObservableCollection<ClAlternativeExpression_Type> AlternativeExpression {
      get => _alternativeExpression;
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
