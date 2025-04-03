
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 14:53, @fdq09eca.
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
  [XmlType("GF_InheritanceRelation_PropertyType")] // TODO: we do not know what is the namespace of it
  [JsonObject("GF_InheritanceRelation_PropertyType")]
  public class GF_InheritanceRelation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_InheritanceRelation_PropertyType"/>.
    /// </summary>
    public GF_InheritanceRelation_PropertyType() {
      _gf_inheritancerelation  = default; //  new GF_InheritanceRelation();
    }

    #endregion

    #region Public Properties

    private GF_InheritanceRelation _gf_inheritancerelation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("GF_InheritanceRelation", Order = 0)]
    [JsonProperty("GF_InheritanceRelation", Order = 0)]
    public GF_InheritanceRelation GF_InheritanceRelation {
      get {
        return _gf_inheritancerelation;
      }
      set {
        if (_gf_inheritancerelation == value) {
          return;
        }
        if (_gf_inheritancerelation == null || _gf_inheritancerelation.Equals(value) != true) {
          _gf_inheritancerelation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}