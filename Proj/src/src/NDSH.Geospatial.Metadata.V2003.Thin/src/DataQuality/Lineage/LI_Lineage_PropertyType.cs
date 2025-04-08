
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 16:49, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Lineage {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LI_Lineage_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("LI_Lineage_PropertyType")]
  public class LI_Lineage_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_Lineage_PropertyType"/>.
    /// </summary>
    public LI_Lineage_PropertyType() {
      _li_Lineage  = default; //  new LI_Lineage_Type();
    }

    #endregion

    #region Public Properties

    private LI_Lineage_Type _li_Lineage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LI_Lineage", Order = 0)]
    [JsonProperty("LI_Lineage", Order = 0)]
    public LI_Lineage_Type LI_Lineage {
      get {
        return _li_Lineage;
      }
      set {
        if (_li_Lineage == value) {
          return;
        }
        if (_li_Lineage == null || _li_Lineage.Equals(value) != true) {
          _li_Lineage = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}