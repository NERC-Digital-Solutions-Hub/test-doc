
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 24/12/2022, 02:11, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Constraint {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_RestrictionCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_RestrictionCode_PropertyType")]
  public class MD_RestrictionCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_RestrictionCode_PropertyType"/>.
    /// </summary>
    public MD_RestrictionCode_PropertyType() {
      _md_RestrictionCode  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_RestrictionCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_RestrictionCode", Order = 0)]
    [JsonProperty("MD_RestrictionCode", Order = 0)]
    public CodeListValue_Type MD_RestrictionCode {
      get {
        return _md_RestrictionCode;
      }
      set {
        if (_md_RestrictionCode == value) {
          return;
        }
        if (_md_RestrictionCode == null || _md_RestrictionCode.Equals(value) != true) {
          _md_RestrictionCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}