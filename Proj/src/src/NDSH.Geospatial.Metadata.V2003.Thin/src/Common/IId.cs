
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 22:01, @gisvlasta.
// Updated by        : 12/01/2023, 15:07, @gisvlasta.
//                     12/03/2023, 00:56, @gisvlasta. - Changed Id from string to int.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:attribute name="id" type="xs:ID"/>
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common {

  /// <summary>
  /// 
  /// </summary>
  public interface IId {

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("id", DataType = "ID")]
    [JsonProperty("id")]
    public int Id {
      get;
      set;
    }
    // TODO: Should the interface have am [XmlAttribute]???

  }

}
