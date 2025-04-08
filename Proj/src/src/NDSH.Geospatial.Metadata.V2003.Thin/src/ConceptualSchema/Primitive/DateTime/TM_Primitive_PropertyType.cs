
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 03/01/2023, 00:48, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.Thin.GML.Temporal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.DateTime {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("TM_Primitive_PropertyType", Namespace = "http://www.isotc211.org/2005/gts")]
  [JsonObject("TM_Primitive_PropertyType")]
  public class TM_Primitive_PropertyType : ObjectReference_PropertyType {

    #region Public Properties

    private AbstractTimePrimitiveType _abstractTimePrimitive;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AbstractTimePrimitive", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("AbstractTimePrimitive", Order = 0)]
    public AbstractTimePrimitiveType AbstractTimePrimitive {
      get {
        return _abstractTimePrimitive;
      }
      set {
        if (_abstractTimePrimitive == value) {
          return;
        }
        if (_abstractTimePrimitive == null || _abstractTimePrimitive.Equals(value) != true) {
          _abstractTimePrimitive = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
