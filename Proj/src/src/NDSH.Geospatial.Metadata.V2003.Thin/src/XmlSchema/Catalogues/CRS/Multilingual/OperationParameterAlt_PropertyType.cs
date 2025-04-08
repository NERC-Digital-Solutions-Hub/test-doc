
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 13:10, @gisvlasta.
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
  [XmlType("OperationParameterAlt_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("OperationParameterAlt_PropertyType")]
  public class OperationParameterAlt_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="OperationParameterAlt_PropertyType"/>.
    /// </summary>
    public OperationParameterAlt_PropertyType() {
      _operationParameterAlt  = default; //  new OperationParameterAlt_Type();
    }

    #endregion

    #region Public Properties

    private OperationParameterAlt_Type _operationParameterAlt;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("OperationParameterAlt", Order = 0)]
    [JsonProperty("OperationParameterAlt", Order = 0)]
    public OperationParameterAlt_Type OperationParameterAlt {
      get {
        return _operationParameterAlt;
      }
      set {
        if (_operationParameterAlt == value) {
          return;
        }
        if (_operationParameterAlt == null || _operationParameterAlt.Equals(value) != true) {
          _operationParameterAlt = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
