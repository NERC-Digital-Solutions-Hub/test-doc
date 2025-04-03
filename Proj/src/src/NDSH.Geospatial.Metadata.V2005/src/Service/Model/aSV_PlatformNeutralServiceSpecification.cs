
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

//namespace AA.Metadata.Package.Service.Model {

//  /// <remarks/>
//  [System.SerializableAttribute()]
//  [System.Diagnostics.DebuggerStepThroughAttribute()]
//  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=false)]
//  [System.Xml.Serialization.XmlRoot(Namespace="", IsNullable=false)]
//  public partial class SV_PlatformNeutralServiceSpecification {

//    private string nameField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public string name {
//      get {
//        return this.nameField;
//      }
//      set {
//        this.nameField = value;
//      }
//    }

//    private SV_OperationModel opModelField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public SV_OperationModel opModel {
//      get {
//        return this.opModelField;
//      }
//      set {
//        this.opModelField = value;
//      }
//    }

//    private SV_ServiceType serviceTypeField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public SV_ServiceType ServiceType {
//      get {
//        return this.serviceTypeField;
//      }
//      set {
//        this.serviceTypeField = value;
//      }
//    }

//    private SV_ServiceSpecification abstSpecField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public SV_ServiceSpecification abstSpec {
//      get {
//        return abstSpecField;
//      }
//      set {
//        abstSpecField = value;
//      }
//    }

//    private SV_PlatformSpecificServiceSpecification implSpecField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public SV_PlatformSpecificServiceSpecification implSpec {
//      get {
//        return implSpecField;
//      }
//      set {
//        implSpecField = value;
//      }
//    }

//    private SV_IntelligentUser providesValueToField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public SV_IntelligentUser providesValueTo {
//      get {
//        return providesValueToField;
//      }
//      set {
//        providesValueToField = value;
//      }
//    }

//    private SV_InterfaceSpecification utilizesASetOfField;

//    /// <summary>
//    /// 
//    /// </summary>
//    public SV_InterfaceSpecification utilizesASetOf {
//      get {
//        return utilizesASetOfField;
//      }
//      set {
//        utilizesASetOfField = value;
//      }
//    }

//  }

//}
