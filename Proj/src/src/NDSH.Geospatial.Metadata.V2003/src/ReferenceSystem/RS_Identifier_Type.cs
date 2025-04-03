
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 27/12/2022, @gisvlasta
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
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ReferenceSystem {

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

      _codeSpace = default; //  new CharacterString_PropertyType();
      _version = default; //  new CharacterString_PropertyType();

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

    private CharacterString_PropertyType _codeSpace;

    /// <summary>
    /// /
    /// </summary>
    [XmlElement("codeSpace", Order = 0)]
    [JsonProperty("codeSpace", Order = 0)]
    // WARNING: This seems weired. It could have been an ICodespace if this was a string instead of CharacterString.
    public CharacterString_PropertyType CodeSpace {
      get => _codeSpace;
      set {
        if (_codeSpace == value) {
          return;
        }
        if (_codeSpace == null || !_codeSpace.Equals(value)) {
          _codeSpace = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString_PropertyType _version;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("version", Order = 1)]
    [JsonProperty("version", Order = 1)]
    public CharacterString_PropertyType Version {
      get => _version;
      set {
        if (_version == value) {
          return;
        }
        if (_version == null || !_version.Equals(value)) {
          _version = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
