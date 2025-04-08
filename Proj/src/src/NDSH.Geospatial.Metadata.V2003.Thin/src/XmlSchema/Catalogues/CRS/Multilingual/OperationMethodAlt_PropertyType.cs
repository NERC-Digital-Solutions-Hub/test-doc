
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 12:59, @gisvlasta.
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("OperationMethodAlt_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("OperationMethodAlt_PropertyType")]
  public class OperationMethodAlt_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="OperationMethodAlt_PropertyType"/>.
    /// </summary>
    public OperationMethodAlt_PropertyType() {
      _operationMethodAlt  = default; //  new OperationMethodAlt_Type();
    }

    #endregion

    #region Public Properties

    private OperationMethodAlt_Type _operationMethodAlt;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("OperationMethodAlt", Order = 0)]
    [JsonProperty("OperationMethodAlt", Order = 0)]
    public OperationMethodAlt_Type OperationMethodAlt {
      get {
        return _operationMethodAlt;
      }
      set {
        if (_operationMethodAlt == value) {
          return;
        }
        if (_operationMethodAlt == null || _operationMethodAlt.Equals(value) != true) {
          _operationMethodAlt = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
