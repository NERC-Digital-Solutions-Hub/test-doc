
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
  [XmlType("LE_Algorithm_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("LE_Algorithm_PropertyType")]
  public class LE_Algorithm_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_Algorithm_PropertyType"/>.
    /// </summary>
    public LE_Algorithm_PropertyType() {
      _le_Algorithm = default; // new LE_Algorithm_Type();
    }

    #endregion

    #region Public Properties

    private LE_Algorithm_Type _le_Algorithm;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LE_Algorithm", Order = 0)]
    [JsonProperty("LE_Algorithm", Order = 0)]
    public LE_Algorithm_Type LE_Algorithm {
      get {
        return _le_Algorithm;
      }
      set {
        if (_le_Algorithm == value) {
          return;
        }
        if (_le_Algorithm == null || _le_Algorithm.Equals(value) != true) {
          _le_Algorithm = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
