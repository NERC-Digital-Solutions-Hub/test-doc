
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 02:05, @gisvlasta.
// Updated by        : 09/01/2023, 19:37, @gisvlasta. - 1.0.1: Added xmlns field.
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
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Common;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Identification {

  /// <summary>
  /// Graphic that provides an illustration of the dataset (should include a legend for the graphic).
  /// </summary>
  [Serializable]
  [XmlType("MD_BrowseGraphic", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_BrowseGraphic", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_BrowseGraphic")]
  public class MD_BrowseGraphic_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_BrowseGraphic_Type"/>.
    /// </summary>
    public MD_BrowseGraphic_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _fileName  = default; //  new CharacterString_PropertyType();
      _fileDescription  = default; //  new CharacterString_PropertyType();
      _fileType  = default; //  new CharacterString_PropertyType();

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

    private CharacterString_PropertyType _fileName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileName", Order = 0)]
    [JsonProperty("fileName", Order = 0)]
    public CharacterString_PropertyType FileName {
      get {
        return _fileName;
      }
      set {
        if (_fileName == value) {
          return;
        }
        if (_fileName == null || _fileName.Equals(value) != true) {
          _fileName = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _fileDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileDescription", Order = 1)]
    [JsonProperty("fileDescription", Order = 1)]
    public CharacterString_PropertyType FileDescription {
      get {
        return _fileDescription;
      }
      set {
        if (_fileDescription == value) {
          return;
        }
        if (_fileDescription == null || _fileDescription.Equals(value) != true) {
          _fileDescription = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _fileType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("fileType", Order = 2)]
    [JsonProperty("fileType", Order = 2)]
    public CharacterString_PropertyType FileType {
      get {
        return _fileType;
      }
      set {
        if (_fileType == value) {
          return;
        }
        if (_fileType == null || _fileType.Equals(value) != true) {
          _fileType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
