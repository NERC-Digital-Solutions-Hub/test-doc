
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 15:43, @gisvlasta.
// Updated by        : 02/01/2023, 19:16, @gisvlasta. - Changed inheritance to NilModel.
//                     11/03/2023. 15:27, @gisvlasta. - Changed inheritance to SubstitutableText
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Localisation;
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Text {

  /// <summary>
  /// 
  /// </summary>
  //[TypeConverter(typeof(CharacterString_PropertyTypeConverter))]
  //[XmlInclude(typeof(LanguageCode_PropertyType))]
  //[XmlInclude(typeof(PT_FreeText_PropertyType))] // TODO: Check this include.
  [Serializable]
  [XmlType("CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("CharacterString")]
  public class CharacterString : SubstitutableText, IValue {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="Text.CharacterString"/>.
    /// </summary>
    public CharacterString() {
      
    }

    /// <summary>
    /// Initializes the <see cref="Text.CharacterString"/>.
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
    public static implicit operator string(CharacterString characterString) {
      return characterString.Value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    public static implicit operator CharacterString(string s) {
      return new CharacterString(s);
    }

    #endregion

    #region IValue Interface

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "string")] // TODO: ATTENTION !!!
    [JsonProperty("Value", Order = 0)]
    //[XmlElement("CharacterString", Order = 0)] // TODO: IMPORTANT !!! - Maybe here should be [TextAttribute ???
    //[JsonProperty("CharacterString", Order = 0)]
    public string Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
