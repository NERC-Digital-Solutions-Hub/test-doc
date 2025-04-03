
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 04/012023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/units.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="DerivedUnit" type="gml:DerivedUnitType" substitutionGroup="gml:UnitDefinition">
//   <annotation>
//     <documentation>
//       Derived units are defined by combination of other units.
//       Derived units are used for quantities other than those corresponding to the base units,
//       such as hertz (s-1) for frequency, Newton (kg.m/s2) for force.
//       Derived units based directly on base units are usually preferred for quantities other
//       than the fundamental quantities within a system. If a derived unit is not the preferred
//       unit, the gml:ConventionalUnit element should be used instead.
//       The gml:DerivedUnit extends gml:UnitDefinition with the property gml:derivationUnitTerms.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="DerivedUnitType">
//   <complexContent>
//     <extension base="gml:UnitDefinitionType">
//       <sequence>
//         <element ref="gml:derivationUnitTerm" maxOccurs="unbounded"/>
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
  //[XmlInclude(typeof(ML_DerivedUnit_Type))]
  //[XmlType("DerivedUnitType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("DerivedUnitType")]
  public class DerivedUnitType : UnitDefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DerivedUnitType"/>.
    /// </summary>
    public DerivedUnitType() {
      _derivationUnitTerm = default; //  new List<DerivationUnitTermType>();
    }

    #endregion

    #region Public Properties

    private List<DerivationUnitTermType> _derivationUnitTerm;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("derivationUnitTerm", Order = 0)]
    [JsonProperty("derivationUnitTerm", Order = 0)]
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
