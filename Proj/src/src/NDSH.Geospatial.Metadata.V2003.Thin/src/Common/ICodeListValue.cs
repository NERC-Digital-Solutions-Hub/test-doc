
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 14:04, @gisvlasta.
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
// <xs:attribute name="codeListValue" type="xs:anyURI" use="required"/>
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
  public interface ICodeListValue {

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "codeListValue", DataType = "anyURI")]
    [JsonProperty("codeListValue")]
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string CodeListValue {
      get;
      set;
    }

  }

}
