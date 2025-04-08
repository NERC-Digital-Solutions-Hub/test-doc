
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:16, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_FeatureCatalogueDescription_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_FeatureCatalogueDescription_PropertyType")]
  public class MD_FeatureCatalogueDescription_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_FeatureCatalogueDescription_PropertyType"/>.
    /// </summary>
    public MD_FeatureCatalogueDescription_PropertyType() {
      _md_FeatureCatalogueDescription  = default; //  new MD_FeatureCatalogueDescription_Type();
    }

    #endregion

    #region Public Properties

    private MD_FeatureCatalogueDescription_Type _md_FeatureCatalogueDescription;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_FeatureCatalogueDescription", Order = 0)]
    [JsonProperty("MD_FeatureCatalogueDescription", Order = 0)]
    public MD_FeatureCatalogueDescription_Type MD_FeatureCatalogueDescription {
      get {
        return _md_FeatureCatalogueDescription;
      }
      set {
        if (_md_FeatureCatalogueDescription == value) {
          return;
        }
        if (_md_FeatureCatalogueDescription == null || _md_FeatureCatalogueDescription.Equals(value) != true) {
          _md_FeatureCatalogueDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}