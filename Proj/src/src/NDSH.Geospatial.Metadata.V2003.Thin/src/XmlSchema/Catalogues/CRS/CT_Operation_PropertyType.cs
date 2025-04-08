
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 20:18, @gisvlasta.
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
  [XmlType("CT_Operation_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CT_Operation_PropertyType")]
  public class CT_Operation_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractCoordinateOperationType _abstractCoordinateOperation;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractCoordinateOperation", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractCoordinateOperation", Order = 0)]
    public AbstractCoordinateOperationType AbstractCoordinateOperation {
      get {
        return _abstractCoordinateOperation;
      }
      set {
        if (_abstractCoordinateOperation == value) {
          return;
        }
        if (_abstractCoordinateOperation == null || _abstractCoordinateOperation.Equals(value) != true) {
          _abstractCoordinateOperation = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
