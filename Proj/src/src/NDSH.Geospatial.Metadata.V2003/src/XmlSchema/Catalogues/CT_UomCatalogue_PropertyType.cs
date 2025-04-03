
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 19:01, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_UomCatalogue_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_UomCatalogue_PropertyType")]
  public class CT_UomCatalogue_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_UomCatalogue_PropertyType"/>.
    /// </summary>
    public CT_UomCatalogue_PropertyType() {
      _ct_UomCatalogue  = default; //  new CT_UomCatalogue_Type();
    }

    #endregion

    #region Public Properties

    private CT_UomCatalogue_Type _ct_UomCatalogue;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CT_UomCatalogue", Order = 0)]
    [JsonProperty("CT_UomCatalogue", Order = 0)]
    public CT_UomCatalogue_Type CT_UomCatalogue {
      get {
        return _ct_UomCatalogue;
      }
      set {
        if (_ct_UomCatalogue == value) {
          return;
        }
        if (_ct_UomCatalogue == null || _ct_UomCatalogue.Equals(value) != true) {
          _ct_UomCatalogue = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
