
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 02:20, @gisvlasta.
// Updated by        : 09/01/2023, 19:36, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common.Citation;
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
  /// Keywords, their type and reference source.
  /// </summary>
  [Serializable]
  [XmlType("MD_Keywords", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Keywords", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Keywords")]
  public class MD_Keywords_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Keywords_Type"/>.
    /// </summary>
    public MD_Keywords_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _keyword  = default; //  new List<CharacterString_PropertyType>();
      _type  = default; //  new MD_KeywordTypeCode_PropertyType();
      _thesaurusName  = default; //  new CI_Citation_PropertyType();

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

    private List<CharacterString_PropertyType> _keyword;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("keyword", Order = 0)]
    [JsonProperty("keyword", Order = 0)]
    public List<CharacterString_PropertyType> Keyword {
      get {
        return _keyword;
      }
      set {
        if (_keyword == value) {
          return;
        }
        if (_keyword == null || _keyword.Equals(value) != true) {
          _keyword = value;
          OnPropertyChanged();
        }
      }
    }

    private MD_KeywordTypeCode_PropertyType _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type", Order = 1)]
    [JsonProperty("type", Order = 1)]
    public MD_KeywordTypeCode_PropertyType Type {
      get {
        return _type;
      }
      set {
        if (_type == value) {
          return;
        }
        if (_type == null || _type.Equals(value) != true) {
          _type = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_Citation_PropertyType _thesaurusName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("thesaurusName", Order = 2)]
    [JsonProperty("thesaurusName", Order = 2)]
    public CI_Citation_PropertyType ThesaurusName {
      get {
        return _thesaurusName;
      }
      set {
        if (_thesaurusName == value) {
          return;
        }
        if (_thesaurusName == null || _thesaurusName.Equals(value) != true) {
          _thesaurusName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
