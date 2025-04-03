
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 18:22, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_Catalogue_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_Catalogue_PropertyType")]
  public class CT_Catalogue_PropertyType : ObjectReference_PropertyType {
    
    #region Public Properties

    private AbstractCT_Catalogue_Type _abstractCT_Catalogue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractCT_Catalogue", Order = 0)]
    [JsonProperty("AbstractCT_Catalogue", Order = 0)]
    public AbstractCT_Catalogue_Type AbstractCT_Catalogue {
      get {
        return _abstractCT_Catalogue;
      }
      set {
        if (_abstractCT_Catalogue == value) {
          return;
        }
        if (_abstractCT_Catalogue == null || _abstractCT_Catalogue.Equals(value) != true) {
          _abstractCT_Catalogue = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
