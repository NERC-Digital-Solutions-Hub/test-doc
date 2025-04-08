
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 20:16, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML;
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Operations;
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS
{

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_OperationMethod_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_OperationMethod_PropertyType")]
  public class CT_OperationMethod_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CT_OperationMethod_PropertyType"/>.
    /// </summary>
    public CT_OperationMethod_PropertyType() {
      _operationMethod  = default; //  new OperationMethodType();
    }

    #endregion

    #region Public Proeprties

    private OperationMethodType _operationMethod;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("OperationMethod", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("OperationMethod", Order = 0)]
    public OperationMethodType OperationMethod {
      get {
        return _operationMethod;
      }
      set {
        if (_operationMethod == value) {
          return;
        }
        if (_operationMethod == null || _operationMethod.Equals(value) != true) {
          _operationMethod = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
