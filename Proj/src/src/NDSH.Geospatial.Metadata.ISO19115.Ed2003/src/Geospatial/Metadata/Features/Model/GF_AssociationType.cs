
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 03/01/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
// XSD               : 
// ---------------------------------------------------------------------------------------------------------------------
//
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  [Serializable()]
  //[XmlType(AnonymousType = false)]
  //[XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_AssociationType : GF_FeatureType {

    #region Public Properties


    private List<GF_AssociationRole> _roleName;

    public List<GF_AssociationRole> RoleName { // TODO: not sure if this should be here.
      get => _roleName;
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
