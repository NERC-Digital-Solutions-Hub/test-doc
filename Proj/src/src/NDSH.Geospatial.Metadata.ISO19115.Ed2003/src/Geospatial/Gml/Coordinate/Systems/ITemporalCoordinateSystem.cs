
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
  /// The <see cref="ITemporalCoordinateSystem"/> represents a temporal coordinate system
  /// used within a temporal coordinate reference system.
  /// </summary>
  /// <remarks>
  /// <para>
  ///   A temporal coordinate system is a one-dimensional coordinate system used to describe
  ///   temporal positions along a linear axis. It typically references a temporal datum and
  ///   uses time-based units such as seconds, days, or ISO 8601 durations.
  /// </para>
  /// <para>
  ///   Implementing types define the structure of the temporal axis used by <see cref="TemporalCSType"/> instances.
  /// </para>
  /// </remarks>
  public interface ITemporalCoordinateSystem {

  }

}
