
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 11:47, @gisvlasta.
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
  [XmlType("MI_RangeElementDescription_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_RangeElementDescription_PropertyType")]
  public class MI_RangeElementDescription_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_RangeElementDescription_PropertyType"/>.
    /// </summary>
    public MI_RangeElementDescription_PropertyType() {
      _mi_RangeElementDescription = default; // new MI_RangeElementDescription_Type();
    }

    #endregion

    #region Public Properties

    private MI_RangeElementDescription_Type _mi_RangeElementDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_RangeElementDescription", Order = 0)]
    [JsonProperty("MI_RangeElementDescription", Order = 0)]
    public MI_RangeElementDescription_Type MI_RangeElementDescription {
      get {
        return _mi_RangeElementDescription;
      }
      set {
        if (_mi_RangeElementDescription == value) {
          return;
        }
        if (_mi_RangeElementDescription == null || _mi_RangeElementDescription.Equals(value) != true) {
          _mi_RangeElementDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
