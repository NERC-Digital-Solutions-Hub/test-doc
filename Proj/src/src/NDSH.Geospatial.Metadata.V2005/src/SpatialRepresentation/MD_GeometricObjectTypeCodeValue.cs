
#region Header
// Title Name        : @@@@
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : Name of point or vector objects used to locate zero-, one-,
//                     two-, or threedimensional spatial locations in the dataset.
// Created by        : 20/09/2022, 15:02, @gisvlasta.
// Updated by        : 16/12/2022, 15:04, @EttoreM - Cleaned Xml Serialization Attributes.
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
  /// Name of point or vector objects used to locate zero-, one-,
  /// two-, or threedimensional spatial locations in the dataset.
  /// </summary>
  [Serializable]
  public enum MD_GeometricObjectTypeCodeValue {

    /// <summary>
    /// Set of geometric primitives such that their boundaries
    /// can be represented as a union of other primitives.
    /// </summary>
    [XmlEnum(Name = "complex")]
    [EnumMember(Value = "complex")]
    Complex = 1,

    /// <summary>
    /// Connected set of curves, solids or surfaces.
    /// </summary>
    [XmlEnum(Name = "composite")]
    [EnumMember(Value = "composite")]
    Composite = 2,

    /// <summary>
    /// Bounded, 1-dimensional geometric primitive, representing
    /// the continuous image of a line.
    /// </summary>
    [XmlEnum(Name = "curve")]
    [EnumMember(Value = "curve")]
    Curve = 3,

    /// <summary>
    /// Zero-dimensional geometric primitive, representing
    /// a position but not having an extent.
    /// </summary>
    [XmlEnum(Name = "point")]
    [EnumMember(Value = "point")]
    Point = 4,

    /// <summary>
    /// Bounded, connected 3-dimensional geometric primitive,
    /// representing the continuous image of a region of space.
    /// </summary>
    [XmlEnum(Name = "solid")]
    [EnumMember(Value = "solid")]
    Solid = 5,

    /// <summary>
    /// Bounded, connected 2-dimensional geometric primitive,
    /// representing the continuous image of a region of a plane.
    /// </summary>
    [XmlEnum(Name = "surface")]
    [EnumMember(Value = "surface")]
    Surface = 6,

  }

}
