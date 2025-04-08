
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 15:17, @EttoreM - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.SpatialRepresentation {

  /// <summary>
  /// The code indicating whether grid data is point or area.
  /// </summary>
  [Serializable]
  public enum MD_CellGeometryCodeValue {

    /// <summary>
    /// Each cell represents a point.
    /// </summary>
    [XmlEnum(Name = "point")]
    [EnumMember(Value = "point")]
    Point = 1,

    /// <summary>
    /// Each cell represents an area.
    /// </summary>
    [XmlEnum(Name = "area")]
    [EnumMember(Value = "area")]
    Area = 2,

  }

}
