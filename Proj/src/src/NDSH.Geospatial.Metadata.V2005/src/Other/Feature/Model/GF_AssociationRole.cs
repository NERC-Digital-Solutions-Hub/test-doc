
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


//namespace AA.Metadata.Feature.Model {

//  /// <summary>
//  /// 
//  /// </summary>
//  [System.SerializableAttribute()]
//  [System.Diagnostics.DebuggerStepThroughAttribute()]
//  [System.ComponentModel.DesignerCategory("code")]
//  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=false)]
//  [System.Xml.Serialization.XmlRoot(Namespace="", IsNullable=false)]
//  public partial class GF_AssociationRole {

//    private TypeName valueTypeField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:AA:Metadata:ConceptualSchema:Implementation:Names")]
//    public TypeName valueType {
//      get {
//        return valueTypeField;
//      }
//      set {
//        valueTypeField = value;
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

//    private LocalName memberNameField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:AA:Metadata:ConceptualSchema:Implementation:Names")]
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

//    //private PF_PortrayalRule[] rulefield;

//    ///// <summary>
//    ///// 
//    ///// </summary>
//    //[System.Xml.Serialization.XmlElementAttribute("rule")]
//    //public PF_PortrayalRule[] rule {
//    //  get {
//    //    return rulefield;
//    //  }
//    //  set {
//    //    rulefield = value;
//    //  }
//    //}

//  }

//}
