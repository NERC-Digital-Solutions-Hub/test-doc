
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

using NDSH.Geospatial.Metadata.V2005.Common.Citation;
using NDSH.Geospatial.Metadata.V2005.Common.Extent;
using NDSH.Geospatial.Metadata.V2005.Identification;
using NDSH.Geospatial.Metadata.V2005.ReferenceSystem;
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

namespace NDSH.Geospatial.Metadata.V2005.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [DebuggerStepThrough]
  [XmlRoot(Namespace = "", IsNullable = false)]
  [JsonObject("LI_Source")]
  public class LI_Source : EntityBase<LI_Source> {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_Source"/>.
    /// </summary>
    public LI_Source() {
      _sourceStep = new List<LI_ProcessStep>();
      _sourceExtent = new List<EX_Extent>();
      _sourceCitation = new CI_Citation();
      _sourceReferenceSystem = new Parent_MD_ReferenceSystem();
      _scaleDenominator = new MD_RepresentativeFraction();
    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private string _description;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "description")]
    [JsonProperty("description", Order = 0)]
    public string Description {
      get {
        return _description;
      }
      set {
        if (_description == value) {
          return;
        }
        if (_description == null || _description.Equals(value) != true) {
          _description = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_RepresentativeFraction _scaleDenominator;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1, ElementName = "scaleDenominator")]
    [JsonProperty("scaleDenominator", Order = 1)]
    public MD_RepresentativeFraction ScaleDenominator {
      get {
        return _scaleDenominator;
      }
      set {
        if (_scaleDenominator == value) {
          return;
        }
        if (_scaleDenominator == null || _scaleDenominator.Equals(value) != true) {
          _scaleDenominator = value;
          OnPropertyChanged();
        }
      }
    }

    private Parent_MD_ReferenceSystem _sourceReferenceSystem;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2, ElementName = "sourceReferenceSystem")]
    [JsonProperty("sourceReferenceSystem", Order = 2)]
    public Parent_MD_ReferenceSystem SourceReferenceSystem {
      get {
        return _sourceReferenceSystem;
      }
      set {
        if (_sourceReferenceSystem == value) {
          return;
        }
        if (_sourceReferenceSystem == null || _sourceReferenceSystem.Equals(value) != true) {
          _sourceReferenceSystem = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_Citation _sourceCitation;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3, ElementName = "sourceCitation")]
    [JsonProperty("sourceCitation", Order = 3)]
    public CI_Citation SourceCitation {
      get {
        return _sourceCitation;
      }
      set {
        if (_sourceCitation == value) {
          return;
        }
        if (_sourceCitation == null || _sourceCitation.Equals(value) != true) {
          _sourceCitation = value;
          OnPropertyChanged();
        }
      }
    }

    private List<EX_Extent> _sourceExtent;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sourceExtent", Order = 4, ElementName = "sourceExtent")]
    [JsonProperty("sourceExtent", Order = 4)]
    public List<EX_Extent> SourceExtent {
      get {
        return _sourceExtent;
      }
      set {
        if (_sourceExtent == value) {
          return;
        }
        if (_sourceExtent == null || _sourceExtent.Equals(value) != true) {
          _sourceExtent = value;
          OnPropertyChanged();
        }
      }
    }

    private List<LI_ProcessStep> _sourceStep;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sourceStep", Order = 5, ElementName = "sourceStep")]
    [JsonProperty("sourceStep", Order = 5)]
    public List<LI_ProcessStep> SourceStep {
      get {
        return _sourceStep;
      }
      set {
        if (_sourceStep == value) {
          return;
        }
        if (_sourceStep == null || _sourceStep.Equals(value) != true) {
          _sourceStep = value;
          OnPropertyChanged();
        }
      }
    }

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "ID", AttributeName = "id")]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "uuid")]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
