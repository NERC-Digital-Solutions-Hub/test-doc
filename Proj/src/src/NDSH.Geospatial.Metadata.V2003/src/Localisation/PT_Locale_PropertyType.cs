
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:16, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
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
  [Serializable]
  [XmlType("PT_Locale_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("PT_Locale_PropertyType")]
  public class PT_Locale_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PT_Locale_PropertyType"/>.
    /// </summary>
    public PT_Locale_PropertyType() {
      _pt_Locale  = default; //  new PT_Locale_Type();
    }

    #endregion

    #region Private fields

    private PT_Locale_Type _pt_Locale;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PT_Locale", Order = 0)]
    [JsonProperty("PT_Locale", Order = 0)]
    public PT_Locale_Type PT_Locale {
      get {
        return _pt_Locale;
      }
      set {
        if (_pt_Locale == value) {
          return;
        }
        if (_pt_Locale == null || _pt_Locale.Equals(value) != true) {
          _pt_Locale = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
