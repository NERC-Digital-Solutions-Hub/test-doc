
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 11:05, @gisvlasta.
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CrsAlt_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CrsAlt_PropertyType")]
  public class CrsAlt_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CrsAlt_PropertyType"/>.
    /// </summary>
    public CrsAlt_PropertyType() {
      _crsAlt  = default; //  new CrsAlt_Type();
    }

    #endregion

    #region Public Properties

    private CrsAlt_Type _crsAlt;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CrsAlt", Order = 0)]
    [JsonProperty("CrsAlt", Order = 0)]
    public CrsAlt_Type CrsAlt {
      get {
        return _crsAlt;
      }
      set {
        if (_crsAlt == value) {
          return;
        }
        if (_crsAlt == null || _crsAlt.Equals(value) != true) {
          _crsAlt = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
