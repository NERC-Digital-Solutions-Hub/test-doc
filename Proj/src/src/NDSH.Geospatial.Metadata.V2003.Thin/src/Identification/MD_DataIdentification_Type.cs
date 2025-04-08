
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 02:27, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_DataIdentification", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_DataIdentification", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_DataIdentification")]
  public class MD_DataIdentification_Type : AbstractMD_Identification_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DataIdentification_Type"/>.
    /// </summary>
    public MD_DataIdentification_Type() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _spatialRepresentationType  = default; //  new List<MD_SpatialRepresentationTypeCode_PropertyType>();
      _spatialResolution  = default; //  new List<MD_Resolution_PropertyType>();
      _language  = default; //  new List<CharacterString_PropertyType>();
      _characterSet  = default; //  new List<MD_CharacterSetCode_PropertyType>();
      _topicCategory  = default; //  new List<MD_TopicCategoryCode_PropertyType>();
      _environmentDescription  = default; //  new CharacterString_PropertyType();
      _extent  = default; //  new List<EX_Extent_PropertyType>();
      _supplementalInformation  = default; //  new CharacterString_PropertyType();

    }

    #endregion

    #region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<MD_SpatialRepresentationTypeCode_PropertyType> _spatialRepresentationType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("spatialRepresentationType", Order = 0)]
    [JsonProperty("spatialRepresentationType", Order = 0)]
    public List<MD_SpatialRepresentationTypeCode_PropertyType> SpatialRepresentationType {
      get {
        return _spatialRepresentationType;
      }
      set {
        if (_spatialRepresentationType == value) {
          return;
        }
        if (_spatialRepresentationType == null || _spatialRepresentationType.Equals(value) != true) {
          _spatialRepresentationType = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_Resolution_PropertyType> _spatialResolution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("spatialResolution", Order = 1)]
    [JsonProperty("spatialResolution", Order = 1)]
    public List<MD_Resolution_PropertyType> SpatialResolution {
      get {
        return _spatialResolution;
      }
      set {
        if (_spatialResolution == value) {
          return;
        }
        if (_spatialResolution == null || _spatialResolution.Equals(value) != true) {
          _spatialResolution = value;
          OnPropertyChanged();
        }
      }
    }

        private List<CharacterString> _language;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("language", Order = 2)]
    [JsonProperty("language", Order = 2)]
    public List<CharacterString> Language {
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

        private List<MD_CharacterSetCode_PropertyType> _characterSet;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("characterSet", Order = 3)]
    [JsonProperty("characterSet", Order = 3)]
    public List<MD_CharacterSetCode_PropertyType> CharacterSet {
      get {
        return _characterSet;
      }
      set {
        if (_characterSet == value) {
          return;
        }
        if (_characterSet == null || _characterSet.Equals(value) != true) {
          _characterSet = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_TopicCategoryCode_PropertyType> _topicCategory;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("topicCategory", Order = 4)]
    [JsonProperty("topicCategory", Order = 4)]
    public List<MD_TopicCategoryCode_PropertyType> TopicCategory {
      get {
        return _topicCategory;
      }
      set {
        if (_topicCategory == value) {
          return;
        }
        if (_topicCategory == null || _topicCategory.Equals(value) != true) {
          _topicCategory = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _environmentDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("environmentDescription", Order = 5)]
    [JsonProperty("environmentDescription", Order = 5)]
    public CharacterString EnvironmentDescription {
      get {
        return _environmentDescription;
      }
      set {
        if (_environmentDescription == value) {
          return;
        }
        if (_environmentDescription == null || _environmentDescription.Equals(value) != true) {
          _environmentDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private List<EX_Extent_PropertyType> _extent;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("extent", Order = 6)]
    [JsonProperty("extent", Order = 6)]
    public List<EX_Extent_PropertyType> Extent {
      get {
        return _extent;
      }
      set {
        if (_extent == value) {
          return;
        }
        if (_extent == null || _extent.Equals(value) != true) {
          _extent = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _supplementalInformation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("supplementalInformation", Order = 7)]
    [JsonProperty("supplementalInformation", Order = 7)]
    public CharacterString SupplementalInformation {
      get {
        return _supplementalInformation;
      }
      set {
        if (_supplementalInformation == value) {
          return;
        }
        if (_supplementalInformation == null || _supplementalInformation.Equals(value) != true) {
          _supplementalInformation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
