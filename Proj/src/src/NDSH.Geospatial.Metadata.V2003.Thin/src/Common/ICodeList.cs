
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 13:50, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common {

  /// <summary>
  /// 
  /// </summary>
  public interface ICodeList {

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "codeList", DataType = "anyURI")]
    [JsonProperty("codeList")]
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string CodeList {
      get;
      set;
    }

  }

}
