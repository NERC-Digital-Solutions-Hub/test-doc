
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 16:44, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
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

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.Codelist {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CodeListDictionary_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CodeListDictionary_PropertyType")]
  public class CodeListDictionary_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CodeListDictionary_PropertyType"/>.
    /// </summary>
    public CodeListDictionary_PropertyType() {
      _codeListDictionary  = default; //  new CodeListDictionary_Type();
    }

    #endregion

    #region Public Properties

    private CodeListDictionary_Type _codeListDictionary;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CodeListDictionary", Order = 0)]
    [JsonProperty("CodeListDictionary", Order = 0)]
    public CodeListDictionary_Type CodeListDictionary {
      get {
        return _codeListDictionary;
      }
      set {
        if (_codeListDictionary == value) {
          return;
        }
        if (_codeListDictionary == null || _codeListDictionary.Equals(value) != true) {
          _codeListDictionary = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
