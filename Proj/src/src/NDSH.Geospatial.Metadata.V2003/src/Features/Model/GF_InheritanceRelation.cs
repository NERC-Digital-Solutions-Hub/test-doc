
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 20:08, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Truth;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Features.Model {

  // TODO: GF - Model / [Xml / [Json / Property Logic

  /// <summary>
  /// 
  /// </summary>
  [Serializable()]
  [XmlType(AnonymousType = false)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class GF_InheritanceRelation {

    #region Public Properties

    private CharacterString_PropertyType _name;

    /// <summary>
    /// 
    /// </summary>
    public CharacterString_PropertyType Name {
      get {
        return _name;
      }
      set {
        _name = value;
      }
    }

    private CharacterString_PropertyType _description;

    /// <summary>
    /// 
    /// </summary>
    public CharacterString_PropertyType Description {
      get {
        return _description;
      }
      set {
        _description = value;
      }
    }

    private Boolean_PropertyType _uniqueIsntance;

    /// <summary>
    /// 
    /// </summary>
    public Boolean_PropertyType UniqueInstance { // TODO: Should we use Boolean_PropertyType or an other simpler type???
      get {
        return _uniqueIsntance;
      }
      set {
        _uniqueIsntance = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private GF_Feature_PropertyType _subtype;

    /// <summary>
    /// 
    /// </summary>
    public GF_Feature_PropertyType Subtype {
      get {
        return _subtype;
      }
      set {
        _subtype = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private GF_Feature_PropertyType _supertype;

    /// <summary>
    /// 
    /// </summary>
    public GF_Feature_PropertyType Supertype {
      get {
        return _supertype;
      }
      set {
        _supertype = value;
      }
    }

    #endregion

  }

}
