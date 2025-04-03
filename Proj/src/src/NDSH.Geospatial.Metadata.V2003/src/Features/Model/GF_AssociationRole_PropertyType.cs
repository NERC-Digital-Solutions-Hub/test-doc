
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 12:31, @fdq09eca.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


#endregion

namespace NDSH.Geospatial.Metadata.V2003.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("GF_AssociationRole_PropertyType")] // TODO: we do not know what is the namespace of it
  [JsonObject("GF_AssociationRole_PropertyType")]
  public class GF_AssociationRole_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="GF_AssociationRole_PropertyType"/>.
    /// </summary>
    public GF_AssociationRole_PropertyType() {
      _gf_associationrole  = default; //  new GF_AssociationRole();
    }

    #endregion

    #region Public Properties

    private GF_AssociationRole _gf_associationrole;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("GF_AssociationRole", Order = 0)]
    [JsonProperty("GF_AssociationRole", Order = 0)]
    public GF_AssociationRole GF_AssociationRole {
      get {
        return _gf_associationrole;
      }
      set {
        if (_gf_associationrole == value) {
          return;
        }
        if (_gf_associationrole == null || _gf_associationrole.Equals(value) != true) {
          _gf_associationrole = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}