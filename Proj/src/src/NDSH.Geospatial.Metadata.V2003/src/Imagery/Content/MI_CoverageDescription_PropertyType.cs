
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 11:38, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Content {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_CoverageDescription_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_CoverageDescription_PropertyType")]
  public class MI_CoverageDescription_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_CoverageDescription_PropertyType"/>.
    /// </summary>
    public MI_CoverageDescription_PropertyType() {
      _mi_CoverageDescription = default; // new MI_CoverageDescription_Type();
    }

    #endregion

    #region Public Properties

    private MI_CoverageDescription_Type _mi_CoverageDescription;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_CoverageDescription", Order = 0)]
    [JsonProperty("MI_CoverageDescription", Order = 0)]
    public MI_CoverageDescription_Type MI_CoverageDescription {
      get {
        return _mi_CoverageDescription;
      }
      set {
        if (_mi_CoverageDescription == value) {
          return;
        }
        if (_mi_CoverageDescription == null || _mi_CoverageDescription.Equals(value) != true) {
          _mi_CoverageDescription = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
