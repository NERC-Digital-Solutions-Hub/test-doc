
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/02/2023, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/units.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="ConventionalUnit" type="gml:ConventionalUnitType" substitutionGroup="gml:UnitDefinition">
//   <annotation>
//     <documentation>
//       Conventional units that are neither base units nor defined by direct
//       combination of base units are used in many application domains.
//       For example electronVolt for energy, feet and nautical miles for length.
//       In most cases there is a known, usually linear, conversion to a preferred unit
//       which is either a base unit or derived by direct combination of base units.
//       The gml:ConventionalUnit extends gml:UnitDefinition with a property that describes
//       a conversion to a preferred unit for this physical quantity.
//       When the conversion is exact, the element gml:conversionToPreferredUnit should be used,
//       or when the conversion is not exact the element gml:roughConversionToPreferredUnit is available.
//       Both of these elements have the same content model.
//       The gml:derivationUnitTerm property defined above is included to allow a user
//       to optionally record how this unit may be derived from other (“more primitive”) units.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="ConventionalUnitType">
//   <complexContent>
//     <extension base="gml:UnitDefinitionType">
//       <sequence>
//         <choice>
//           <element ref="gml:conversionToPreferredUnit"/>
//           <element ref="gml:roughConversionToPreferredUnit"/>
//         </choice>
//         <element ref="gml:derivationUnitTerm" minOccurs="0" maxOccurs="unbounded"/>
//       </sequence>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces


using NDSH.Geospatial.Metadata.XmlSchema.Catalogues.UnitsOfMeasure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Units {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  //[XmlInclude(typeof(ML_ConventionalUnit_Type))]
  //[XmlType("ConventionalUnitType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConventionalUnitType")]
  public class ConventionalUnitType : UnitDefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ConventionalUnitType"/>.
    /// </summary>
    public ConventionalUnitType() {
      _derivationUnitTerm = default; //  new List<DerivationUnitTermType>();
    }

    #endregion

    #region Public Properties

    private ConversionToPreferredUnitType _conversionToPreferredUnitItem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("conversionToPreferredUnit", typeof(ConversionToPreferredUnitType), Order = 0)]
    [XmlElement("roughConversionToPreferredUnit", typeof(ConversionToPreferredUnitType), Order = 0)]
    [XmlChoiceIdentifier("UnitConversionItemElementName")]
    public ConversionToPreferredUnitType ConversionToPreferredUnitItem {
      get {
        return _conversionToPreferredUnitItem;
      }
      set {
        if (_conversionToPreferredUnitItem == value) {
          return;
        }
        if (_conversionToPreferredUnitItem == null || _conversionToPreferredUnitItem.Equals(value) != true) {
          _conversionToPreferredUnitItem = value;
          OnPropertyChanged();
        }
      }
    }

    private UnitConversion _unitConversionItemElementName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UnitConversionItemElementName", Order = 1)]
    [XmlIgnore]
    public UnitConversion UnitConversionItemElementName {
      get {
        return _unitConversionItemElementName;
      }
      set {
        if (_unitConversionItemElementName.Equals(value) != true) {
          _unitConversionItemElementName = value;
          OnPropertyChanged();
        }
      }
    }

    private List<DerivationUnitTermType> _derivationUnitTerm;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("derivationUnitTerm", Order = 2)]
    [JsonProperty("derivationUnitTerm", Order = 2)]
    public List<DerivationUnitTermType> DerivationUnitTerm {
      get {
        return _derivationUnitTerm;
      }
      set {
        if (_derivationUnitTerm == value) {
          return;
        }
        if (_derivationUnitTerm == null || _derivationUnitTerm.Equals(value) != true) {
          _derivationUnitTerm = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
