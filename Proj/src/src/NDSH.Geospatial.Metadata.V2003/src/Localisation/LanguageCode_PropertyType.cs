
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 17:54, @gisvlasta.
// Updated by        : 09/01/2023, 20:11, @gisvlasta. - 1.0.1: Added xmlns field.
//                     19/01/2023, 01:26, @gisvlasta.
//                     1.0.2 - Changed inheritance to support CharacterString_PropertyType
//                             substitution as described in the xsd file.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gmd/freeText.xsd
// --------------------------------------------------------------------------------
// <xs:element name="LanguageCode" type="gco:CodeListValue_Type" substitutionGroup="gco:CharacterString"/>
// <xs:complexType name="LanguageCode_PropertyType">
//   <xs:sequence minOccurs="0">
//     <xs:element ref="gmd:LanguageCode"/>
//   </xs:sequence>
//   <xs:attribute ref="gco:nilReason"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
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

namespace NDSH.Geospatial.Metadata.V2003.Localisation {

  #region LanguageCode_PropertyType : SubstitutableText

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LanguageCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("LanguageCode_PropertyType")]
  public class LanguageCode_PropertyType : SubstitutableText {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LanguageCode_PropertyType"/>.
    /// </summary>
    public LanguageCode_PropertyType() {

      //xmlns = new XmlSerializerNamespaces();
      //xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _languageCode = default; //  new CodeListValue_Type();

    }

    #endregion

    #region Public Fields

    ///// <summary>
    ///// 
    ///// </summary>
    //[XmlNamespaceDeclarations()]
    //public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private CodeListValue_Type _languageCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LanguageCode", Order = 0)]
    [JsonProperty("LanguageCode", Order = 0)]
    public CodeListValue_Type LanguageCode {
      get {
        return _languageCode;
      }
      set {
        if (_languageCode == value) {
          return;
        }
        if (_languageCode == null || _languageCode.Equals(value) != true) {
          _languageCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

  #endregion

  #region LanguageCode_PropertyType : CharacterString_PropertyType

  ///// <summary>
  ///// 
  ///// </summary>
  //[Serializable]
  //[XmlType("LanguageCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[JsonObject("LanguageCode_PropertyType")]
  //public class LanguageCode_PropertyType : CharacterString_PropertyType {

  //  #region Constructors - Destructors

  //  /// <summary>
  //  /// Initializes the <see cref="LanguageCode_PropertyType"/>.
  //  /// </summary>
  //  public LanguageCode_PropertyType() {

  //    //xmlns = new XmlSerializerNamespaces();
  //    //xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

  //    _languageCode = default; //  new CodeListValue_Type();

  //  }

  //  #endregion

  //  #region Public Fields

  //  ///// <summary>
  //  ///// 
  //  ///// </summary>
  //  //[XmlNamespaceDeclarations()]
  //  //public XmlSerializerNamespaces xmlns;

  //  #endregion

  //  #region Public Properties

  //  /// <summary>
  //  /// This is the inherited from <see cref="CharacterString_PropertyType"/>
  //  /// <see cref="CharacterString"/> property. The property should have been
  //  /// an inheritance garbage; however it is used to get/set the
  //  /// <see cref="CodeListValue_Type.Value">Value</see> property of the
  //  /// <see cref="LanguageCode"/> property.
  //  /// </summary>
  //  [XmlIgnore()]
  //  [JsonIgnore()]
  //  public override string CharacterString {
  //    get {
  //      //if (_languageCode == null) {
  //      //  return null;
  //      //}
  //      //return _languageCode.Value;
  //      return null;
  //    }
  //    set {
  //      //if (_languageCode == null) {
  //      //  _languageCode = new CodeListValue_Type() {
  //      //    Value = value
  //      //  };
  //      //  OnPropertyChanged();
  //      //}
  //      //else {
  //      //  if (_languageCode.Value == value) {
  //      //    return;
  //      //  }
  //      //  if (_languageCode.Value == null || _languageCode.Value.Equals(value) != true) {
  //      //    _languageCode.Value = value;
  //      //    OnPropertyChanged();
  //      //  }
  //      //}
  //    }
  //  }

  //  private CodeListValue_Type _languageCode;

  //  /// <summary>
  //  /// 
  //  /// </summary>
  //  [XmlElement("LanguageCode", Order = 0)]
  //  [JsonProperty("LanguageCode", Order = 0)]
  //  public CodeListValue_Type LanguageCode {
  //    get {
  //      return _languageCode;
  //    }
  //    set {
  //      if (_languageCode == value) {
  //        return;
  //      }
  //      if (_languageCode == null || _languageCode.Equals(value) != true) {
  //        _languageCode = value;
  //        OnPropertyChanged();
  //      }
  //    }
  //  }

  //  #endregion

  //}

  #endregion

  #region LanguageCode_PropertyType : NilReasonModel

  ///// <summary>
  ///// 
  ///// </summary>
  //[Serializable]
  //[XmlType("LanguageCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  //[JsonObject("LanguageCode_PropertyType")]
  //public class LanguageCode_PropertyType : NilReasonModel {

  //  #region Constructors - Destructors

  //  /// <summary>
  //  /// Initializes the <see cref="LanguageCode_PropertyType"/>.
  //  /// </summary>
  //  public LanguageCode_PropertyType() {
  //    _languageCode = default; //  new CodeListValue_Type();
  //  }

  //  #endregion

  //  #region Public Properties

  //  private CodeListValue_Type _languageCode;

  //  /// <summary>
  //  /// 
  //  /// </summary>
  //  [XmlElement("LanguageCode", Order = 0)]
  //  [JsonProperty("LanguageCode", Order = 0)]
  //  public CodeListValue_Type LanguageCode {
  //    get {
  //      return _languageCode;
  //    }
  //    set {
  //      if (_languageCode == value) {
  //        return;
  //      }
  //      if (_languageCode == null || _languageCode.Equals(value) != true) {
  //        _languageCode = value;
  //        OnPropertyChanged();
  //      }
  //    }
  //  }

  //  #endregion

  //}

  #endregion

}
