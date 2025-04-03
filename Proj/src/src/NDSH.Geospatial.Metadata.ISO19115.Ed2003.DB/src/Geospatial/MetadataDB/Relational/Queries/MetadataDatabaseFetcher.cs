using Microsoft.EntityFrameworkCore;
using NDSH.Geospatial.Metadata.EntitySet;
using NDSH.Geospatial.MetadataDB.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSH.Geospatial.MetadataDB.Relational.Queries {
  /// <summary>
  /// Test class for fetching metadata from a database.
  /// </summary>
  public static class MetadataDatabaseFetcher {
    private static readonly MetadataDatabaseContext _context = new();

    /// <summary>
    /// Gets all <see cref="MetadataDocument"/> instances.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="MetadataDocument"/> instances.</returns>
    public static IEnumerable<MetadataDocument> GetMetadata() {
      return _context.Set<MetadataDocument>();
    }

    /// <summary>
    /// Gets a <see cref="MD_Metadata_Type"/> instance by the file identifier.
    /// </summary>W
    /// <param name="fileIdentifier">The file identifier.</param>
    /// <returns>
    /// A <see cref="MD_Metadata_Type"/> with the file identifier or <see langword="null"/> if no matching file 
    /// identifier was found.
    /// </returns>
    public static MD_Metadata_Type? GetMetadataByFileIdentifier(string fileIdentifier) {
      return _context.Set<MD_Metadata_Type>().FirstOrDefault(entity => entity.FileIdentifier == fileIdentifier);
    }
  }
}
