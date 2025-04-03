
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 19:08, @gisvlasta.
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
  [XmlType("ML_CodeListDictionary_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("ML_CodeListDictionary_PropertyType")]
  public class ML_CodeListDictionary_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_CodeListDictionary_PropertyType"/>.
    /// </summary>
    public ML_CodeListDictionary_PropertyType() {
      _ml_CodeListDictionary  = default; //  new ML_CodeListDictionary_Type();
    }

    #endregion

    #region Public Properties

    private ML_CodeListDictionary_Type _ml_CodeListDictionary;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ML_CodeListDictionary", Order = 0)]
    [JsonProperty("ML_CodeListDictionary", Order = 0)]
    public ML_CodeListDictionary_Type ML_CodeListDictionary {
      get {
        return _ml_CodeListDictionary;
      }
      set {
        if (_ml_CodeListDictionary == value) {
          return;
        }
        if (_ml_CodeListDictionary == null || _ml_CodeListDictionary.Equals(value) != true) {
          _ml_CodeListDictionary = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
