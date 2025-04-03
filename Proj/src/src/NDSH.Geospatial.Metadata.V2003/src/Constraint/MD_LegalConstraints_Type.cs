
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 05:33, @gisvlasta.
// Updated by        : 09/01/2023, 18:19, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
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

namespace NDSH.Geospatial.Metadata.V2003.Constraint {

  /// <summary>
  /// Restrictions and legal prerequisites for accessing and using the dataset.
  /// </summary>
  [Serializable]
  [XmlType("MD_LegalConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_LegalConstraints", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_LegalConstraints")]
  public class MD_LegalConstraints_Type : MD_Constraints_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_LegalConstraints_Type"/>.
    /// </summary>
    public MD_LegalConstraints_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _accessConstraints  = default; //  new List<MD_RestrictionCode_PropertyType>();
      _useConstraints  = default; //  new List<MD_RestrictionCode_PropertyType>();
      _otherConstraints  = default; //  new List<CharacterString_PropertyType>();
      
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

    private List<MD_RestrictionCode_PropertyType> _accessConstraints;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("accessConstraints", Order = 0)]
    [JsonProperty("accessConstraints", Order = 0)]
    public List<MD_RestrictionCode_PropertyType> AccessConstraints {
      get {
        return _accessConstraints;
      }
      set {
        if (_accessConstraints == value) {
          return;
        }
        if (_accessConstraints == null || _accessConstraints.Equals(value) != true) {
          _accessConstraints = value;
          OnPropertyChanged();
        }
      }
    }

    private List<MD_RestrictionCode_PropertyType> _useConstraints;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("useConstraints", Order = 1)]
    [JsonProperty("useConstraints", Order = 1)]
    public List<MD_RestrictionCode_PropertyType> UseConstraints {
      get {
        return _useConstraints;
      }
      set {
        if (_useConstraints == value) {
          return;
        }
        if (_useConstraints == null || _useConstraints.Equals(value) != true) {
          _useConstraints = value;
          OnPropertyChanged();
        }
      }
    }

    private List<CharacterString_PropertyType> _otherConstraints;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("otherConstraints", Order = 2)]
    [JsonProperty("otherConstraints", Order = 2)]
    public List<CharacterString_PropertyType> OtherConstraints {
      get {
        return _otherConstraints;
      }
      set {
        if (_otherConstraints == value) {
          return;
        }
        if (_otherConstraints == null || _otherConstraints.Equals(value) != true) {
          _otherConstraints = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}