
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 03:03, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.EntitySet {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_Metadata_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_Metadata_PropertyType")]
  public class MD_Metadata_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_Metadata_PropertyType"/>.
    /// </summary>
    public MD_Metadata_PropertyType() {
      _md_Metadata = default; //  new MD_Metadata_Type();
    }

    #endregion

    #region Public Properties

    private MD_Metadata_Type _md_Metadata;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_Metadata", Order = 0)]
    [JsonProperty("MD_Metadata", Order = 0)]
    public MD_Metadata_Type MD_Metadata {
      get {
        return _md_Metadata;
      }
      set {
        if (_md_Metadata == value) {
          return;
        }
        if (_md_Metadata == null || _md_Metadata.Equals(value) != true) {
          _md_Metadata = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}