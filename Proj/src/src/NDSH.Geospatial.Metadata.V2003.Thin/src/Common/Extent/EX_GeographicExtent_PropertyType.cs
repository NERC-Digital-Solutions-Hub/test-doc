
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 19:59, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("EX_GeographicExtent_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("EX_GeographicExtent_PropertyType")]
  public class EX_GeographicExtent_PropertyType : ObjectReference_PropertyType {
    
    #region Public Properties

    private AbstractEX_GeographicExtent_Type _abstractEX_GeographicExtent;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractEX_GeographicExtent", Order = 0)]
    [JsonProperty("AbstractEX_GeographicExtent", Order = 0)]
    public AbstractEX_GeographicExtent_Type AbstractEX_GeographicExtent {
      get {
        return _abstractEX_GeographicExtent;
      }
      set {
        if (_abstractEX_GeographicExtent == value) {
          return;
        }
        if (_abstractEX_GeographicExtent == null || _abstractEX_GeographicExtent.Equals(value) != true) {
          _abstractEX_GeographicExtent = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
