
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
  [XmlType("QE_Usability_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("QE_Usability_PropertyType")]
  public class QE_Usability_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="QE_Usability_PropertyType"/>.
    /// </summary>
    public QE_Usability_PropertyType() {
      _qe_Usability = default; // new QE_Usability_Type();
    }

    #endregion

    #region Public Properties

    private QE_Usability_Type _qe_Usability;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("QE_Usability", Order = 0)]
    [JsonProperty("QE_Usability", Order = 0)]
    public QE_Usability_Type QE_Usability {
      get {
        return _qe_Usability;
      }
      set {
        if (_qe_Usability == value) {
          return;
        }
        if (_qe_Usability == null || _qe_Usability.Equals(value) != true) {
          _qe_Usability = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
