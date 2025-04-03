
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 03:17, @gisvlasta.
// Updated by        : 09/01/2023, 19:35, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Impoerted Namespaces

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
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Identification {

  /// <summary>
  /// Brief description of ways in which the dataset is currently used.
  /// </summary>
  [Serializable]
  [XmlType("MD_Usage", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Usage", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Usage")]
  public class MD_Usage_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Usage_Type"/>.
    /// </summary>
    public MD_Usage_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _specificUsage  = default; //  new CharacterString_PropertyType();
      _usageDateTime  = default; //  new DateTime_PropertyType();
      _userDeterminedLimitations  = default; //  new CharacterString_PropertyType();
      _userContactInfo  = default; //  new List<CI_ResponsibleParty_PropertyType>();

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

    private CharacterString _specificUsage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("specificUsage", Order = 0)]
    [JsonProperty("specificUsage", Order = 0)]
    public CharacterString SpecificUsage {
      get {
        return _specificUsage;
      }
      set {
        if (_specificUsage == value) {
          return;
        }
        if (_specificUsage == null || _specificUsage.Equals(value) != true) {
          _specificUsage = value;
          OnPropertyChanged();
        }
      }
    }

    private DateTime_PropertyType _usageDateTime;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("usageDateTime", Order = 1)]
    [JsonProperty("usageDateTime", Order = 1)]
    public DateTime_PropertyType UsageDateTime {
      get {
        return _usageDateTime;
      }
      set {
        if (_usageDateTime == value) {
          return;
        }
        if (_usageDateTime == null || _usageDateTime.Equals(value) != true) {
          _usageDateTime = value;
          OnPropertyChanged();
        }
      }
    }

    private CharacterString _userDeterminedLimitations;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("userDeterminedLimitations", Order = 2)]
    [JsonProperty("userDeterminedLimitations", Order = 2)]
    public CharacterString UserDeterminedLimitations {
      get {
        return _userDeterminedLimitations;
      }
      set {
        if (_userDeterminedLimitations == value) {
          return;
        }
        if (_userDeterminedLimitations == null || _userDeterminedLimitations.Equals(value) != true) {
          _userDeterminedLimitations = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CI_ResponsibleParty_PropertyType> _userContactInfo;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("userContactInfo", Order = 3)]
    [JsonProperty("userContactInfo", Order = 3)]
    public List<CI_ResponsibleParty_PropertyType> UserContactInfo {
      get {
        return _userContactInfo;
      }
      set {
        if (_userContactInfo == value) {
          return;
        }
        if (_userContactInfo == null || _userContactInfo.Equals(value) != true) {
          _userContactInfo = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
