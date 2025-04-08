
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 02:43, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Resolution_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Resolution_PropertyType")]
  public class MD_Resolution_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Resolution_PropertyType"/>.
    /// </summary>
    public MD_Resolution_PropertyType() {
      _md_Resolution  = default; //  new MD_Resolution_Type();
    }

    #endregion

    #region Public Properties

    private MD_Resolution_Type _md_Resolution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Resolution", Order = 0)]
    [JsonProperty("MD_Resolution", Order = 0)]
    public MD_Resolution_Type MD_Resolution {
      get {
        return _md_Resolution;
      }
      set {
        if (_md_Resolution == value) {
          return;
        }
        if (_md_Resolution == null || _md_Resolution.Equals(value) != true) {
          _md_Resolution = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
