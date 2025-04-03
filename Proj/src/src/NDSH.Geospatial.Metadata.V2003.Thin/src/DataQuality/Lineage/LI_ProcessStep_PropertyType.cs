
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 17:00, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Lineage {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LI_ProcessStep_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("LI_ProcessStep_PropertyType")]
  public class LI_ProcessStep_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LI_ProcessStep_PropertyType"/>.
    /// </summary>
    public LI_ProcessStep_PropertyType() {
      _li_ProcessStep  = default; //  new LI_ProcessStep_Type();
    }

    #endregion

    #region Public Properties 

    private LI_ProcessStep_Type _li_ProcessStep;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LI_ProcessStep", Order = 0)]
    [JsonProperty("LI_ProcessStep", Order = 0)]
    public LI_ProcessStep_Type LI_ProcessStep {
      get {
        return _li_ProcessStep;
      }
      set {
        if (_li_ProcessStep == value) {
          return;
        }
        if (_li_ProcessStep == null || _li_ProcessStep.Equals(value) != true) {
          _li_ProcessStep = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}