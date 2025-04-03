
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 16:48, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.GML.Dictionary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist {

  /// <summary>
  /// 
  /// </summary>
  /// <remarks>
  /// Constraints: - 1) metadataProperty.card = 0 - 2) dictionaryEntry.card = 0
  /// </remarks>
  [XmlInclude(typeof(ML_CodeListDictionary_Type))]
  [Serializable]
  [XmlType("CodeListDictionary", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("CodeListDictionary", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CodeListDictionary")]
  public class CodeListDictionary_Type : DictionaryType {
    
    #region Cosntructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CodeListDictionary_Type"/>.
    /// </summary>
    public CodeListDictionary_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _codeEntry  = default; //  new List<CodeDefinition_PropertyType>();

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

    private List<CodeDefinition_PropertyType> _codeEntry;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("codeEntry", Order = 0)]
    [JsonProperty("codeEntry", Order = 0)]
    public List<CodeDefinition_PropertyType> CodeEntry {
      get {
        return _codeEntry;
      }
      set {
        if (_codeEntry == value) {
          return;
        }
        if (_codeEntry == null || _codeEntry.Equals(value) != true) {
          _codeEntry = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
