
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 20:53, @gisvlasta.
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
//<xs:attribute name="uuidref" type="xs:string"/>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common {

  /// <summary>
  /// 
  /// </summary>
  public interface IUuidRef {

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute("uuidref", DataType = "string")]
    //[JsonProperty("uuidref")]
    public string UuidRef {
      get;
      set;
    }

  }

}
