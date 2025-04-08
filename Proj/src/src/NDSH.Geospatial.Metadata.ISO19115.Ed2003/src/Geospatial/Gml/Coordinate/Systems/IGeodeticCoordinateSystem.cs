
#region Header
// ---------------------------------------------------------------------------------------------------------------------
// Member of         : NDSH.Geospatial.Metadata.ISO19115.Ed2003.csproj
// Created           : 25/03/2025, @gisvlasta
// GitHub Repository : https://github.com/NERC-Digital-Solutions-Hub/ndsh
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// ---------------------------------------------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.Systems {

  /// <summary>
  /// The <see cref="IGeodeticCoordinateSystem"/> is used to mark classes
  /// that define geodetic coordinate reference systems.
  /// </summary>
  /// <remarks>
  /// Implementing this interface indicates that the coordinate system can be used in conjunction with geodetic datums,
  /// and is suitable for global spatial referencing systems that model the Earth’s shape or curvature.
  /// Typical implementations include Cartesian, Ellipsoidal, and Spherical coordinate systems,
  /// as defined by ISO 19111 and GML 3.2.
  /// </remarks>
  public interface IGeodeticCoordinateSystem {

  }

}

