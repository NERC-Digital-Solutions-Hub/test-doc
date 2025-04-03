
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:35, @gisvlasta.
// Updated by        : 09/01/2023, 20:11, @gisvlasta. - 1.0.1: Added xmlns field.
//                   : 12/03/2023, 02:18, @gisvlasta.
//                   : 1.0.2 - Changed inheritance.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// 
// --------------------------------------------------------------------------------
// <xs:complexType name="LocalisedCharacterString_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attribute name="id" type="xs:ID"/>
//       <xs:attribute name="locale" type="xs:anyURI"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Localisation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LocalisedCharacterString", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("LocalisedCharacterString", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("LocalisedCharacterString")]
  // TODO: This is a big problem. It seems that all strings could be substituted by Localised versions.
  // That means that if we want to do that in strings also, the LocalisedCharacterString_Type could not
  // inherit from CharacterString. Also the information about locale needs to be attached to the
  // string instance. This can ONLY be modeled using backwards reference.
  // TODO: Check if this needs to inherit from SubstitutableText, IValue
  public class LocalisedCharacterString_Type : CharacterString {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LocalisedCharacterString_Type"/>.
    /// </summary>
    public LocalisedCharacterString_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

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

    private string _locale;

    /// <summary>
    /// 
    /// </summary>
    // TODO: Urgent - Locale needs to be stored in a table. Then have the locale been referenced.
    [XmlAttribute(AttributeName = "locale", DataType = "anyURI")]
    [JsonProperty("locale")]
    public string Locale {
      get {
        return _locale;
      }
      set {
        if (_locale == value) {
          return;
        }
        if (_locale == null || _locale.Equals(value) != true) {
          _locale = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
