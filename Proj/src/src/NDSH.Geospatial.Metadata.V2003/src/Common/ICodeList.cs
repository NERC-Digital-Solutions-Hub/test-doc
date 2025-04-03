
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
// <xs:attribute name="codeList" type="xs:anyURI" use="required"/>
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
  /// Defines a contract for objects that require a code list reference as per
  /// the ISO 19115 metadata standard. This interface ensures that implementing
  /// classes provide a structured mechanism to reference external code lists.
  /// </summary>
  public interface ICodeList {

    /// <summary>
    /// Gets/Sets the URI reference to an external code list.
    /// This property is required and must be a valid URI,
    /// ensuring compliance with metadata schema definitions.
    /// </summary>
    //[XmlAttribute(AttributeName = "codeList", DataType = "anyURI")]
    //[JsonProperty("codeList")]
    // TODO: The XmlAttribute is used to inform the way the Id is serialized. Needs removal.
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string CodeList {
      get;
      set;
    }

  }

}
