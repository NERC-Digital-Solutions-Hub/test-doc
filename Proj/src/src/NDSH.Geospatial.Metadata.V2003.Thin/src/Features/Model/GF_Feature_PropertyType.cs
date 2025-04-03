
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 14:57, @fdq09eca.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("GF_Feature_PropertyType")] // TODO: we do not know what is the namespace of it
  [JsonObject("GF_Feature_PropertyType")]
  public class GF_Feature_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_Feature_PropertyType"/>.
    /// </summary>
    public GF_Feature_PropertyType() {
      _gf_feature  = default; //  new GF_FeatureType();
    }

    #endregion

    #region Public Properties

    private GF_FeatureType _gf_feature;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("GF_Feature", Order = 0)]
    [JsonProperty("GF_Feature", Order = 0)]
    public GF_FeatureType GF_Feature {
      get {
        return _gf_feature;
      }
      set {
        if (_gf_feature == value) {
          return;
        }
        if (_gf_feature == null || _gf_feature.Equals(value) != true) {
          _gf_feature = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}