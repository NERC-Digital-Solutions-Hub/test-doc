
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.Common.Citation {

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

      _voice = default; //  new List<CharacterString_PropertyType>();
      _facsimile = default; //  new List<CharacterString_PropertyType>();

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

    private List<CharacterString_PropertyType> _voice;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("voice", Order = 0)]
    [JsonProperty("voice", Order = 0)]
    public List<CharacterString_PropertyType> Voice {
      get => _voice;
      set {
        if (_voice == value) {
          return;
        }
        if (_voice == null || !_voice.Equals(value)) {
          _voice = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString_PropertyType> _facsimile;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("facsimile", Order = 1)]
    [JsonProperty("facsimile", Order = 1)]
    public List<CharacterString_PropertyType> Facsimile {
      get => _facsimile;
      set {
        if (_facsimile == value) {
          return;
        }
        if (_facsimile == null || !_facsimile.Equals(value)) {
          _facsimile = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
