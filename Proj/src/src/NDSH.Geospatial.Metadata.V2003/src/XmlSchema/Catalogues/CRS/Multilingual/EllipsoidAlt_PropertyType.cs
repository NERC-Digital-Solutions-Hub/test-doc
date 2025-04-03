
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 12:07, @gisvlasta.
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
  [XmlType("EllipsoidAlt_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("EllipsoidAlt_PropertyType")]
  public class EllipsoidAlt_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="EllipsoidAlt_PropertyType"/>.
    /// </summary>
    public EllipsoidAlt_PropertyType() {
      _ellipsoidAlt  = default; //  new EllipsoidAlt_Type();
    }

    #endregion

    #region Public Properties

    private EllipsoidAlt_Type _ellipsoidAlt;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EllipsoidAlt", Order = 0)]
    [JsonProperty("EllipsoidAlt")]
    public EllipsoidAlt_Type EllipsoidAlt {
      get {
        return _ellipsoidAlt;
      }
      set {
        if (_ellipsoidAlt == value) {
          return;
        }
        if (_ellipsoidAlt == null || _ellipsoidAlt.Equals(value) != true) {
          _ellipsoidAlt = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
