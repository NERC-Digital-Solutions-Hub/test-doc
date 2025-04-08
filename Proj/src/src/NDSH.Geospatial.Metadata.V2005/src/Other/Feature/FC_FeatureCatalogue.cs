
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
//  public partial class FC_FeatureCatalogue {

//    private string nameField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public string name {
//      get {
//        return nameField;
//      }
//      set {
//        nameField = value;
//      }
//    }

//    private string[] scopeField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("scope")]
//    public string[] scope {
//      get {
//        return scopeField;
//      }
//      set {
//        scopeField = value;
//      }
//    }

//    private string[] fieldOfApplicationField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("fieldOfApplication")]
//    public string[] fieldOfApplication {
//      get {
//        return fieldOfApplicationField;
//      }
//      set {
//        fieldOfApplicationField = value;
//      }
//    }

//    private string versionNumberField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public string versionNumber {
//      get {
//        return versionNumberField;
//      }
//      set {
//        versionNumberField = value;
//      }
//    }

//    private DateTime versionDateField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public DateTime versionDate {
//      get {
//        return versionDateField;
//      }
//      set {
//        versionDateField = value;
//      }
//    }

//    private CI_Citation producerField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public CI_Citation producer {
//      get {
//        return producerField;
//      }
//      set {
//        producerField = value;
//      }
//    }

//    private string functionalLanguageField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public string functionalLanguage {
//      get {
//        return functionalLanguageField;
//      }
//      set {
//        functionalLanguageField = value;
//      }
//    }

//    private FC_FeatureType[] featureTypeField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("featureType")]
//    public FC_FeatureType[] featureType {
//      get {
//        return featureTypeField;
//      }
//      set {
//        featureTypeField = value;
//      }
//    }

//    private FC_DefinitionSource[] definitionSourceField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("definitionSource")]
//    public FC_DefinitionSource[] definitionSource {
//      get {
//        return definitionSourceField;
//      }
//      set {
//        definitionSourceField = value;
//      }
//    }

//    private FC_Constraint[] constrainedByField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("constrainedBy")]
//    public FC_Constraint[] constrainedBy {
//      get {
//        return constrainedByField;
//      }
//      set {
//        constrainedByField = value;
//      }
//    }

//    private FC_DefinitionReference definitionReferenceField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public FC_DefinitionReference definitionReference {
//      get {
//        return definitionReferenceField;
//      }
//      set {
//        definitionReferenceField = value;
//      }
//    }

//  }

//}
