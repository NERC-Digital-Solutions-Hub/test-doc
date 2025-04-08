
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

//namespace AA.Metadata.Feature {

//  /// <remarks/>
//  [System.SerializableAttribute()]
//  [System.Diagnostics.DebuggerStepThroughAttribute()]
//  [System.ComponentModel.DesignerCategory("code")]
//  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=false)]
//  [System.Xml.Serialization.XmlRoot(Namespace="", IsNullable=false)]
//  public partial class FC_FeatureAssociation {

//    private LocalName typeNameField;

//    /// <summary>
//    /// 
//    /// </summary>
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

//    private string codeField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public string code {
//      get {
//        return codeField;
//      }
//      set {
//        codeField = value;
//      }
//    }

//    private AA.Metadata.ConceptualSchema.Primitive.Truth.Boolean isAbstractField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public AA.Metadata.ConceptualSchema.Primitive.Truth.Boolean isAbstract {
//      get {
//        return isAbstractField;
//      }
//      set {
//        isAbstractField = value;
//      }
//    }

//    private LocalName[] aliasesField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("aliases")]
//    public LocalName[] aliases {
//      get {
//        return aliasesField;
//      }
//      set {
//        aliasesField = value;
//      }
//    }

//    private FC_InheritanceRelation[] inheritsFromField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("inheritsFrom")]
//    public FC_InheritanceRelation[] inheritsFrom {
//      get {
//        return inheritsFromField;
//      }
//      set {
//        inheritsFromField = value;
//      }
//    }

//    private FC_InheritanceRelation[] inheritsToField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("inheritsTo")]
//    public FC_InheritanceRelation[] inheritsTo {
//      get {
//        return inheritsToField;
//      }
//      set {
//        inheritsToField = value;
//      }
//    }

//    private FC_FeatureCatalogue featureCatalogueField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public FC_FeatureCatalogue featureCatalogue {
//      get {
//        return featureCatalogueField;
//      }
//      set {
//        featureCatalogueField = value;
//      }
//    }

//    private FC_PropertyType[] carrierOfCharacteristicsField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("carrierOfCharacteristics")]
//    public FC_PropertyType[] carrierOfCharacteristics {
//      get {
//        return carrierOfCharacteristicsField;
//      }
//      set {
//        carrierOfCharacteristicsField = value;
//      }
//    }

//    private FC_AssociationRole[] roleField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("role")]
//    public FC_AssociationRole[] role {
//      get {
//        return roleField;
//      }
//      set {
//        roleField = value;
//      }
//    }

//  }

//}
