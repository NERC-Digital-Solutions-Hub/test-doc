
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 03:33, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Distribution {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MD_DistributionUnits_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("MD_DistributionUnits_PropertyType")]
  public class MD_DistributionUnits_PropertyType : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MD_DistributionUnits_PropertyType"/>.
    /// </summary>
    public MD_DistributionUnits_PropertyType() {
      _md_DistributionUnits  = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _md_DistributionUnits;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MD_DistributionUnits", Order = 0)]
    [JsonProperty("MD_DistributionUnits", Order = 0)]
    public CodeListValue_Type MD_DistributionUnits {
      get {
        return _md_DistributionUnits;
      }
      set {
        if (_md_DistributionUnits == value) {
          return;
        }
        if (_md_DistributionUnits == null || _md_DistributionUnits.Equals(value) != true) {
          _md_DistributionUnits = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}