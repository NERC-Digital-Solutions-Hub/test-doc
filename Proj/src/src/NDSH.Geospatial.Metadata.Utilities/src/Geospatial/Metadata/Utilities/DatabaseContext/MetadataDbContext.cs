
#region Imported Namespaces

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NDSH.Database;
using NDSH.Geospatial.Metadata.V2003.Thin;
using NDSH.Geospatial.Metadata.V2003.Thin.EntitySet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.DatabaseContext {

  /// <summary>
  /// Provides access to the metadata database.
  /// </summary>
  public class MetadataDbContext : DbContext {

    #region Member Variables

    private static int _sequenceId = 0;

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MetadataDbContext"/>.
    /// </summary>
    /// <param name="connectionInfo">
    /// The <see cref="DatabaseConnectionInfo"/> used by the <see cref="MetadataDbContext"/>.
    /// </param>
    public MetadataDbContext(DatabaseConnectionInfo connectionInfo) {
      _connectionInfo = connectionInfo;
    }

    #endregion

    #region Public Properties

    private readonly DatabaseConnectionInfo _connectionInfo;

    /// <summary>
    /// Gets/Sets the <see cref="DatabaseConnectionInfo"/>.
    /// </summary>
    public DatabaseConnectionInfo ConnectionInfo {
      get {
        return _connectionInfo;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<MetadataTest> MetadataTests {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<MD_Metadata_Type> MD_Metadata {
      get; set;
    }

    #endregion

    #region Public Methods


    #endregion

    #region Overrides

    /// <summary>
    /// Called when the DbContext is being configured.
    /// </summary>
    /// <param name="optionsBuilder">
    /// The <see cref="DbContextOptionsBuilder"/> used to configure the context.
    /// </param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      //base.OnConfiguring(optionsBuilder);

      if (this.ConnectionInfo == null) {
        throw new NullReferenceException($"{nameof(this.ConnectionInfo)} could not be null");
      }

      if (this.ConnectionInfo.GetType() == typeof(SqliteConnectionInfo)) {
        optionsBuilder.UseSqlite(this.ConnectionInfo.ToConnectionString());
      }
      else if (this.ConnectionInfo.GetType() == typeof(PostgreSqlConnectionInfo)) {
        optionsBuilder.UseNpgsql(this.ConnectionInfo.ToConnectionString());
      }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      //base.OnModelCreating(modelBuilder);

      if (this.ConnectionInfo == null) {
        throw new NullReferenceException($"{nameof(this.ConnectionInfo)} could not be null");
      }

      if (this.ConnectionInfo.GetType() == typeof(SqliteConnectionInfo)) {

      }
      else if (this.ConnectionInfo.GetType() == typeof(PostgreSqlConnectionInfo)) {
        PostgreSqlConnectionInfo postgreSqlConnectionInfo = (PostgreSqlConnectionInfo)this.ConnectionInfo;
        modelBuilder.HasDefaultSchema(postgreSqlConnectionInfo.UsedSchema);
      }

      // This is to create the TPT strategy - Make sure it is called for each root type.
      //modelBuilder.Entity<Blog>().UseTptMappingStrategy()

      // This is to create the TPC strategy
      //modelBuilder.Entity<Blog>().UseTpcMappingStrategy()
      //  .ToTable("Blogs");
      //modelBuilder.Entity<RssBlog>()
      //  .ToTable("RssBlogs");

      // This is even better:
      //modelBuilder.Entity<Blog>().UseTpcMappingStrategy()

      //modelBuilder.Entity<MetadataTest>().ToTable("MetadataTests");
      //modelBuilder.Entity<MD_Metadata_Type>().ToTable("MD_Metadata");

      modelBuilder.Entity<MD_Metadata_Type>().UseTptMappingStrategy();

    }


    #endregion

    #region Private Procedures

    /// <summary>
    /// Gets the sequence id.
    /// </summary>
    /// <returns>An <see cref="int"/>with the squence id.</returns>
    private static int GetSequenceId() {
      return ++_sequenceId;
    }

    /// <summary>
    /// Resets the sequence id.
    /// </summary>
    private static void ResetSequenceId() {
      _sequenceId = 0;
    }

    #endregion

  }

}
