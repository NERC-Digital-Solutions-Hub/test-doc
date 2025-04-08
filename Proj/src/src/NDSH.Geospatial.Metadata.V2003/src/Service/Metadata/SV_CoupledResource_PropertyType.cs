
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 14/01/2023, 02:47, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Service.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Service.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_CoupledResource_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_CoupledResource_PropertyType")]
  public class SV_CoupledResource_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_CoupledResource_PropertyType"/>.
    /// </summary>
    public SV_CoupledResource_PropertyType() {
      _sv_CoupledResource = new SV_CoupledResource_Type();
    }

    #endregion

    #region Public Properties

    private SV_CoupledResource_Type _sv_CoupledResource;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_CoupledResource", Order = 0)]
    [JsonProperty("SV_CoupledResource", Order = 0)]
    public SV_CoupledResource_Type SV_CoupledResource {
      get {
        return _sv_CoupledResource;
      }
      set {
        if (_sv_CoupledResource == value) {
          return;
        }
        if (_sv_CoupledResource == null || _sv_CoupledResource.Equals(value) != true) {
          _sv_CoupledResource = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
