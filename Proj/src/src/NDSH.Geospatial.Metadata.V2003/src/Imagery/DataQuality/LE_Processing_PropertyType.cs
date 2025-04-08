
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

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LE_Processing_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("LE_Processing_PropertyType")]
  public class LE_Processing_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_Processing_PropertyType"/>.
    /// </summary>
    public LE_Processing_PropertyType() {
      _le_Processing = default; // new LE_Processing_Type();
    }

    #endregion

    #region Public Properties

    private LE_Processing_Type _le_Processing;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LE_Processing", Order = 0)]
    [JsonProperty("LE_Processing", Order = 0)]
    public LE_Processing_Type LE_Processing {
      get {
        return _le_Processing;
      }
      set {
        if (_le_Processing == value) {
          return;
        }
        if (_le_Processing == null || _le_Processing.Equals(value) != true) {
          _le_Processing = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
