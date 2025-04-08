
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 27/12/2022, 18:38, @gisvlasta.
// Updated by        : 09/01/2023, 20:47, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

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

namespace NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("RS_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("RS_Identifier", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("RS_Identifier")]
  public class RS_Identifier_Type : MD_Identifier_Type {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="RS_Identifier_Type"/>.
    /// </summary>
    public RS_Identifier_Type() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _codeSpace  = default; //  new CharacterString_PropertyType();
      _version  = default; //  new CharacterString_PropertyType();

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

    private CharacterString _codeSpace;
    
    /// <summary>
    /// /
    /// </summary>
    [XmlElement("codeSpace", Order = 0)]
    [JsonProperty("codeSpace", Order = 0)]
    public CharacterString CodeSpace {
      get {
        return _codeSpace;
      }
      set {
        if (_codeSpace == value) {
          return;
        }
        if (_codeSpace == null || _codeSpace.Equals(value) != true) {
          _codeSpace = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _version;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("version", Order = 1)]
    [JsonProperty("version", Order = 1)]
    public CharacterString Version {
      get {
        return _version;
      }
      set {
        if (_version == value) {
          return;
        }
        if (_version == null || _version.Equals(value) != true) {
          _version = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
