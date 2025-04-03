
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 19/03/2025, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/units.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="conversionToPreferredUnit" type="gml:ConversionToPreferredUnitType">
//   <annotation>
//     <documentation>
//       The elements gml:conversionToPreferredUnit and gml:roughConversionToPreferredUnit represent parameters
//       used to convert conventional units to preferred units for this physical quantity type.
//       A preferred unit is either a Base Unit or a Derived Unit that is selected for all values of
//       one physical quantity type.
//     </documentation>
//   </annotation>
// </element>
// 
// <element name="roughConversionToPreferredUnit" type="gml:ConversionToPreferredUnitType">
//   <annotation>
//     <documentation>
//       The elements gml:conversionToPreferredUnit and gml:roughConversionToPreferredUnit represent parameters used to
//       convert conventional units to preferred units for this physical quantity type.  A preferred unit is either a
//       Base Unit or a Derived Unit that is selected for all values of one physical quantity type.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="ConversionToPreferredUnitType">
//   <annotation>
//     <documentation>
//       The inherited attribute uom references the preferred unit that this conversion applies to.
//       The conversion of a unit to the preferred unit for this physical quantity type is specified by an
//       arithmetic conversion (scaling and/or offset). The content model extends gml:UnitOfMeasureType,
//       which has a mandatory attribute uom which identifies the preferred unit for the physical quantity type
//       that this conversion applies to. The conversion is specified by a choice of
//       -  gml:factor, which defines the scale factor, or
//       -  gml:formula, which defines a formula 
//       by which a value using the conventional unit of measure can be converted to obtain the corresponding value
//       using the preferred unit of measure.  
//       The formula defines the parameters of a simple formula by which a value using the conventional unit of measure
//       can be converted to the corresponding value using the preferred unit of measure. The formula element contains
//       elements a, b, c and d, whose values use the XML Schema type double.
//       These values are used in the formula y = (a + bx) / (c + dx), where x is a value using this unit,
//       and y is the corresponding value using the base unit. The elements a and d are optional,
//       and if values are not provided, those parameters are considered to be zero.
//       If values are not provided for both a and d, the formula is equivalent to a fraction with numerator and
//       denominator parameters.
//     </documentation>
//   </annotation>
//   <complexContent>
//     <extension base="gml:UnitOfMeasureType">
//       <choice>
//         <element name="factor" type="double"/>
//         <element name="formula" type="gml:FormulaType"/>
//       </choice>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Units {

  /// <summary>
  /// The inherited attribute uom references the preferred unit that this conversion applies to.
  /// The conversion of a unit to the preferred unit for this physical quantity type is specified by an
  /// arithmetic conversion (scaling and/or offset). The content model extends gml:UnitOfMeasureType,
  /// which has a mandatory attribute uom which identifies the preferred unit for the physical quantity type
  /// that this conversion applies to. The conversion is specified by a choice of
  /// -	gml:factor, which defines the scale factor, or
  /// -	gml:formula, which defines a formula
  /// by which a value using the conventional unit of measure can be converted to obtain the corresponding value
  /// using the preferred unit of measure.
  /// The formula defines the parameters of a simple formula by which a value using the conventional unit of measure
  /// can be converted to the corresponding value using the preferred unit of measure.
  /// The formula element contains elements a, b, c and d, whose values use the XML Schema type double.
  /// These values are used in the formula y = (a + bx) / (c + dx), where x is a value using this unit,
  /// and y is the corresponding value using the base unit. The elements a and d are optional,
  /// and if values are not provided, those parameters are considered to be zero.
  /// If values are not provided for both a and d, the formula is equivalent to a fraction
  /// with numerator and denominator parameters.
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConversionToPreferredUnitType")]
  public class ConversionToPreferredUnitType : UnitOfMeasureType {

    #region Private fields
    private object _item;
    #endregion

    [XmlElement("factor", typeof(double), Order = 0)]
    [XmlElement("formula", typeof(FormulaType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }

  }

}
