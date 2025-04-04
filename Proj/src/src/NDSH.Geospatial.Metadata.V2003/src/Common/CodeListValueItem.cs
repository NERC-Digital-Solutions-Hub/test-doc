﻿
#region Header
// --------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.V2003.csproj
// Created           : 13/02/2023, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="CodeListValue_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attribute name="codeList" type="xs:anyURI" use="required"/>
//       <xs:attribute name="codeListValue" type="xs:anyURI" use="required"/>
//       <xs:attribute name="codeSpace" type="xs:anyURI"/>
//     </xs:extension>
//   </xs:simpleContent>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text;
using NDSH.Geospatial.Metadata.V2003.Localisation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common {

  // TODO: REMOVE CLASS

  /// <summary>
  /// The <see cref="CodeListValue_Type"/> prototype is used to refer to a specific codelist value in a register.
  /// </summary>
  [XmlInclude(typeof(LanguageCodeProperty))]
  [Serializable]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gco")] // TODO: What is the name of the type here? Should it be CI_RoleCode
  //[XmlRoot("CI_RoleCode", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)] // TODO: DANGER!!! - Why CI_RoleCode here???
  [JsonObject("CodeListValueItem")]
  //WARNING: This Class MUST BE REMOVED
  public class CodeListValueItem : CharacterString, ICodeList, ICodeListValue, ICodeSpace {

    #region ICodeList Interface

    private string _codeList;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "codeList", DataType = "anyURI")]
    [JsonProperty("codeList")]
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string CodeList {
      get {
        return _codeList;
      }
      set {
        if (_codeList == value) {
          return;
        }
        if (_codeList == null || _codeList.Equals(value) != true) {
          _codeList = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region ICodeListValue Interface

    private string _codeListValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "codeListValue", DataType = "anyURI")]
    [JsonProperty("codeListValue")]
    [Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string CodeListValue {
      get {
        return _codeListValue;
      }
      set {
        if (_codeListValue == value) {
          return;
        }
        if (_codeListValue == null || _codeListValue.Equals(value) != true) {
          _codeListValue = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region ICodeSpace Interface

    private string _codeSpace;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    //[Required()] // TODO: Check out the RequiredAttribute and its arguments.
    public string CodeSpace {
      get {
        return _codeSpace;
      }
      set {
        if (_codeSpace == value) {
          return;
        }
        if (_codeSpace == null || _codeSpace.Equals(value) != true) {
          _codeSpace = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
