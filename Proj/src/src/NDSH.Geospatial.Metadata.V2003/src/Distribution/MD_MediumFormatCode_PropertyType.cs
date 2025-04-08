
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:47, @gisvlasta.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_MediumFormatCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_MediumFormatCode_PropertyType")]
  public class MD_MediumFormatCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// MD_MediumFormatCode_PropertyType class constructor
    /// </summary>
    public MD_MediumFormatCode_PropertyType() {
      _md_MediumFormatCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_MediumFormatCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_MediumFormatCode", Order = 0)]
    [JsonProperty("MD_MediumFormatCode", Order = 0)]
    public CodeListValue_Type MD_MediumFormatCode {
      get {
        return _md_MediumFormatCode;
      }
      set {
        if (_md_MediumFormatCode == value) {
          return;
        }
        if (_md_MediumFormatCode == null || _md_MediumFormatCode.Equals(value) != true) {
          _md_MediumFormatCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}