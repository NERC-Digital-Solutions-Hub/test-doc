
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 20:09, @gisvlasta.
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
      
      _name  = default; //  new CharacterString_PropertyType();
      _issueIdentification  = default; //  new CharacterString_PropertyType();
      _page  = default; //  new CharacterString_PropertyType();
      
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

    private CharacterString _name;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name", Order = 0)]
    [JsonProperty("name", Order = 0)]
    public CharacterString Name {
      get {
        return _name;
      }
      set {
        if (_name == value) {
          return;
        }
        if (_name == null || _name.Equals(value) != true) {
          _name = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _issueIdentification;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("issueIdentification", Order = 1)]
    [JsonProperty("issueIdentification", Order = 1)]
    public CharacterString IssueIdentification {
      get {
        return _issueIdentification;
      }
      set {
        if (_issueIdentification == value) {
          return;
        }
        if (_issueIdentification == null || _issueIdentification.Equals(value) != true) {
          _issueIdentification = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _page;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("page", Order = 2)]
    [JsonProperty("page", Order = 2)]
    public CharacterString Page {
      get {
        return _page;
      }
      set {
        if (_page == value) {
          return;
        }
        if (_page == null || _page.Equals(value) != true) {
          _page = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}