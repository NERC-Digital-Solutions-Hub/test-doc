
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:39, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Instrument_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Instrument_PropertyType")]
  public class MI_Instrument_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Instrument_PropertyType"/>.
    /// </summary>
    public MI_Instrument_PropertyType() {
      _mi_Instrument = default; // new MI_Instrument_Type();
    }

    #endregion

    #region Public Properties

    private MI_Instrument_Type _mi_Instrument;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Instrument", Order = 0)]
    [JsonProperty("MI_Instrument", Order = 0)]
    public MI_Instrument_Type MI_Instrument {
      get {
        return _mi_Instrument;
      }
      set {
        if (_mi_Instrument == value) {
          return;
        }
        if (_mi_Instrument == null || _mi_Instrument.Equals(value) != true) {
          _mi_Instrument = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
