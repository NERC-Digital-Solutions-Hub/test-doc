
#region Header

// Title Name        : 
// Member of         : 
// Description       : 
// Created by        :  26/01/2023, 12:35, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("LE_NominalResolution_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("LE_NominalResolution_PropertyType")]
  public class LE_NominalResolution_PropertyType : NilReasonModel {

    // TODO: DANGER!!! - This class is complete nonsense.

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="LE_NominalResolution_PropertyType"/>.
    /// </summary>
    public LE_NominalResolution_PropertyType() {
      _le_NominalResolution = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _le_NominalResolution;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LE_NominalResolution", Order = 0)]
    [JsonProperty("LE_NominalResolution", Order = 0)]
    public CodeListValue_Type LE_NominalResolution {
      get {
        return _le_NominalResolution;
      }
      set {
        if (_le_NominalResolution == value) {
          return;
        }
        if (_le_NominalResolution == null || _le_NominalResolution.Equals(value) != true) {
          _le_NominalResolution = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
