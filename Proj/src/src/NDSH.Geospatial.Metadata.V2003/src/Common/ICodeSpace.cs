
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 06/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:attribute name="codeSpace" type="xs:anyURI"/>
// --------------------------------------------------------------------------------
#endregion

#region Constructors - Destructors

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
  /// Defines a contract for objects that require a reference to a code space.
  /// This interface ensures that implementing classes provide a structured mechanism
  /// for referencing a code space as per the ISO 19115 metadata standard.
  /// </summary>
  public interface ICodeSpace {

    /// <summary>
    /// Gets or sets the URI reference to the code space authority.
    /// This property is required and must be a valid URI,
    /// ensuring compliance with metadata schema definitions.
    /// </summary>
    //[XmlAttribute(AttributeName = "codeSpace", DataType = "anyURI")]
    //[JsonProperty("codeSpace")]
    // TODO: The XmlAttribute is used to inform the way the Id is serialized. Needs removal.
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string? CodeSpace {
      get;
      set;
    }

  }

}
