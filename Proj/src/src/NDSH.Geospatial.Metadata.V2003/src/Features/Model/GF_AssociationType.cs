
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 19:35, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable()]
  [XmlType(AnonymousType = false)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_AssociationType : GF_FeatureType {

    #region Public Properties


    private List<GF_AssociationRole_PropertyType> _roleName;
    /// <summary>
    /// 
    /// </summary>
    public List<GF_AssociationRole_PropertyType> RoleName { // TODO: not sure if this should be here.
      get {
        return _roleName;
      }
      set {
        _roleName = value;
      }
    }

    //private GF_FeatureType[] includesField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("includesField")]
    //public GF_FeatureType[] includes {
    //  get {
    //    return includesField;
    //  }
    //  set {
    //    includesField = value;
    //  }
    //}

    //private GF_AssociationRole[] roleNameField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("roleName")]
    //public GF_AssociationRole[] roleName {
    //  get {
    //    return roleNameField;
    //  }
    //  set {
    //    roleNameField = value;
    //  }
    //}

    //private GF_Constraint[] constrainedByField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("constrainedBy")]
    //public GF_Constraint[] constrainedBy {
    //  get {
    //    return constrainedByField;
    //  }
    //  set {
    //    constrainedByField = value;
    //  }
    //}

    //private GF_PropertyType[] carrierOfCharacteristicsField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("carrierOfCharacteristics")]
    //public GF_PropertyType[] carrierOfCharacteristics {
    //  get {
    //    return carrierOfCharacteristicsField;
    //  }
    //  set {
    //    carrierOfCharacteristicsField = value;
    //  }
    //}

    #endregion

    //private MD_Metadata featureTypeMetadataField;

    ///// <summary>
    ///// 
    ///// </summary>
    //public MD_Metadata featureTypeMetadata {
    //  get {
    //    return featureTypeMetadataField;
    //  }
    //  set {
    //    featureTypeMetadataField = value;
    //  }
    //}

    //private PF_FeaturePortrayal[] ruleSetField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("ruleSet")]
    //public PF_FeaturePortrayal[] ruleSet {
    //  get {
    //    return ruleSetField;
    //  }
    //  set {
    //    ruleSetField = value;
    //  }
    //}

  }

}
