
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:24, @gisvlasta.
// Updated by        : 09/01/2023, 18:23, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Truth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Content {
  
  /// <summary>
  /// Information identifying the feature catalogue.
  /// </summary>
  [Serializable]
  [XmlType("MD_FeatureCatalogueDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_FeatureCatalogueDescription", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_FeatureCatalogueDescription")]
  public class MD_FeatureCatalogueDescription_Type : AbstractMD_ContentInformation_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_FeatureCatalogueDescription_Type"/>.
    /// </summary>
    public MD_FeatureCatalogueDescription_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _complianceCode  = default; //  new Boolean_PropertyType();
      _language  = default; //  new List<CharacterString_PropertyType>();
      _includedWithDataset  = default; //  new Boolean_PropertyType();
      _featureTypes  = default; //  new List<GenericName_PropertyType>();
      _featureCatalogueCitation  = default; //  new List<CI_Citation_PropertyType>();
      
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

    private Boolean_PropertyType _complianceCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("complianceCode", Order = 0)]
    [JsonProperty("complianceCode", Order = 0)]
    public Boolean_PropertyType ComplianceCode {
      get {
        return _complianceCode;
      }
      set {
        if (_complianceCode == value) {
          return;
        }
        if (_complianceCode == null || _complianceCode.Equals(value) != true) {
          _complianceCode = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString_PropertyType> _language;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("language", Order = 1)]
    [JsonProperty("language", Order = 1)]
    public List<CharacterString_PropertyType> Language {
      get {
        return _language;
      }
      set {
        if (_language == value) {
          return;
        }
        if (_language == null || _language.Equals(value) != true) {
          _language = value;
          OnPropertyChanged();
        }
      }
    }

    private Boolean_PropertyType _includedWithDataset;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("includedWithDataset", Order = 2)]
    [JsonProperty("includedWithDataset", Order = 2)]
    public Boolean_PropertyType IncludedWithDataset {
      get {
        return _includedWithDataset;
      }
      set {
        if (_includedWithDataset == value) {
          return;
        }
        if (_includedWithDataset == null || _includedWithDataset.Equals(value) != true) {
          _includedWithDataset = value;
          OnPropertyChanged();
        }
      }
    }

    private List<GenericName_PropertyType> _featureTypes;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("featureTypes", Order = 3)]
    [JsonProperty("featureTypes", Order = 3)]
    public List<GenericName_PropertyType> FeatureTypes {
      get {
        return _featureTypes;
      }
      set {
        if (_featureTypes == value) {
          return;
        }
        if (_featureTypes == null || _featureTypes.Equals(value) != true) {
          _featureTypes = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_Citation_PropertyType> _featureCatalogueCitation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("featureCatalogueCitation", Order = 4)]
    [JsonProperty("featureCatalogueCitation", Order = 4)]
    public List<CI_Citation_PropertyType> FeatureCatalogueCitation {
      get {
        return _featureCatalogueCitation;
      }
      set {
        if (_featureCatalogueCitation == value) {
          return;
        }
        if (_featureCatalogueCitation == null || _featureCatalogueCitation.Equals(value) != true) {
          _featureCatalogueCitation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}