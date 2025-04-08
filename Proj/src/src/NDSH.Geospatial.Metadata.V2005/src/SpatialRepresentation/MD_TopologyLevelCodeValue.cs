
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : The degree of complexity of the spatial relationships.
// Created by        : 20/09/2022, 11:23, @gisvlasta.
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
  /// The degree of complexity of the spatial relationships.
  /// </summary>
  [Serializable]
  public enum MD_TopologyLevelCodeValue {

    /// <summary>
    /// Geometry objects without any additional structure which describes topology.
    /// </summary>
    [XmlEnum(Name = "geometryOnly")]
    [EnumMember(Value = "geometryOnly")]
    GeometryOnly = 1,

    /// <summary>
    /// 1-dimensional topological complex – commonly called “chain-node” topology.
    /// </summary>
    [XmlEnum(Name = "topology1D")]
    [EnumMember(Value = "topology1D")]
    Topology1D = 2,

    /// <summary>
    /// 1-dimensional topological complex that is planar.
    /// </summary>
    /// <remarks>
    /// A planar graph is a graph that can be drawn in a plane in
    /// such a way that no two edges intersect except at avertex.
    /// </remarks>
    [XmlEnum(Name = "planarGraph")]
    [EnumMember(Value = "planarGraph")]
    PlanarGraph = 3,

    /// <summary>
    /// 2-dimensional topological complex that is planar.
    /// </summary>
    /// <remarks>
    /// A 2-dimensional topological complex is commonly called
    /// “full topology” in a cartographic 2D environment.
    /// </remarks>
    [XmlEnum(Name = "fullPlanarGraph")]
    [EnumMember(Value = "fullPlanarGraph")]
    FullPlanarGraph = 4,

    /// <summary>
    /// 1-dimensional topological complex that is isomorphic to a subset of a surface.
    /// </summary>
    /// <remarks>
    /// A geometric complex is isomorphic to a topological complex if their elements
    /// are in a one-to-one, dimensional-and boundry-preserving correspondence to one another.
    /// </remarks>
    [XmlEnum(Name = "surfaceGraph")]
    [EnumMember(Value = "surfaceGraph")]
    SurfaceGraph = 5,

    /// <summary>
    /// 2-dimensional topological complex that is isomorphic to a subset of a surface
    /// </summary>
    [XmlEnum(Name = "fullSurfaceGraph")]
    [EnumMember(Value = "fullSurfaceGraph")]
    FullSurfaceGraph = 6,

    /// <summary>
    /// 3-dimensional topological complex.
    /// </summary>
    /// <remarks>
    /// A topological complex is a collection of topological primitives that
    /// are closed under the boundary operations.
    /// </remarks>
    [XmlEnum(Name = "topology3D")]
    [EnumMember(Value = "topology3D")]
    Topology3D = 7,

    /// <summary>
    /// Complete coverage of a 3D Euclidean coordinate space.
    /// </summary>
    [XmlEnum(Name = "fullTopology3D")]
    [EnumMember(Value = "fullTopology3D")]
    FullTopology3D = 8,

    /// <summary>
    /// Topological complex without any specified geometric realisation.
    /// </summary>
    [XmlEnum(Name = "abstract")]
    [EnumMember(Value = "abstract")]
    Abstract = 9,

  }

}
