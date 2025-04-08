
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 02/01/2023, @gisvlasta
// History           : 27/02/2025, @gisvlasta
//                     The class was renamed to DecimalDbEntity and now inherits from NumberDbEntity.
//                   : 06/03/2025, @gisvlasta - Implemented IValue<decimal> interface.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="Decimal" type="xs:decimal"/>
// <xs:complexType name="Decimal_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Decimal"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.Numerics {

  /// <summary>
  /// Represents an entity that maps a <see cref="decimal"/> value to a dedicated database table,
  /// aligning with the ISO 19115 <c>Decimal_PropertyType</c> definition for geospatial metadata.
  /// </summary>
  /// <remarks>
  /// Use the <see cref="decimal"/> type whenever decimal values are required in a POCO.
  /// If the <see cref="decimal"/> property must be stored in its own table (for example, to satisfy
  /// advanced geospatial metadata requirements) map it to this <see cref="DecimalDbEntity"/>.
  /// This design helps ensure consistent handling of <see cref="decimal"/> values according to the ISO 19115 standard.
  /// </remarks>
  //[Serializable]
  //[XmlType("Decimal_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("DecimalDbEntity")]
  public class DecimalDbEntity : NumberDbEntity, INullableValue<decimal> {

    #region INullableValue<T> Interface

    private decimal? _decimal;

    /// <summary>
    /// Gets/Sets the <see cref="decimal"/> value.
    /// </summary>
    //[XmlElement("Decimal", Order = 0)]
    [JsonProperty("Decimal", Order = 0)]
    public decimal? Value {
      get => _decimal;
      set => SetProperty(ref _decimal, value);
    }

    #endregion

  }

}
