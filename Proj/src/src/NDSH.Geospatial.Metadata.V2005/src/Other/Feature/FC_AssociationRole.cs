
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
//  public partial class FC_AssociationRole {

//    private LocalName memberNameField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public LocalName memberName {
//      get {
//        return memberNameField;
//      }
//      set {
//        memberNameField = value;
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

//    private Multiplicity cardinalityField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public Multiplicity cardinality {
//      get {
//        return cardinalityField;
//      }
//      set {
//        cardinalityField = value;
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

//    private FC_RoleType typeField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public FC_RoleType type {
//      get {
//        return typeField;
//      }
//      set {
//        typeField = value;
//      }
//    }

//    private AA.Metadata.ConceptualSchema.Primitive.Truth.Boolean isOrderedField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public AA.Metadata.ConceptualSchema.Primitive.Truth.Boolean isOrdered {
//      get {
//        return isOrderedField;
//      }
//      set {
//        isOrderedField = value;
//      }
//    }

//    private AA.Metadata.ConceptualSchema.Primitive.Truth.Boolean isNavigableField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public AA.Metadata.ConceptualSchema.Primitive.Truth.Boolean isNavigable {
//      get {
//        return isNavigableField;
//      }
//      set {
//        isNavigableField = value;
//      }
//    }

//    private FC_FeatureAssociation relationField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public FC_FeatureAssociation relation {
//      get {
//        return relationField;
//      }
//      set {
//        relationField = value;
//      }
//    }

//    private FC_FeatureType valueTypeField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public FC_FeatureType valueType {
//      get {
//        return valueTypeField;
//      }
//      set {
//        valueTypeField = value;
//      }
//    }

//    private PF_PortrayalRule[] ruleField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("rule")]
//    public PF_PortrayalRule[] rule {
//      get {
//        return ruleField;
//      }
//      set {
//        ruleField = value;
//      }
//    }


//  }

//}
