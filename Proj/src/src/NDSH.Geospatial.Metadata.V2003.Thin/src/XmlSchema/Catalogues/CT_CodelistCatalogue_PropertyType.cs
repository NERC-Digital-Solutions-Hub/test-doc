
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 18:41, @gisvlasta.
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues {
  
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_CodelistCatalogue_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_CodelistCatalogue_PropertyType")]
  public class CT_CodelistCatalogue_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_CodelistCatalogue_PropertyType"/>.
    /// </summary>
    public CT_CodelistCatalogue_PropertyType() {
      _ct_CodelistCatalogue  = default; //  new CT_CodelistCatalogue_Type();
    }

    #endregion

    #region Public Proeprties

    private CT_CodelistCatalogue_Type _ct_CodelistCatalogue;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CT_CodelistCatalogue", Order = 0)]
    [JsonProperty("CT_CodelistCatalogue", Order = 0)]
    public CT_CodelistCatalogue_Type CT_CodelistCatalogue {
      get {
        return _ct_CodelistCatalogue;
      }
      set {
        if (_ct_CodelistCatalogue == value) {
          return;
        }
        if (_ct_CodelistCatalogue == null || _ct_CodelistCatalogue.Equals(value) != true) {
          _ct_CodelistCatalogue = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
