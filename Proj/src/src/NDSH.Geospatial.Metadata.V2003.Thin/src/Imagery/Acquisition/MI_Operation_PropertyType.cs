
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:42, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Operation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Operation_PropertyType")]
  public class MI_Operation_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Operation_PropertyType"/>.
    /// </summary>
    public MI_Operation_PropertyType() {
      _mi_Operation = default; // new MI_Operation_Type();
    }

    #endregion

    #region Public Properties

    private MI_Operation_Type _mi_Operation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Operation", Order = 0)]
    [JsonProperty("MI_Operation", Order = 0)]
    public MI_Operation_Type MI_Operation {
      get {
        return _mi_Operation;
      }
      set {
        if (_mi_Operation == value) {
          return;
        }
        if (_mi_Operation == null || _mi_Operation.Equals(value) != true) {
          _mi_Operation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
