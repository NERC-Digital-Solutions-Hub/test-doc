
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 03:24, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Names {

  // TODO: Check the summary and remarks of this class.

  /// <summary>
  /// A TypeName is a LocalName that references either a recordType or
  /// object type in some form of schema. The stored value "aName" is
  /// the returned value for the "aName()" operation. This is the types name.
  /// </summary>
  /// <remarks>
  /// For parsing from types (or objects) the parsible name normally uses a "." navigation separator,
  /// so that it is of the form  [class].[member].[memberOfMember]. ...)
  /// </remarks>
  [Serializable]
  [XmlType("TypeName", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot
  [JsonObject("TypeName")]
  public class TypeName_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TypeName_Type"/>.
    /// </summary>
    public TypeName_Type() {
      _aName  = default; //  new CharacterString_PropertyType();
    }

    #endregion

    #region Public Properties

    private CharacterString _aName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("aName", Order = 0)]
    [JsonProperty("aName", Order = 0)]
    public CharacterString AName {
      get {
        return _aName;
      }
      set {
        if (_aName == value) {
          return;
        }
        if (_aName == null || _aName.Equals(value) != true) {
          _aName = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}