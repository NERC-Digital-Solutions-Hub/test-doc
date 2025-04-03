
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 12:47, @gisvlasta.
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("OperationAlt_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("OperationAlt_PropertyType")]
  public class OperationAlt_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="OperationAlt_PropertyType"/> class constructor.
    /// </summary>
    public OperationAlt_PropertyType() {
      _operationAlt  = default; //  new OperationAlt_Type();
    }

    #endregion

    #region Public Properties

    private OperationAlt_Type _operationAlt;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("OperationAlt", Order = 0)]
    [JsonProperty("OperationAlt", Order = 0)]
    public OperationAlt_Type OperationAlt {
      get {
        return _operationAlt;
      }
      set {
        if (_operationAlt == value) {
          return;
        }
        if (_operationAlt == null || _operationAlt.Equals(value) != true) {
          _operationAlt = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
