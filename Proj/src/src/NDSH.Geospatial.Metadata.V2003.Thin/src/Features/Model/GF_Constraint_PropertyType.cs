
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 14:35, @fdq09eca.
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
  [XmlType("GF_Constraint_PropertyType")] // TODO: we do not know what is the namespace of it
  [JsonObject("GF_Constraint_PropertyType")]
  public class GF_Constraint_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_Constraint_PropertyType"/>.
    /// </summary>
    public GF_Constraint_PropertyType() {
      _gf_constraint  = default; //  new GF_Constraint();
    }

    #endregion

    #region Public Properties

    private GF_Constraint _gf_constraint;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("GF_Constraint", Order = 0)]
    [JsonProperty("GF_Constraint", Order = 0)]
    public GF_Constraint GF_Constraint {
      get {
        return _gf_constraint;
      }
      set {
        if (_gf_constraint == value) {
          return;
        }
        if (_gf_constraint == null || _gf_constraint.Equals(value) != true) {
          _gf_constraint = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}