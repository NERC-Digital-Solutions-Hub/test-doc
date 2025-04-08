
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 19:32, @gisvlasta.
// Updated by        : 09/01/2023, 13:51, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation {

  /// <summary>
  /// Telephone numbers for contacting the responsible individual or organisation.
  /// </summary>
  [Serializable]
  [XmlType("CI_Telephone", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("CI_Telephone", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Telephone")]
  public class CI_Telephone_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Telephone_Type"/>.
    /// </summary>
    public CI_Telephone_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _voice  = default; //  new List<CharacterString_PropertyType>();
      _facsimile  = default; //  new List<CharacterString_PropertyType>();
      
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

    private List<CharacterString> _voice;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("voice", Order = 0)]
    [JsonProperty("voice", Order = 0)]
    public List<CharacterString> Voice {
      get {
        return _voice;
      }
      set {
        if (_voice == value) {
          return;
        }
        if (_voice == null || _voice.Equals(value) != true) {
          _voice = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString> _facsimile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("facsimile", Order = 1)]
    [JsonProperty("facsimile", Order = 1)]
    public List<CharacterString> Facsimile {
      get {
        return _facsimile;
      }
      set {
        if (_facsimile == value) {
          return;
        }
        if (_facsimile == null || _facsimile.Equals(value) != true) {
          _facsimile = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}