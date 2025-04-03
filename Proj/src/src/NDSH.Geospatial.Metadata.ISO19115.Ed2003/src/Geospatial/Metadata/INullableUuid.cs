
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 30/12/2022, @gisvlasta
// History           : 14/03/2025, @gisvlasta - Renamed IUuid to INullableUuid.
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:attribute name="uuid" type="xs:string"/>
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
  /// Defines a contract for objects that require a universally unique identifier (UUID).
  /// This interface ensures that objects can be uniquely referenced across different datasets,
  /// following the ISO 19115 metadata standard.
  /// </summary>
  public interface INullableUuid {

    /// <summary>
    /// Gets/Sets the universally unique identifier (UUID) for the object.
    /// This ensures the object can be referenced uniquely across different datasets.
    /// </summary>
    //[XmlAttribute("uuid", DataType = "string")]
    //[JsonProperty("uuid")]
    // TODO: The XmlAttribute is used to inform the way the Uuid is serialized. Needs removal.
    public string? Uuid {
      get;
      set;
    }

  }

}
