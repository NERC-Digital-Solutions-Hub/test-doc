
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
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CI_Series", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("CI_Series", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("CI_Series")]
  public class CI_Series_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_Series_Type"/>.
    /// </summary>
    public CI_Series_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _name = default; //  new CharacterString_PropertyType();
      _issueIdentification = default; //  new CharacterString_PropertyType();
      _page = default; //  new CharacterString_PropertyType();

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

    private CharacterString_PropertyType _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString_PropertyType Name {
      get => _name;
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || !_name.Equals(value)) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _issueIdentification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("issueIdentification", Order = 1)]
    [JsonProperty("issueIdentification", Order = 1)]
    public CharacterString_PropertyType IssueIdentification {
      get => _issueIdentification;
      set {
        if (_issueIdentification == value) {
          return;
        }
        if (_issueIdentification == null || !_issueIdentification.Equals(value)) {
          _issueIdentification = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _page;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("page", Order = 2)]
    [JsonProperty("page", Order = 2)]
    public CharacterString_PropertyType Page {
      get => _page;
      set {
        if (_page == value) {
          return;
        }
        if (_page == null || !_page.Equals(value)) {
          _page = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
