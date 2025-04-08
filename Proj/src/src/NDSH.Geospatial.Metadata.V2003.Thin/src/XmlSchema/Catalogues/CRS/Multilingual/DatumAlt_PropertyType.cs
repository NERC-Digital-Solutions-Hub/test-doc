
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 11:53, @gisvlasta.
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DatumAlt_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("DatumAlt_PropertyType")]
  public class DatumAlt_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DatumAlt_PropertyType"/>.
    /// </summary>
    public DatumAlt_PropertyType() {
      _datumAlt  = default; //  new DatumAlt_Type();
    }

    #endregion

    #region Public Properties

    private DatumAlt_Type _datumAlt;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DatumAlt", Order = 0)]
    [JsonProperty("DatumAlt", Order = 0)]
    public DatumAlt_Type DatumAlt {
      get {
        return _datumAlt;
      }
      set {
        if (_datumAlt == value) {
          return;
        }
        if (_datumAlt == null || _datumAlt.Equals(value) != true) {
          _datumAlt = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
