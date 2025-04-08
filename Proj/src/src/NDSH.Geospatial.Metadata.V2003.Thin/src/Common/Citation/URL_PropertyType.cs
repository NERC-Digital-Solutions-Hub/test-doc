
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 18:06, @gisvlasta.
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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("URL_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("URL_PropertyType")]
  public class URL_PropertyType : NilReasonModel {

    #region Public Properties

    private string _uRL;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("URL", DataType = "anyURI", Order = 0)]
    [JsonProperty("URL", Order = 0)]
    public string URL {
      get {
        return _uRL;
      }
      set {
        if (_uRL == value) {
          return;
        }
        if (_uRL == null || _uRL.Equals(value) != true) {
          _uRL = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
