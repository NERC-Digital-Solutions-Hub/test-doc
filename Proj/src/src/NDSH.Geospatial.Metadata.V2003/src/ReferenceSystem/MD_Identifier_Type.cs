
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 28/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
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

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  //[XmlInclude(typeof(RS_Identifier_Type))]
  [XmlType("MD_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Identifier", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Identifier")]
  public class MD_Identifier_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Identifier_Type"/>.
    /// </summary>
    public MD_Identifier_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _authority = default; //  new CI_Citation_PropertyType();
      _code = default; //  new CharacterString_PropertyType();

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

    private CharacterString_PropertyType _code;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("authority", Order = 0)]
    [JsonProperty("authority", Order = 0)]
    public CI_Citation_PropertyType Authority {
      get => _authority;
      set {
        if (_authority == value) {
          return;
        }
        if (_authority == null || !_authority.Equals(value)) {
          _authority = value;
          OnPropertyChanged();
        }
      }
    }

    private CI_Citation_PropertyType _authority;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("code", Order = 1)]
    [JsonProperty("code", Order = 1)]
    public CharacterString_PropertyType Code {
      get => _code;
      set {
        if (_code == value) {
          return;
        }
        if (_code == null || !_code.Equals(value)) {
          _code = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
