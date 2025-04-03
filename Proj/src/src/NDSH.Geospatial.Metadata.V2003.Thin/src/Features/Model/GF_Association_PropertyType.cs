
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 12:46, @fdq09eca.
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
  [XmlType("GF_Association_PropertyType")] // TODO: we do not know what is the namespace of it
  [JsonObject("GF_Association_PropertyType")]
  public class GF_Association_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_Association_PropertyType"/>.
    /// </summary>
    public GF_Association_PropertyType() {
      _gf_association  = default; //  new GF_AssociationType();
    }

    #endregion

    #region Public Properties

    private GF_AssociationType _gf_association;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("GF_Association", Order = 0)]
    [JsonProperty("GF_Association", Order = 0)]
    public GF_AssociationType GF_Association {
      get {
        return _gf_association;
      }
      set {
        if (_gf_association == value) {
          return;
        }
        if (_gf_association == null || _gf_association.Equals(value) != true) {
          _gf_association = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}