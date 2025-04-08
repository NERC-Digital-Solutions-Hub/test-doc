using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NDSH.Apps;
using NDSH.Database.Entities;
using NDSH.Geospatial.Metadata.EntitySet;
using System.Linq.Expressions;
using System.Reflection;

namespace NDSH.Geospatial.MetadataDB.Relational {
  /// <summary>
  ///   Inserts metadata into the database.
  /// </summary>
  public sealed class MetadataXmlInserter {
    private readonly MetadataDatabaseContext _context = new();

    private readonly HashSet<string?> _identifiers = new();

    /// <summary>
    ///   Initializes a new instance of the <see cref="MetadataXmlInserter" /> class.
    /// </summary>
    private MetadataXmlInserter() {
    }

    /// <summary>
    ///   A singleton instance of the <see cref="MetadataXmlInserter" />.
    /// </summary>
    public static MetadataXmlInserter Instance {
      get;
    } = new();

    /// <summary>
    /// Inserts <see cref="MetadataDocument" /> instances into the database.
    /// </summary>
    /// <param name="documents">An <see cref="IEnumerable{T}"/> of <see cref="MetadataDocument"/> instances.</param>
    /// <returns>A <see cref="Task"/>.</returns>
    public async Task InsertDocumentsAsync(IEnumerable<MetadataDocument> documents) {
      _context.AddRange(documents);
      await _context.SaveChangesAsync();
    }

    /// <summary>
    ///   Inserts <see cref="MD_Metadata_Type" /> instances into the database.
    /// </summary>
    /// <param name="metadataInstances">An <see cref="IEnumerable{T}" /> of <see cref="MD_Metadata_Type" /> instances.</param>
    /// <returns>A <see cref="Task" />.</returns>
    public async Task InsertMetadataAsync(IEnumerable<MD_Metadata_Type> metadataInstances) {
      Console.WriteLine("Inserting metadata into database...");
      _context.ChangeTracker.AutoDetectChangesEnabled = false;
      MD_Metadata_Type[] metadataInstancesArray = metadataInstances.ToArray();

      for (int i = 0; i < metadataInstancesArray.Length; i++) {
        MD_Metadata_Type metadata = metadataInstancesArray[i];
        if (_identifiers.Contains(metadata.FileIdentifier.Value)) {
          Console.WriteLine($"Skipping {metadata.FileIdentifier.Value} as it already exists in the database.");
          continue;
        }

        Console.WriteLine($"Inserting {metadata.FileIdentifier.Value}...");
        await ObservableDbEntityInserter.InsertAsync(metadata, _context);
        Console.WriteLine($"Inserted {metadata.FileIdentifier.Value}. Progress: {i}/{metadataInstancesArray.Length}");
        _identifiers.Add(metadata.FileIdentifier.Value);
        await _context.SaveChangesAsync();
      }

      await _context.SaveChangesAsync();

      _context.ChangeTracker.AutoDetectChangesEnabled = true;
    }
  }
}
