
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 26/01/2023, 11:37, @gisvlasta.
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
  [XmlType("MI_BandDefinition_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_BandDefinition_PropertyType")]
  public class MI_BandDefinition_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_BandDefinition_PropertyType"/>.
    /// </summary>
    public MI_BandDefinition_PropertyType() {
      _mi_BandDefinition = default; //  new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _mi_BandDefinition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_BandDefinition", Order = 0)]
    [JsonProperty("MI_BandDefinition", Order = 0)]
    public CodeListValue_Type MI_BandDefinition {
      get {
        return _mi_BandDefinition;
      }
      set {
        if (_mi_BandDefinition == value) {
          return;
        }
        if (_mi_BandDefinition == null || _mi_BandDefinition.Equals(value) != true) {
          _mi_BandDefinition = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
