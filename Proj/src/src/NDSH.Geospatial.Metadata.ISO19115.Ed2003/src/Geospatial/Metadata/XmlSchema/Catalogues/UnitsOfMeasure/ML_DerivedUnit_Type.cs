
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
// XSD               : /2005/gmx/uomItem.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="ML_DerivedUnit_Type">
//   <xs:complexContent>
//     <xs:extension base="gml:DerivedUnitType">
//       <xs:sequence>
//         <xs:element name="alternativeExpression"
//                     type="gmx:UomAlternativeExpression_PropertyType" maxOccurs="unbounded"/>
//       </xs:sequence>
//     </xs:extension>
//   </xs:complexContent>
// </xs:complexType>
// <xs:element name="ML_DerivedUnit" type="gmx:ML_DerivedUnit_Type" substitutionGroup="gml:DerivedUnit"/>
// <xs:complexType name="ML_DerivedUnit_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmx:ML_DerivedUnit"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.Units;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.XmlSchema.Catalogues.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_DerivedUnit", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("ML_DerivedUnit", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_DerivedUnit")]
  public class ML_DerivedUnit_Type : DerivedUnitType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_DerivedUnit_Type"/>.
    /// </summary>
    public ML_DerivedUnit_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _alternativeExpression = default; //  new List<UomAlternativeExpression_Type>();

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

    private List<UomAlternativeExpression_Type> _alternativeExpression;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<UomAlternativeExpression_Type> AlternativeExpression {
      get {
        return _alternativeExpression;
      }
      set => SetProperty(ref _alternativeExpression, value);
    }

    #endregion

  }

}
