
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 12:35, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LE_Source_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("LE_Source_PropertyType")]
  public class LE_Source_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_Source_PropertyType"/>.
    /// </summary>
    public LE_Source_PropertyType() {
      _le_Source = default; // new LE_Source_Type();
    }

    #endregion

    #region Public Properties

    private LE_Source_Type _le_Source;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LE_Source", Order = 0)]
    [JsonProperty("LE_Source", Order = 0)]
    public LE_Source_Type LE_Source {
      get {
        return _le_Source;
      }
      set {
        if (_le_Source == value) {
          return;
        }
        if (_le_Source == null || _le_Source.Equals(value) != true) {
          _le_Source = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
