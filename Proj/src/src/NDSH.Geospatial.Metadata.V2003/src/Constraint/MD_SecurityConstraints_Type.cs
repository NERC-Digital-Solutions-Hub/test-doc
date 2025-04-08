
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 02:01, @gisvlasta.
// Updated by        : 09/01/2023, 18:18, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Constraint {

  /// <summary>
  /// Handling restrictions imposed on the dataset because of national security, privacy, or other concerns.
  /// </summary>
  [Serializable]
  [XmlType("MD_SecurityConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_SecurityConstraints", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_SecurityConstraints")]
  public class MD_SecurityConstraints_Type : MD_Constraints_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_SecurityConstraints_Type"/>.
    /// </summary>
    public MD_SecurityConstraints_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _classification  = default; //  new MD_ClassificationCode_PropertyType();
      _userNote  = default; //  new CharacterString_PropertyType();
      _classificationSystem  = default; //  new CharacterString_PropertyType();
      _handlingDescription  = default; //  new CharacterString_PropertyType();
      
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

    private MD_ClassificationCode_PropertyType _classification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("classification", Order = 0)]
    [JsonProperty("classification", Order = 0)]
    public MD_ClassificationCode_PropertyType Classification {
      get {
        return _classification;
      }
      set {
        if (_classification == value) {
          return;
        }
        if (_classification == null || _classification.Equals(value) != true) {
          _classification = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _userNote;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("userNote", Order = 1)]
    [JsonProperty("userNote", Order = 1)]
    public CharacterString_PropertyType UserNote {
      get {
        return _userNote;
      }
      set {
        if (_userNote == value) {
          return;
        }
        if (_userNote == null || _userNote.Equals(value) != true) {
          _userNote = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _classificationSystem;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("classificationSystem", Order = 2)]
    [JsonProperty("classificationSystem", Order = 2)]
    public CharacterString_PropertyType ClassificationSystem {
      get {
        return _classificationSystem;
      }
      set {
        if (_classificationSystem == value) {
          return;
        }
        if (_classificationSystem == null || _classificationSystem.Equals(value) != true) {
          _classificationSystem = value;
          OnPropertyChanged("classificationSystem");
        }
      }
    }

    private CharacterString_PropertyType _handlingDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("handlingDescription", Order = 3)]
    [JsonProperty("handlingDescription", Order = 3)]
    public CharacterString_PropertyType HandlingDescription {
      get {
        return _handlingDescription;
      }
      set {
        if (_handlingDescription == value) {
          return;
        }
        if (_handlingDescription == null || _handlingDescription.Equals(value) != true) {
          _handlingDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}