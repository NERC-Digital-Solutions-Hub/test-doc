
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 05/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gml/units.xsd
// ---------------------------------------------------------------------------------------------------------------------
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Gml.Units {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml", IncludeInSchema = false)]
  public enum UnitConversion {

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "conversionToPreferredUnit")]
    [EnumMember(Value = "conversionToPreferredUnit")]
    ConversionToPreferredUnit,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "roughConversionToPreferredUnit")]
    [EnumMember(Value = "roughConversionToPreferredUnit")]
    RoughConversionToPreferredUnit,

  }

}
