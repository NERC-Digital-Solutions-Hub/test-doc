
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 14:35, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
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

namespace NDSH.Geospatial.Metadata.V2003.Localisation {
  
  /// <summary>
  /// 
  /// </summary>
  public interface ILocale_PropertyType {

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("locale", Order = 0)] // TODO: Should these [XmlElement be in the interface?
    [JsonProperty("locale", Order = 0)]
    public PT_Locale_PropertyType Locale {
      get;
      set;
    }

  }

}
