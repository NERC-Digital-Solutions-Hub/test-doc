
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
// <xs:complexType name="ML_CodeDefinition_Type">
//   <xs:complexContent>
//     <xs:extension base="gmx:CodeDefinition_Type">
//       <xs:sequence>
//         <xs:element name="alternativeExpression"
//                     type="gmx:CodeAlternativeExpression_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_CodeDefinition" type="gmx:ML_CodeDefinition_Type" substitutionGroup="gmx:CodeDefinition"/>
// <xs:complexType name="ML_CodeDefinition_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_CodeDefinition"/>
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

  [Serializable]
  //[XmlType("ML_CodeDefinition", Namespace = "http://www.isotc211.org/2005/gmx")]
  //[XmlRoot("ML_CodeDefinition", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_CodeDefinition")]
  public class ML_CodeDefinition_Type : CodeDefinition_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_CodeDefinition_Type"/>.
    /// </summary>
    public ML_CodeDefinition_Type() {
      _alternativeExpression = default; //  new List<CodeAlternativeExpression_Type>();
    }

    #endregion

    #region Public Properties

    private ObservableCollection<CodeAlternativeExpression_Type> _alternativeExpression;

    //[XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public ObservableCollection<CodeAlternativeExpression_Type> AlternativeExpression {
      get => _alternativeExpression;
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
