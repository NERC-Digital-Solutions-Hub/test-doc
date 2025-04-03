
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 23/12/2022, @gisvlasta
// History           : 27/02/2025, @gisvlasta
//                     The class was renamed to RealDbEntity and now inherits from NumberDbEntity.
//                   : 06/03/2025, @gisvlasta - Implemented IValue<decimal> interface.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="Real" type="xs:double"/>
// <xs:complexType name="Real_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Real"/>
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
  /// Represents an entity that maps a <see cref="double"/> value to a dedicated database table,
  /// aligning with the ISO 19115 <c>Real_PropertyType</c> definition for geospatial metadata.
  /// </summary>
  /// <remarks>
  /// Use the <see cref="double"/> type whenever double values are required in a POCO.
  /// If the <see cref="double"/> property must be stored in its own table (for example, to satisfy
  /// advanced geospatial metadata requirements), map it to this <see cref="RealDbEntity"/>.
  /// This design helps ensure consistent handling of <see cref="double"/> values according to the ISO 19115 standard.
  /// </remarks>
  //[Serializable]
  //[XmlType("Real_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("RealDbEntity")]
  public class RealDbEntity : NumberDbEntity, INullableValue<double> {

    #region INullableValue<T> Interface

    private double? _value;

    /// <summary>
    /// Gets/Sets the <see cref="double"/> value.
    /// </summary>
    //[XmlElement("Real", DataType = "double", Order = 0)]
    [JsonProperty("Real", Order = 0)]
    public double? Value {
      get => _value;
      set => SetProperty(ref _value, value);
    }

    #endregion

  }

}
