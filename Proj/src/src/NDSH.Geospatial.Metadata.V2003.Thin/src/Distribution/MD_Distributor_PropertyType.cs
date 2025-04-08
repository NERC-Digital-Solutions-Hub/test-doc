
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:27, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Distributor_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Distributor_PropertyType")]
  public class MD_Distributor_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Distributor_PropertyType"/>.
    /// </summary>
    public MD_Distributor_PropertyType() {
      _md_Distributor  = default; //  new MD_Distributor_Type();
    }

    #endregion

    #region Public Properties

    private MD_Distributor_Type _md_Distributor;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Distributor", Order = 0)]
    [JsonProperty("MD_Distributor", Order = 0)]
    public MD_Distributor_Type MD_Distributor {
      get {
        return _md_Distributor;
      }
      set {
        if (_md_Distributor == value) {
          return;
        }
        if (_md_Distributor == null || _md_Distributor.Equals(value) != true) {
          _md_Distributor = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}