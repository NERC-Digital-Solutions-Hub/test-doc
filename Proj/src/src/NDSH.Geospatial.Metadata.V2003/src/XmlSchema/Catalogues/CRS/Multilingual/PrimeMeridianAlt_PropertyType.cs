
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 12:18, @gisvlasta.
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
  [XmlType("PrimeMeridianAlt_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("PrimeMeridianAlt_PropertyType")]
  public class PrimeMeridianAlt_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="PrimeMeridianAlt_PropertyType"/>.
    /// </summary>
    public PrimeMeridianAlt_PropertyType() {
      _primeMeridianAlt  = default; //  new PrimeMeridianAlt_Type();
    }

    #endregion

    #region Public Properties

    private PrimeMeridianAlt_Type _primeMeridianAlt;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PrimeMeridianAlt", Order = 0)]
    [JsonProperty("PrimeMeridianAlt", Order = 0)]
    public PrimeMeridianAlt_Type PrimeMeridianAlt {
      get {
        return _primeMeridianAlt;
      }
      set {
        if (_primeMeridianAlt == value) {
          return;
        }
        if (_primeMeridianAlt == null || _primeMeridianAlt.Equals(value) != true) {
          _primeMeridianAlt = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
