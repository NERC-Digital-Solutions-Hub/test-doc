
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 30/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:attribute name="uuid" type="xs:string"/>
// --------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.Common {

  /// <summary>
  /// Defines a contract for objects that require a universally unique identifier (UUID).
  /// This interface ensures that objects can be uniquely referenced across different datasets,
  /// following the ISO 19115 metadata standard.
  /// </summary>
  public interface IUuid {

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
