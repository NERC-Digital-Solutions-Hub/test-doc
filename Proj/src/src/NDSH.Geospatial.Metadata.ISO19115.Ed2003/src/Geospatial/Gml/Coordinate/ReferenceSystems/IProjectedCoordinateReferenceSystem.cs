
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

using NDSH.Geospatial.Gml.Coordinate.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Gml.Coordinate.ReferenceSystems {

  /// <summary>
  /// The <see cref="IProjectedCoordinateReferenceSystem"/> represents a two-dimensional coordinate reference system
  /// derived from a geodetic or geographic base coordinate reference system CRS by applying a map projection.
  /// </summary>
  /// <remarks>
  /// <para>
  ///   A projected coordinate reference system is used to represent the curved surface of the Earth
  ///   on a planar surface with controlled distortion. It defines how geographic coordinates
  ///   (latitude and longitude) are transformed into projected coordinates (easting and northing),
  ///   typically using a <see cref="CartesianCSType"/>.
  /// </para>
  /// <para>
  ///   This interface is intended to be implemented by types that model projected coordinate reference
  ///   systems as defined in ISO 19111 and encoded in GML (e.g., <see cref="ProjectedCRSType"/>
  ///   The base coordinate reference system may be either a geodetic or geographic coordinate reference system,
  ///   and it is associated usually with a <see cref="CartesianCSType"/>.
  /// </para>
  /// </remarks>
  public interface IProjectedCoordinateReferenceSystem {

  }

}
