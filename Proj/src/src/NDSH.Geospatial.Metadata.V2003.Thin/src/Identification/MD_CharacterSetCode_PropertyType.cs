
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 02:11, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Identification {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_CharacterSetCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_CharacterSetCode_PropertyType")]
  public class MD_CharacterSetCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_CharacterSetCode_PropertyType"/>.
    /// </summary>
    public MD_CharacterSetCode_PropertyType() {
      _md_CharacterSetCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_CharacterSetCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_CharacterSetCode", Order = 0)]
    [JsonProperty("MD_CharacterSetCode", Order = 0)]
    public CodeListValue_Type MD_CharacterSetCode {
      get {
        return _md_CharacterSetCode;
      }
      set {
        if (_md_CharacterSetCode == value) {
          return;
        }
        if (_md_CharacterSetCode == null || _md_CharacterSetCode.Equals(value) != true) {
          _md_CharacterSetCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
