
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:37, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_EnvironmentalRecord_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_EnvironmentalRecord_PropertyType")]
  public class MI_EnvironmentalRecord_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_EnvironmentalRecord_PropertyType"/>.
    /// </summary>
    public MI_EnvironmentalRecord_PropertyType() {
      _mi_EnvironmentalRecord = default; // new MI_EnvironmentalRecord_Type();
    }

    #endregion

    #region Public Properties

    private MI_EnvironmentalRecord_Type _mi_EnvironmentalRecord;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_EnvironmentalRecord", Order = 0)]
    [JsonProperty("MI_EnvironmentalRecord", Order = 0)]
    public MI_EnvironmentalRecord_Type MI_EnvironmentalRecord {
      get {
        return _mi_EnvironmentalRecord;
      }
      set {
        if (_mi_EnvironmentalRecord == value) {
          return;
        }
        if (_mi_EnvironmentalRecord == null || _mi_EnvironmentalRecord.Equals(value) != true) {
          _mi_EnvironmentalRecord = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
