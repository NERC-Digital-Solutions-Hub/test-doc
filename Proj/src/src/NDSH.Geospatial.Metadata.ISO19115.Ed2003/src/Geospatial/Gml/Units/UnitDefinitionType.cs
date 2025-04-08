
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
//                     /2005/gml/units.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:complexType name="UnitDefinition_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gml:UnitDefinition"/>
//   </xs:sequence>
//   <xs:attributeGroup ref="gco:ObjectReference"/>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// 
// <complexType name="UnitDefinitionType">
//   <complexContent>
//     <extension base="gml:DefinitionType">
//       <sequence>
//         <element ref="gml:quantityType" minOccurs="0"/>
//         <element ref="gml:quantityTypeReference" minOccurs="0"/>
//         <element ref="gml:catalogSymbol" minOccurs="0"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Gml.BasicTypes;
using NDSH.Geospatial.Gml.Dictionary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Units {

  // WARNING: REVISIT

  #region XmlIncludes
  //[XmlInclude(typeof(ConventionalUnitType))]
  //[XmlInclude(typeof(ML_ConventionalUnit_Type))]
  //[XmlInclude(typeof(DerivedUnitType))]
  //[XmlInclude(typeof(ML_DerivedUnit_Type))]
  //[XmlInclude(typeof(BaseUnitType))]
  //[XmlInclude(typeof(ML_BaseUnit_Type))]
  //[XmlInclude(typeof(UomAlternativeExpression_Type))]
  //[XmlInclude(typeof(ML_UnitDefinition_Type))]
  #endregion

  //[Serializable]
  //[XmlType("UnitDefinition", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("UnitDefinition")]
  public class UnitDefinitionType : DefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UnitDefinitionType"/>.
    /// </summary>
    public UnitDefinitionType() {
      _quantityType = default; //  new StringOrRefType();
      _quantityTypeReference = default; //  new ReferenceType();
      _catalogSymbol = default; //  new CodeType();
    }

    #endregion

    #region Public Properties

    private StringOrRefType _quantityType;

    //[XmlElement("quantityType", Order = 0)]
    [JsonProperty("quantityType", Order = 0)]
    public StringOrRefType QuantityType {
      get => _quantityType;
      set {
        if (_quantityType == value) {
          return;
        }
        if (_quantityType == null || _quantityType.Equals(value) != true) {
          _quantityType = value;
          OnPropertyChanged();
        }
      }
    }

    private ReferenceType _quantityTypeReference;

    //[XmlElement("quantityTypeReference", Order = 1)]
    [JsonProperty("quantityTypeReference", Order = 1)]
    public ReferenceType QuantityTypeReference {
      get => _quantityTypeReference;
      set {
        if (_quantityTypeReference == value) {
          return;
        }
        if (_quantityTypeReference == null || _quantityTypeReference.Equals(value) != true) {
          _quantityTypeReference = value;
          OnPropertyChanged();
        }
      }
    }

    private CodeType _catalogSymbol;

    //[XmlElement("catalogSymbol", Order = 2)]
    [JsonProperty("catalogSymbol", Order = 2)]
    public CodeType CatalogSymbol {
      get => _catalogSymbol;
      set {
        if (_catalogSymbol == value) {
          return;
        }
        if (_catalogSymbol == null || _catalogSymbol.Equals(value) != true) {
          _catalogSymbol = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
