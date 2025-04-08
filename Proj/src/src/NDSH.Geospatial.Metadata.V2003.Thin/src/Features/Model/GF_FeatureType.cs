
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 19:16, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Truth;
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable()]
  [XmlType(AnonymousType = false)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_FeatureType {

    #region Public Properties

    private LocalName_PropertyType _typeName;

    /// <summary>
    /// 
    /// </summary>
    public LocalName_PropertyType TypeName {
      get {
        return _typeName;
      }
      set {
        _typeName = value;
      }
    }

    private CharacterString _definition;

    /// <summary>
    /// 
    /// </summary>
    public CharacterString Definition {
      get {
        return _definition;
      }
      set {
        _definition = value;
      }
    }

    private Boolean_PropertyType _isAbstract; // TODO: default value is fasle, shouldn't we implement this as well?

    /// <summary>
    /// 
    /// </summary>
    public Boolean_PropertyType IsAbstract { // TODO: Should Boolean_PropertyType be used here or a simple version?
      get {
        return _isAbstract;
      }
      set {
        _isAbstract = value;
      }
    }

    private List<GF_Constraint_PropertyType> _constrainedBy;
    
    /// <summary>
    /// 
    /// </summary>
    public List<GF_Constraint_PropertyType> ConstrainedBy {
      get {
        return _constrainedBy;
      }
      set {
        _constrainedBy = value;
      }
    }

    private List<GF_Association_PropertyType> _linkBetween;
    
    /// <summary>
    /// 
    /// </summary>
    public List<GF_Association_PropertyType> LinkBetween {
      get {
        return _linkBetween;
      }
      set {
        _linkBetween = value;
      }
    }


    
    private List<GF_Property_PropertyType> _carrierOfCharacteristics;
    
    /// <summary>
    /// 
    /// </summary>
    public List<GF_Property_PropertyType> CarrierOfCharacteristics {
      get {
        return _carrierOfCharacteristics;
      }
      set {
        _carrierOfCharacteristics = value;
      }
    }
    
    #endregion


    //private GF_AssociationType[] linkBetweenField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("linkBetween")]
    //public GF_AssociationType[] linkBetween {
    //  get {
    //    return linkBetweenField;
    //  }
    //  set {
    //    linkBetweenField = value;
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

    //private MD_Metadata featureTypeMetadataField;

    ///// <summary>
    ///// 
    ///// </summary>
    //[System.Xml.Serialization.XmlElementAttribute("featureTypeMetadata")]
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
