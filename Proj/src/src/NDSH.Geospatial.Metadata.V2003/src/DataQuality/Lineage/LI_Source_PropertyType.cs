
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 17:10, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.DataQuality.Lineage {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LI_Source_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("LI_Source_PropertyType")]
  public class LI_Source_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_Source_PropertyType"/>.
    /// </summary>
    public LI_Source_PropertyType() {
      _li_Source  = default; //  new LI_Source_Type();
    }

    #endregion

    #region Public Properties

    private LI_Source_Type _li_Source;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LI_Source", Order = 0)]
    [JsonProperty("LI_Source", Order = 0)]
    public LI_Source_Type LI_Source {
      get {
        return _li_Source;
      }
      set {
        if (_li_Source == value) {
          return;
        }
        if (_li_Source == null || _li_Source.Equals(value) != true) {
          _li_Source = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}