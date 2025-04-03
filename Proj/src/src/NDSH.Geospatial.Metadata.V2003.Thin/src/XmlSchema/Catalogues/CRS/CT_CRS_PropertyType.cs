
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 20:27, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_CRS_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_CRS_PropertyType")]
  public class CT_CRS_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractCRSType _abstractCRS;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractCRS", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractCRS", Order = 0)]
    public AbstractCRSType AbstractCRS {
      get {
        return _abstractCRS;
      }
      set {
        if (_abstractCRS == value) {
          return;
        }
        if (_abstractCRS == null || _abstractCRS.Equals(value) != true) {
          _abstractCRS = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
