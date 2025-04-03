
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 02:00, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces


using NDSH.Apps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Gml.BasicTypes {

  /// <summary>
  /// gml:CodeType is a generalized type to be used for a term, keyword or name.
  /// It adds a XML attribute codeSpace to a term, where the value of the codeSpace
  /// attribute (if present) shall indicate a dictionary, thesaurus, classification scheme,
  /// authority, or pattern for the term.
  /// </summary>
  [XmlInclude(typeof(CodeWithAuthorityType))]
  [Serializable]
  [XmlType("CodeType", Namespace = "http://www.opengis.net/gml")]
  [JsonObject("CodeType")]
  public class CodeType : ObservableModel {

    #region Public Properties

    private string _codeSpace;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
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

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText]
    [JsonProperty("Value")]
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
