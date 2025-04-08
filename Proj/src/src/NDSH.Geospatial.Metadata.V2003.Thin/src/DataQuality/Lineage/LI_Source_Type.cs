
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 17:10, @gisvlasta.
// Updated by        : 09/01/2023, 18:51, @gisvlasta. - 1.0.1: Added xmlns field.
//                   : 08/02/2023, 01:26, @gisvlasta. - 1.0.2: Added [XmlInclude]s.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Thin.Identification;
using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Lineage {

  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(LE_Source_Type))]
  [Serializable]
  [XmlType("LI_Source", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("LI_Source", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("LI_Source")]
  public class LI_Source_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_Source_Type"/>.
    /// </summary>
    public LI_Source_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _description  = default; //  new CharacterString_PropertyType();
      _scaleDenominator  = default; //  new MD_RepresentativeFraction_PropertyType();
      _sourceReferenceSystem  = default; //  new MD_ReferenceSystem_PropertyType();
      _sourceCitation  = default; //  new CI_Citation_PropertyType();
      _sourceExtent  = default; //  new List<EX_Extent_PropertyType>();
      _sourceStep  = default; //  new List<LI_ProcessStep_PropertyType>();

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

    private CharacterString _description;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description", Order = 0)]
    [JsonProperty("description", Order = 0)]
    public CharacterString Description {
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

    private MD_RepresentativeFraction_PropertyType _scaleDenominator;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("scaleDenominator", Order = 1)]
    [JsonProperty("scaleDenominator", Order = 1)]
    public MD_RepresentativeFraction_PropertyType ScaleDenominator {
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

    private MD_ReferenceSystem_PropertyType _sourceReferenceSystem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sourceReferenceSystem", Order = 2)]
    [JsonProperty("sourceReferenceSystem", Order = 2)]
    public MD_ReferenceSystem_PropertyType SourceReferenceSystem {
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

    private CI_Citation_PropertyType _sourceCitation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sourceCitation", Order = 3)]
    [JsonProperty("sourceCitation", Order = 3)]
    public CI_Citation_PropertyType SourceCitation {
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

    private List<EX_Extent_PropertyType> _sourceExtent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sourceExtent", Order = 4)]
    [JsonProperty("sourceExtent", Order = 4)]
    public List<EX_Extent_PropertyType> SourceExtent {
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

    private List<LI_ProcessStep_PropertyType> _sourceStep;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("sourceStep", Order = 5)]
    [JsonProperty("sourceStep", Order = 5)]
    public List<LI_ProcessStep_PropertyType> SourceStep {
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

    #endregion

  }

}