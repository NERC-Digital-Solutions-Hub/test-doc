
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
  [XmlType("LE_ProcessStep_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("LE_ProcessStep_PropertyType")]
  public class LE_ProcessStep_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_ProcessStep_PropertyType"/>.
    /// </summary>
    public LE_ProcessStep_PropertyType() {
      _le_ProcessStep = default; // new LE_ProcessStep_Type();
    }

    #endregion

    #region Public Properties

    private LE_ProcessStep_Type _le_ProcessStep;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LE_ProcessStep", Order = 0)]
    [JsonProperty("LE_ProcessStep", Order = 0)]
    public LE_ProcessStep_Type LE_ProcessStep {
      get {
        return _le_ProcessStep;
      }
      set {
        if (_le_ProcessStep == value) {
          return;
        }
        if (_le_ProcessStep == null || _le_ProcessStep.Equals(value) != true) {
          _le_ProcessStep = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
