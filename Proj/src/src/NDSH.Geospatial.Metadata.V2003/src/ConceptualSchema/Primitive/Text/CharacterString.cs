
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 13/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;

//using NDSH.Geospatial.Metadata.V2003.Localisation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text {

  // TODO: REMOVE CLASS !!!

  /// <summary>
  /// 
  /// </summary>
  //[TypeConverter(typeof(CharacterString_PropertyTypeConverter))]
  //[XmlInclude(typeof(LanguageCodeProperty))]
  //[XmlInclude(typeof(LanguageCode_PropertyType))]
  //[XmlInclude(typeof(PT_FreeText_PropertyType))] // TODO: Check this include.
  [Serializable]
  [XmlType("CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("CharacterString")]
  public class CharacterString : NilReasonModel, IValue {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CharacterString"/>.
    /// </summary>
    public CharacterString() {

    }

    /// <summary>
    /// Initializes the <see cref="CharacterString"/>.
    /// </summary>
    /// <param name="value">The <see cref="string"/> to set.</param>
    public CharacterString(string value) {
      this.Value = value;
    }

    #endregion

    #region Operator Overloading

    /// <summary>
    /// 
    /// </summary>
    /// <param name="characterString"></param>
    public static implicit operator string(CharacterString characterString) => characterString.Value;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    public static implicit operator CharacterString(string s) => new(s);

    #endregion

    #region IValue Interface

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "string")]
    [JsonProperty("Value")]
    public string Value {
      get => _value;
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || !_value.Equals(value)) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
