
#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Primitive.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.ConceptualSchema.Implementation.Names {

  /// <summary>
  /// A TypeName is a LocalName that references either a recordType or
  /// object type in some form of schema. The stored value "aName" is
  /// the returned value for the "aName()" operation. This is the types name.
  /// - For parsing from types (or objects) the parsible name normally uses a "."
  /// navigation separator, so that it is of the form  [class].[member].[memberOfMember]. ...)
  /// </summary>
  [Serializable]
  [XmlRoot("TypeName_Type", Namespace = "http://www.isotc211.org/2005/gco", IsNullable = true)]
  [XmlType("TypeName_Type", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("TypeName_Type")]
  public class TypeName_Type : AbstractObject {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="TypeName_Type"/>.
    /// </summary>
    public TypeName_Type() {
      _aName = new CharacterString_PropertyType();
    }

    #endregion

    #region Public Properties

    private CharacterString_PropertyType _aName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0, ElementName = "aName")]
    [JsonProperty("aName", Order = 0)]
    public CharacterString_PropertyType AName {
      get {
        return _aName;
      }
      set {
        if ((_aName == value)) {
          return;
        }
        if (((_aName == null)
                    || (_aName.Equals(value) != true))) {
          _aName = value;
          OnPropertyChanged("AName");
        }
      }
    }

    #endregion

  }

}
