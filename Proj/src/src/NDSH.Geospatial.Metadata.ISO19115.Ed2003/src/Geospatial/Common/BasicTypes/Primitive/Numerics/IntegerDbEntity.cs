﻿
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 28/12/2022, @gisvlasta
// History           : 27/02/2025, @gisvlasta
//                     The class was renamed to IntegerDbEntity and now inherits from NumberDbEntity.
//                   : 06/03/2025, @gisvlasta - Implemented IValue<int> interface.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="Integer" type="xs:integer"/>
// <xs:complexType name="Integer_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Integer"/>
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
  /// Represents an entity that maps an <see cref="int"/> value to a dedicated database table,
  /// aligning with the ISO 19115 <c>Integer_PropertyType</c> definition for geospatial metadata.
  /// </summary>
  /// <remarks>
  /// Use the <see cref="int"/> type whenever integer values are required in a POCO.
  /// If the <see cref="int"/> property must be stored in its own table (for example, to satisfy
  /// advanced geospatial metadata requirements) map it to this <see cref="IntegerDbEntity"/>.
  /// This design helps ensure consistent handling of <see cref="int"/> values according to the ISO 19115 standard.
  /// </remarks>
  //[Serializable]
  //[XmlType("Integer_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("IntegerDbEntity")]
  public class IntegerDbEntity : NumberDbEntity, INullableValue<int> {

    #region INullableValue<T> Interface

    private int? _integer;

    /// <summary>
    /// Gets/Sets the <see cref="int"/> value.
    /// </summary>
    //[XmlElement("Integer", DataType = "integer", Order = 0)]
    [JsonProperty("Integer", Order = 0)]
    public int? Value {
      get => _integer;
      set => SetProperty(ref _integer, value);
    }

    #endregion

  }

}
