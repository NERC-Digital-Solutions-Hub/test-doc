
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 07/01/2023, 18:47, @gisvlasta.
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
  [XmlType("CT_CrsCatalogue_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_CrsCatalogue_PropertyType")]
  public class CT_CrsCatalogue_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_CrsCatalogue_PropertyType"/>.
    /// </summary>
    public CT_CrsCatalogue_PropertyType() {
      _ct_CrsCatalogue  = default; //  new CT_CrsCatalogue_Type();
    }

    #endregion

    #region Public Properties

    private CT_CrsCatalogue_Type _ct_CrsCatalogue;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CT_CrsCatalogue", Order = 0)]
    [JsonProperty("CT_CrsCatalogue", Order = 0)]
    public CT_CrsCatalogue_Type CT_CrsCatalogue {
      get {
        return _ct_CrsCatalogue;
      }
      set {
        if (_ct_CrsCatalogue == value) {
          return;
        }
        if (_ct_CrsCatalogue == null || _ct_CrsCatalogue.Equals(value) != true) {
          _ct_CrsCatalogue = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
