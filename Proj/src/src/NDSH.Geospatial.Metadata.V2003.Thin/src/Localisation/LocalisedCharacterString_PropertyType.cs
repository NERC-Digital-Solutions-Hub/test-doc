
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:24, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Localisation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LocalisedCharacterString_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("LocalisedCharacterString_PropertyType")]
  public class LocalisedCharacterString_PropertyType : ObjectReference_PropertyType {

    #region Constuctors - Destructors

    /// <summary>
    /// Initializes the <see cref="LocalisedCharacterString_PropertyType"/>.
    /// </summary>
    public LocalisedCharacterString_PropertyType() {
      _localisedCharacterString  = default; //  new LocalisedCharacterString_Type();
    }

    #endregion

    #region Public Properties

    private LocalisedCharacterString_Type _localisedCharacterString;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LocalisedCharacterString", Order = 0)]
    [JsonProperty("LocalisedCharacterString", Order = 0)]
    public LocalisedCharacterString_Type LocalisedCharacterString {
      get {
        return _localisedCharacterString;
      }
      set {
        if (_localisedCharacterString == value) {
          return;
        }
        if (_localisedCharacterString == null || _localisedCharacterString.Equals(value) != true) {
          _localisedCharacterString = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
