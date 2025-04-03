
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 23/12/2022, @gisvlasta
// History           : 06/03/2025, @gisvlasta - Implemented IValue<bool> interface and updated documentation.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : Property Metadata: NilReasonEntity
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:element name="Boolean" type="xs:boolean"/>
// 
// <xs:complexType name="Boolean_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:Boolean"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Database.Entities;
using NDSH.Geospatial.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Common.BasicTypes.Primitive.Truth {

  /// <summary>
  /// Represents an entity that maps an <see cref="bool"/> value to a dedicated database table,
  /// aligning with the ISO 19115 <c>Boolean_PropertyType</c> definition for geospatial metadata.
  /// </summary>
  /// <remarks>
  /// Use the <see cref="bool"/> type whenever boolean values are required in a POCO.<br></br>
  /// If the <see cref="bool"/> property must be stored in its own table (for example, to satisfy
  /// advanced geospatial metadata requirements) map it to this <see cref="BooleanDbEntity"/>.<br></br>
  /// This design helps ensure consistent handling of <see cref="bool"/> values according to the ISO 19115 standard.
  /// </remarks>
  [Serializable]
  //[XmlType("Boolean", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("Boolean")]
  public class BooleanDbEntity : ObservableDbEntity, INullableValue<bool> {

    #region INullableValue<T> Interface

    private bool? _boolean;

    /// <summary>
    /// Gets/Sets the <see cref="bool"/> value.
    /// </summary>
    //[XmlElement("Boolean", IsNullable = true, Order = 0)]
    [JsonProperty("Boolean", Order = 0)]
    public bool? Value {
      get => _boolean;
      set => SetProperty(ref _boolean, value);
    }

    #endregion

  }

}
