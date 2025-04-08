
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 21/12/2022, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names {

  // TODO: Check summary
  /// <summary>
  /// A MemberName is a LocalName that references either an attribute slot
  /// in a record or  recordType or an attribute, operation, or association
  /// role in an object instance or  type description in some form of schema.
  /// The stored value "aName" is the returned value for the "aName()" operation.
  /// </summary>
  [Serializable]
  [XmlType("MemberName", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("MemberName")]
  public class MemberName_Type : AbstractObject_Type {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MemberName_Type"/>.
    /// </summary>
    public MemberName_Type() {
      _attributeType = default; //  new TypeName_PropertyType();
      _aName = default; //  new CharacterString_PropertyType();
    }

    #endregion

    #region Public Properties

    private CharacterString_PropertyType _aName;

    [XmlElement("aName", Order = 0)]
    [JsonProperty("aName", Order = 0)]
    public CharacterString_PropertyType AName {
      get => _aName;
      set {
        if (_aName == value) {
          return;
        }
        if (_aName == null || !_aName.Equals(value)) {
          _aName = value;
          OnPropertyChanged();
        }
      }
    }

    private TypeName_PropertyType _attributeType;

    [XmlElement("attributeType", Order = 1)]
    [JsonProperty("attributeType", Order = 1)]
    public TypeName_PropertyType AttributeType {
      get => _attributeType;
      set {
        if (_attributeType == value) {
          return;
        }
        if (_attributeType == null || !_attributeType.Equals(value)) {
          _attributeType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
