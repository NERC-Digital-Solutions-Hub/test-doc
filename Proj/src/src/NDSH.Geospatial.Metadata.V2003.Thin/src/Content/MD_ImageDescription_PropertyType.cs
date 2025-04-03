
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 20:28, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_ImageDescription_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_ImageDescription_PropertyType")]
  public class MD_ImageDescription_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_ImageDescription_PropertyType"/>.
    /// </summary>
    public MD_ImageDescription_PropertyType() {
      _md_ImageDescription  = default; //  new MD_ImageDescription_Type();
    }

    #endregion

    #region Public Properties

    private MD_ImageDescription_Type _md_ImageDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_ImageDescription", Order = 0)]
    [JsonProperty("MD_ImageDescription", Order = 0)]
    public MD_ImageDescription_Type MD_ImageDescription {
      get {
        return _md_ImageDescription;
      }
      set {
        if (_md_ImageDescription == value) {
          return;
        }
        if (_md_ImageDescription == null || _md_ImageDescription.Equals(value) != true) {
          _md_ImageDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}