
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 12:35, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Imagery.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("QE_CoverageResult_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("QE_CoverageResult_PropertyType")]
  public class QE_CoverageResult_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="QE_CoverageResult_PropertyType"/>.
    /// </summary>
    public QE_CoverageResult_PropertyType() {
      _qe_CoverageResult = default; // new QE_CoverageResult_Type();
    }

    #endregion

    #region Public Properties

    private QE_CoverageResult_Type _qe_CoverageResult;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("QE_CoverageResult", Order = 0)]
    [JsonProperty("QE_CoverageResult", Order = 0)]
    public QE_CoverageResult_Type QE_CoverageResult {
      get {
        return _qe_CoverageResult;
      }
      set {
        if (_qe_CoverageResult == value) {
          return;
        }
        if (_qe_CoverageResult == null || _qe_CoverageResult.Equals(value) != true) {
          _qe_CoverageResult = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
