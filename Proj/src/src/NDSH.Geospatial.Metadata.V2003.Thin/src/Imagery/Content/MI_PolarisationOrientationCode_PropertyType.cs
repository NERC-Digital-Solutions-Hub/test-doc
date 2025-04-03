
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 11:41, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation;
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
  [XmlType("MI_PolarisationOrientationCode_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_PolarisationOrientationCode_PropertyType")]
  public class MI_PolarisationOrientationCode_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_PolarisationOrientationCode_PropertyType"/>.
    /// </summary>
    public MI_PolarisationOrientationCode_PropertyType() {
      _mi_PolarisationOrientationCode = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_PolarisationOrientationCode;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_PolarisationOrientationCode", Order = 0)]
    [JsonProperty("MI_PolarisationOrientationCode", Order = 0)]
    public CodeListValue_Type MI_PolarisationOrientationCode {
      get {
        return _mi_PolarisationOrientationCode;
      }
      set {
        if (_mi_PolarisationOrientationCode == value) {
          return;
        }
        if (_mi_PolarisationOrientationCode == null || _mi_PolarisationOrientationCode.Equals(value) != true) {
          _mi_PolarisationOrientationCode = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
