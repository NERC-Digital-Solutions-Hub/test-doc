
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 21/12/2022, 15:43, @gisvlasta.
// Updated by        : 02/01/2023, 19:16, @gisvlasta. - Changed inheritance to NilModel.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// --------------------------------------------------------------------------------
// <xs:element name="CharacterString" type="xs:string"/>
// <xs:complexType name="CharacterString_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gco:CharacterString"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

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

  #region CharacterString_PropertyType : SubstitutableText

  ///// <summary>
  ///// 
  ///// </summary>
  //[TypeConverter(typeof(CharacterString_PropertyTypeConverter))]
  //[XmlInclude(typeof(PT_FreeText_PropertyType))] // TODO: Check this include.
  //[Serializable]
  //[XmlType("CharacterString_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  //[JsonObject("CharacterString_PropertyType")]
  //public class CharacterString_PropertyType : SubstitutableText {

  //  #region Constructors - Destructors

  //  /// <summary>
  //  /// Initializes the <see cref="CharacterString_PropertyType"/>.
  //  /// </summary>
  //  public CharacterString_PropertyType() {

  //  }

  //  /// <summary>
  //  /// Initializes the <see cref="CharacterString_PropertyType"/>.
  //  /// </summary>
  //  /// <param name="value">The <see cref="string"/> to set.</param>
  //  public CharacterString_PropertyType(string value) {
  //    this.CharacterString = value;
  //  }

  //  #endregion

  //  #region Operator Overloading

  //  /// <summary>
  //  /// 
  //  /// </summary>
  //  /// <param name="characterStringPropertyType"></param>
  //  public static implicit operator string(CharacterString_PropertyType characterStringPropertyType) {
  //    return characterStringPropertyType.CharacterString;
  //  }

  //  /// <summary>
  //  /// 
  //  /// </summary>
  //  /// <param name="s"></param>
  //  public static implicit operator CharacterString_PropertyType(string s) {
  //    return new CharacterString_PropertyType(s);
  //  }

  //  #endregion

  //  #region Public Properties

  //  private string _characterString;

  //  /// <summary>
  //  /// 
  //  /// </summary>
  //  [XmlElement("CharacterString", Order = 0)]
  //  [JsonProperty("CharacterString", Order = 0)]
  //  public virtual string CharacterString {
  //    get {
  //      return _characterString;
  //    }
  //    set {
  //      if (_characterString == value) {
  //        return;
  //      }
  //      if (_characterString == null || _characterString.Equals(value) != true) {
  //        _characterString = value;
  //        OnPropertyChanged();
  //      }
  //    }
  //  }

  //  #endregion

  //}

  #endregion

  #region CharacterString_PropertyType : NilReasonModel

  /// <summary>
  /// 
  /// </summary>
  [TypeConverter(typeof(CharacterString_PropertyTypeConverter))]
  [XmlInclude(typeof(LanguageCode_PropertyType))]
  [XmlInclude(typeof(PT_FreeText_PropertyType))] // TODO: Check this include.
  [Serializable]
  [XmlType("CharacterString_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("CharacterString_PropertyType")]
  public class CharacterString_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CharacterString_PropertyType"/>.
    /// </summary>
    public CharacterString_PropertyType() {

    }

    /// <summary>
    /// Initializes the <see cref="CharacterString_PropertyType"/>.
    /// </summary>
    /// <param name="value">The <see cref="string"/> to set.</param>
    public CharacterString_PropertyType(string value) {
      this.CharacterString = value;
    }

    #endregion

    #region Operator Overloading

    /// <summary>
    /// 
    /// </summary>
    /// <param name="characterStringPropertyType"></param>
    public static implicit operator string(CharacterString_PropertyType characterStringPropertyType) {
      return characterStringPropertyType.CharacterString;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    public static implicit operator CharacterString_PropertyType(string s) {
      return new CharacterString_PropertyType(s);
    }

    #endregion

    #region Public Properties

    private string _characterString;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CharacterString", Order = 0)]
    [JsonProperty("CharacterString", Order = 0)]
    public virtual string CharacterString {
      get {
        return _characterString;
      }
      set {
        if (_characterString == value) {
          return;
        }
        if (_characterString == null || _characterString.Equals(value) != true) {
          _characterString = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

  #endregion

}
