
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 14/01/2023, 03:11, @gisvlasta.
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
  [XmlType("SV_OperationChain_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_OperationChain_PropertyType")]
  public class SV_OperationChain_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationChain_PropertyType"/>.
    /// </summary>
    public SV_OperationChain_PropertyType() {
      _sv_OperationChain = new SV_OperationChain_Type();
    }

    #endregion

    #region Public Properties

    private SV_OperationChain_Type _sv_OperationChain;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_CoupledResource", Order = 0)]
    [JsonProperty("SV_CoupledResource", Order = 0)]
    public SV_OperationChain_Type SV_OperationChain {
      get {
        return _sv_OperationChain;
      }
      set {
        if (_sv_OperationChain == value) {
          return;
        }
        if (_sv_OperationChain == null || _sv_OperationChain.Equals(value) != true) {
          _sv_OperationChain = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
