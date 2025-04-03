
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 11:39, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_ImageDescription_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_ImageDescription_PropertyType")]
  public class MI_ImageDescription_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_ImageDescription_PropertyType"/>.
    /// </summary>
    public MI_ImageDescription_PropertyType() {
      _mi_ImageDescription = default; // new MI_ImageDescription_Type();
    }

    #endregion

    #region Public Properties

    private MI_ImageDescription_Type _mi_ImageDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_ImageDescription", Order = 0)]
    [JsonProperty("MI_ImageDescription", Order = 0)]
    public MI_ImageDescription_Type MI_ImageDescription {
      get {
        return _mi_ImageDescription;
      }
      set {
        if (_mi_ImageDescription == value) {
          return;
        }
        if (_mi_ImageDescription == null || _mi_ImageDescription.Equals(value) != true) {
          _mi_ImageDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
