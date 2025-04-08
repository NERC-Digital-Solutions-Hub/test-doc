
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// History           : 
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/units.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <element name="BaseUnit" type="gml:BaseUnitType" substitutionGroup="gml:UnitDefinition">
//   <annotation>
//     <documentation>
//       A base unit is a unit of measure that cannot be derived by combination of
//       other base units within a particular system of units. For example,
//       in the SI system of units, the base units are metre, kilogram, second, Ampere,
//       Kelvin, mole, and candela, for the physical quantity types length, mass,
//       time interval, electric current, thermodynamic temperature, amount of
//       substance and luminous intensity, respectively.
//       gml:BaseUnit extends generic gml:UnitDefinition with the property gml:unitsSystem,
//       which carries a reference to the units system to which this base unit is asserted to belong.
//     </documentation>
//   </annotation>
// </element>
// 
// <complexType name="BaseUnitType">
//   <complexContent>
//     <extension base="gml:UnitDefinitionType">
//       <sequence>
//         <element name="unitsSystem" type="gml:ReferenceType"/>
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
  //[XmlInclude(typeof(ML_BaseUnit_Type))]
  //[XmlType("BaseUnitType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("BaseUnitType")]
  public class BaseUnitType : UnitDefinitionType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="BaseUnitType"/>.
    /// </summary>
    public BaseUnitType() {
      _unitsSystem = default; //  new ReferenceType();
    }

    #endregion

    #region Public Properties

    private ReferenceType _unitsSystem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("unitsSystem", Order = 0)]
    [JsonProperty("unitsSystem", Order = 0)]
    public ReferenceType UnitsSystem {
      get {
        return _unitsSystem;
      }
      set {
        if (_unitsSystem == value) {
          return;
        }
        if (_unitsSystem == null || _unitsSystem.Equals(value) != true) {
          _unitsSystem = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
