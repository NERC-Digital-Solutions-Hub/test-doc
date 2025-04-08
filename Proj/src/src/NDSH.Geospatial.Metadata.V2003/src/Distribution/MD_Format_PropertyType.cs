
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 20:37, @gisvlasta.
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
  [XmlType("MD_Format_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Format_PropertyType")]
  public class MD_Format_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Format_PropertyType"/>.
    /// </summary>
    public MD_Format_PropertyType() {
      _md_Format  = default; //  new MD_Format_Type();
    }

    #endregion

    #region Public Properties

    private MD_Format_Type _md_Format;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Format", Order = 0)]
    [JsonProperty("MD_Format", Order = 0)]
    public MD_Format_Type MD_Format {
      get {
        return _md_Format;
      }
      set {
        if (_md_Format == value) {
          return;
        }
        if (_md_Format == null || _md_Format.Equals(value) != true) {
          _md_Format = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}