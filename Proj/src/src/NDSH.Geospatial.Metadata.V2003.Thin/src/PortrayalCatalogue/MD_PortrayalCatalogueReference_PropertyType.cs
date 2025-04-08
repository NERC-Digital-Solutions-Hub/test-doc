
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 17:25, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.PortrayalCatalogue {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_PortrayalCatalogueReference_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_PortrayalCatalogueReference_PropertyType")]
  public class MD_PortrayalCatalogueReference_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_PortrayalCatalogueReference_PropertyType"/>.
    /// </summary>
    public MD_PortrayalCatalogueReference_PropertyType() {
      _md_PortrayalCatalogueReference  = default; //  new MD_PortrayalCatalogueReference_Type();
    }

    #endregion

    #region Public Properties

    private MD_PortrayalCatalogueReference_Type _md_PortrayalCatalogueReference;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_PortrayalCatalogueReference", Order = 0)]
    [JsonProperty("MD_PortrayalCatalogueReference", Order = 0)]
    public MD_PortrayalCatalogueReference_Type MD_PortrayalCatalogueReference {
      get {
        return _md_PortrayalCatalogueReference;
      }
      set {
        if (_md_PortrayalCatalogueReference == value) {
          return;
        }
        if (_md_PortrayalCatalogueReference == null || _md_PortrayalCatalogueReference.Equals(value) != true) {
          _md_PortrayalCatalogueReference = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
