
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 19:32, @gisvlasta.
// Updated by        : 10/01/2023, 01:34, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Localisation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Dictionary;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist {

  /// <summary>
  /// 
  /// </summary>
  /// <remarks>
  /// XML attributes contraints: - 1) Id is mandatory - 2) codeSpace (type xsd:anyURI) is mandatory
  /// </remarks>
  [Serializable]
  [XmlType("CodeAlternativeExpression", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("CodeAlternativeExpression", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CodeAlternativeExpression")]
  public class CodeAlternativeExpression_Type : DefinitionType {

    #region Cosntructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CodeAlternativeExpression_Type"/>.
    /// </summary>
    public CodeAlternativeExpression_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _locale  = default; //  new PT_Locale_PropertyType();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private PT_Locale_PropertyType _locale;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("locale", Order = 0)]
    [JsonProperty("locale", Order = 0)]
    public PT_Locale_PropertyType Locale {
      get {
        return _locale;
      }
      set {
        if (_locale == value) {
          return;
        }
        if (_locale == null || _locale.Equals(value) != true) {
          _locale = value;
          OnPropertyChanged();
        }
      }
    }

    private string _codeSpace;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    [Required()] // TODO: codeSpace (type xsd:anyURI) is mandatory
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
