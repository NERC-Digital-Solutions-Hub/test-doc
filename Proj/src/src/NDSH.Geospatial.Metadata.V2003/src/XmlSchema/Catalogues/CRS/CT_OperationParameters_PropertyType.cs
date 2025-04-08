
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 20:14, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Gml;
using NDSH.Geospatial.Metadata.V2003.Gml.Coordinate.Operations;
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

namespace NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CT_OperationParameters_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_OperationParameters_PropertyType")]
  public class CT_OperationParameters_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractGeneralOperationParameterType _abstractGeneralOperationParameter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractGeneralOperationParameter", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractGeneralOperationParameter", Order = 0)]
    public AbstractGeneralOperationParameterType AbstractGeneralOperationParameter {
      get {
        return _abstractGeneralOperationParameter;
      }
      set {
        if (_abstractGeneralOperationParameter == value) {
          return;
        }
        if (_abstractGeneralOperationParameter == null || _abstractGeneralOperationParameter.Equals(value) != true) {
          _abstractGeneralOperationParameter = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
