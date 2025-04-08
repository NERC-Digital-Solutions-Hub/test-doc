
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
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


//namespace NDSH.Geospatial.Metadata.V2005.Other.Feature.Model {

//  /// <summary>
//  /// 
//  /// </summary>
//  [System.SerializableAttribute()]
//  [System.Diagnostics.DebuggerStepThroughAttribute()]
//  [System.ComponentModel.DesignerCategory("code")]
//  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=false)]
//  [System.Xml.Serialization.XmlRoot(Namespace="", IsNullable=false)]
//  public partial class GF_FeatureType {

//    private LocalName typeNameField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:AA:Metadata:ConceptualSchema:Implementation:Names")]
//    public LocalName typeName {
//      get {
//        return typeNameField;
//      }
//      set {
//        typeNameField = value;
//      }
//    }

//    private string definitionField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public string definition {
//      get {
//        return definitionField;
//      }
//      set {
//        definitionField = value;
//      }
//    }

//    private AA.Metadata.ConceptualSchema.Primitive.Truth.Boolean isAbstractField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:AA:Metadata:ConceptualSchema:Primitive:Truth")]
//    public AA.Metadata.ConceptualSchema.Primitive.Truth.Boolean isAbstract {
//      get {
//        return isAbstractField;
//      }
//      set {
//        isAbstractField = value;
//      }
//    }

//    private GF_Constraint[] constrainedByField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("constrainedBy")]
//    public GF_Constraint[] constrainedBy {
//      get {
//        return constrainedByField;
//      }
//      set {
//        constrainedByField = value;
//      }
//    }

//    private GF_AssociationType[] linkBetweenField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("linkBetween")]
//    public GF_AssociationType[] linkBetween {
//      get {
//        return linkBetweenField;
//      }
//      set {
//        linkBetweenField = value;
//      }
//    }

//    private GF_PropertyType[] carrierOfCharacteristicsField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("carrierOfCharacteristics")]
//    public GF_PropertyType[] carrierOfCharacteristics {
//      get {
//        return carrierOfCharacteristicsField;
//      }
//      set {
//        carrierOfCharacteristicsField = value;
//      }
//    }

//    //private MD_Metadata featureTypeMetadataField;

//    ///// <summary>
//    ///// 
//    ///// </summary>
//    //[System.Xml.Serialization.XmlElementAttribute("featureTypeMetadata")]
//    //public MD_Metadata featureTypeMetadata {
//    //  get {
//    //    return featureTypeMetadataField;
//    //  }
//    //  set {
//    //    featureTypeMetadataField = value;
//    //  }
//    //}

//    //private PF_FeaturePortrayal[] ruleSetField;

//    ///// <summary>
//    ///// 
//    ///// </summary>
//    //[System.Xml.Serialization.XmlElementAttribute("ruleSet")]
//    //public PF_FeaturePortrayal[] ruleSet {
//    //  get {
//    //    return ruleSetField;
//    //  }
//    //  set {
//    //    ruleSetField = value;
//    //  }
//    //}

//  }

//}
