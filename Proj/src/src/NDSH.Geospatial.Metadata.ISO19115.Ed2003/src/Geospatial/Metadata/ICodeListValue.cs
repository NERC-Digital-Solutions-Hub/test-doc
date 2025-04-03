
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 06/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// ---------------------------------------------------------------------------------------------------------------------
// <xs:attribute name="codeListValue" type="xs:anyURI" use="required"/>
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Constructors - Destructors

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata {

  /// <summary>
  /// Defines a contract for objects that require a reference to a specific value
  /// from an external code list. This interface ensures that implementing classes
  /// provide a structured mechanism for referencing standardized code list values,
  /// following the ISO 19115 metadata standard.
  /// </summary>
  public interface ICodeListValue {

    /// <summary>
    /// Gets/Sets the URI reference to a specific value in an external code list.
    /// This property is required and must be a valid URI,
    /// ensuring compliance with metadata schema definitions.
    /// </summary>
    //[XmlAttribute(AttributeName = "codeListValue", DataType = "anyURI")]
    //[JsonProperty("codeListValue")]
    // TODO: The XmlAttribute is used to inform the way the Id is serialized. Needs removal.
    //[Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string CodeListValue {
      get;
      set;
    }

  }

}
