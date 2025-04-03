
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/units.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="derivationUnitTerm" type="gml:DerivationUnitTermType">
//   <annotation>
//     <documentation>
//       A set of gml:derivationUnitTerm elements describes a derived unit of measure.
//       Each element carries an integer exponent. The terms are combined by raising
//       each referenced unit to the power of its exponent and forming the product.
//       This unit term references another unit of measure (uom) and provides an integer
//       exponent applied to that unit in defining the compound unit.
//       The exponent may be positive or negative, but not zero.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="DerivationUnitTermType">
//   <complexContent>
//     <extension base="gml:UnitOfMeasureType">
//       <attribute name="exponent" type="integer"/>
//     </extension>
//   </complexContent>
// </complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
  [XmlType("DerivationUnitTermType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DerivationUnitTermType")]
  public class DerivationUnitTermType : UnitOfMeasureType {

    #region Public Properties

    private string _exponent;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("exponent", DataType = "integer")]
    [JsonProperty("exponent")]
    public string Exponent {
      get {
        return _exponent;
      }
      set {
        if (_exponent == value) {
          return;
        }
        if (_exponent == null || _exponent.Equals(value) != true) {
          _exponent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
