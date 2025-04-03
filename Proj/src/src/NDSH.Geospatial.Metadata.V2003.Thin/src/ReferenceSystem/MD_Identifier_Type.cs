
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 14:25, @gisvlasta.
// Updated by        : 09/01/2023, 20:48, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NDSH.Geospatial.Metadata.V2003.Thin.Common;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(RS_Identifier_Type))]
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

      _authority  = default; //  new CI_Citation_PropertyType();
      _code  = default; //  new CharacterString_PropertyType();

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

    private CharacterString _code;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("authority", Order = 0)]
    [JsonProperty("authority", Order = 0)]
    public CI_Citation_PropertyType Authority {
      get {
        return _authority;
      }
      set {
        if (_authority == value) {
          return;
        }
        if (_authority == null || _authority.Equals(value) != true) {
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
    public CharacterString Code {
      get {
        return _code;
      }
      set {
        if (_code == value) {
          return;
        }
        if (_code == null || _code.Equals(value) != true) {
          _code = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
