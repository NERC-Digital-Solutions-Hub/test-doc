
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 11/01/2023, 02:23, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_Interface_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_Interface_PropertyType")]
  public class SV_Interface_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_Interface_PropertyType"/>.
    /// </summary>
    public SV_Interface_PropertyType() {
      _sv_Interface = new SV_Interface_Type();
    }

    #endregion

    #region Public Properties

    private SV_Interface_Type _sv_Interface;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_Interface", Order = 0)]
    [JsonProperty("SV_Interface", Order = 0)]
    public SV_Interface_Type SV_Interface {
      get {
        return _sv_Interface;
      }
      set {
        if (_sv_Interface == value) {
          return;
        }
        if (_sv_Interface == null || _sv_Interface.Equals(value) != true) {
          _sv_Interface = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
