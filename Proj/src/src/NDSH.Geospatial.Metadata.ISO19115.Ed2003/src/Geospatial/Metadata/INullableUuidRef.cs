
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 30/12/2022, @gisvlasta
// History           : 14/03/2025, @gisvlasta - Renamed from IUuidRef to INullableUuidRef
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:attribute name="uuidref" type="xs:string"/>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Defines a contract for objects that require a reference to a
  /// universally unique identifier (UUID). This interface ensures that
  /// implementing classes provide a structured mechanism for referencing
  /// an existing UUID in compliance with the ISO 19115 metadata standard.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     The <see cref="UuidRef"/> property stores a reference to an existing UUID, allowing for linking
  ///     and association of metadata entities without duplicating identifier information.
  ///   </para>
  ///   <para>
  ///     <b>Considerations:</b>
  ///     <list type="bullet">
  ///       <item>The <see cref="UuidRef"/> property should be a valid string representing a UUID.</item>
  ///       <item>Designed for use when a metadata entity needs to reference another entity by its UUID.</item>
  ///       <item>Ensure proper validation and uniqueness constraints for the referenced UUID.</item>
  ///     </list>
  ///   </para>
  /// </remarks>
  public interface INullableUuidRef {

    /// <summary>
    /// Gets or sets the reference to an existing universally unique identifier (UUID).
    /// This property allows metadata entities to establish links using UUID references.
    /// </summary>
    //[XmlAttribute("uuidref", DataType = "string")]
    //[JsonProperty("uuidref")]
    // TODO: The XmlAttribute is used to inform the way the Id is serialized. Needs removal.
    public string? UuidRef {
      get;
      set;
    }

  }

}
