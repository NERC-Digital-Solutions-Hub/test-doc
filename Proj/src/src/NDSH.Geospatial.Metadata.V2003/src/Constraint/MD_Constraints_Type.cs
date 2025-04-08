
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 01:54, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Common;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Constraint {

  /// <summary>
  /// Restrictions on the access and use of a dataset or metadata.
  /// </summary>
  [XmlInclude(typeof(MD_SecurityConstraints_Type))]
  [XmlInclude(typeof(MD_LegalConstraints_Type))]
  [Serializable]
  [XmlType("MD_Constraints", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("MD_Constraints", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("MD_Constraints")]
  public class MD_Constraints_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Constraints_Type"/>.
    /// </summary>
    public MD_Constraints_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _useLimitation  = default; //  new List<CharacterString_PropertyType>();
      
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

    private List<CharacterString_PropertyType> _useLimitation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("useLimitation", Order = 0)]
    [JsonProperty("useLimitation", Order = 0)]
    public List<CharacterString_PropertyType> UseLimitation {
      get {
        return _useLimitation;
      }
      set {
        if (_useLimitation == value) {
          return;
        }
        if (_useLimitation == null || _useLimitation.Equals(value) != true) {
          _useLimitation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
