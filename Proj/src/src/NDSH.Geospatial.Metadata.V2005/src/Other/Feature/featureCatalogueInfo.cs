
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
//  public partial class featureCatalogueInfo {

//    private string complianceCodeField;
//    private string[] languageField;
//    private string includedWithDatasetField;
//    private featureTypes[] featureTypesField;
//    private CI_Citation[] featureCatalogueCitationField;
//    private string idrefField;

//    /// <remarks/>
//    public string complianceCode {
//      get {
//        return this.complianceCodeField;
//      }
//      set {
//        this.complianceCodeField = value;
//      }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("language")]
//    public string[] language {
//      get {
//        return this.languageField;
//      }
//      set {
//        this.languageField = value;
//      }
//    }

//    /// <remarks/>
//    public string includedWithDataset {
//      get {
//        return this.includedWithDatasetField;
//      }
//      set {
//        this.includedWithDatasetField = value;
//      }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("featureTypes")]
//    public featureTypes[] featureTypes {
//      get {
//        return this.featureTypesField;
//      }
//      set {
//        this.featureTypesField = value;
//      }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("featureCatalogueCitation")]
//    public CI_Citation[] featureCatalogueCitation {
//      get {
//        return this.featureCatalogueCitationField;
//      }
//      set {
//        this.featureCatalogueCitationField = value;
//      }
//    }

//  }

//}
