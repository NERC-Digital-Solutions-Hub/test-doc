
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
//  public partial class FC_FeatureAttribute {

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

//    private UnitOfMeasure valueMeasurementUnitField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public UnitOfMeasure valueMeasurementUnit {
//      get {
//        return valueMeasurementUnitField;
//      }
//      set {
//        valueMeasurementUnitField = value;
//      }
//    }

//    private FC_ListedValue[] listedValueField;

//    /// <summary>
//    /// 
//    /// </summary>
//    [System.Xml.Serialization.XmlElementAttribute("listedValue")]
//    public FC_ListedValue[] listedValue {
//      get {
//        return listedValueField;
//      }
//      set {
//        listedValueField = value;
//      }
//    }

//    private TypeName valueTypeField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public TypeName valueType {
//      get {
//        return valueTypeField;
//      }
//      set {
//        valueTypeField = value;
//      }
//    }

//  }

//}
