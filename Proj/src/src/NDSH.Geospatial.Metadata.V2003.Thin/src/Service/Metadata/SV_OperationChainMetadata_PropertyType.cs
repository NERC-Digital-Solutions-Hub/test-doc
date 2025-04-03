
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 14/01/2023, 03:23, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_OperationChainMetadata_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_OperationChainMetadata_PropertyType")]
  public class SV_OperationChainMetadata_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationChainMetadata_PropertyType"/>.
    /// </summary>
    public SV_OperationChainMetadata_PropertyType() {
      _sv_OperationChainMetadata = new SV_OperationChainMetadata_Type();
    }

    #endregion

    #region Public Properties

    private SV_OperationChainMetadata_Type _sv_OperationChainMetadata;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_CoupledResource", Order = 0)]
    [JsonProperty("SV_CoupledResource", Order = 0)]
    public SV_OperationChainMetadata_Type SV_OperationChainMetadata {
      get {
        return _sv_OperationChainMetadata;
      }
      set {
        if (_sv_OperationChainMetadata == value) {
          return;
        }
        if (_sv_OperationChainMetadata == null || _sv_OperationChainMetadata.Equals(value) != true) {
          _sv_OperationChainMetadata = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
