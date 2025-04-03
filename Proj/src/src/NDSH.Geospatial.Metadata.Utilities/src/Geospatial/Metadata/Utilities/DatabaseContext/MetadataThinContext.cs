
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using NDSH.Geospatial.Metadata.Utilities.Models;
using NDSH.Geospatial.Metadata.V2003.Thin.EntitySet;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.DatabaseContext {

  /// <summary>
  /// 
  /// </summary>
  public class MetadataThinContext : DbContext {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MetadataContext"/>.
    /// </summary>
    /// <param name="path">The path to the SQLite file.</param>
    /// <param name="dbOption">
    /// The <see cref="DatabaseOption">option</see> of the type of database to use.
    /// </param>
    public MetadataThinContext(string? path = null, DatabaseOption dbOption = DatabaseOption.Sqlite) {
      this.Path = path;
      this.DbOption = dbOption;
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the database file path.
    /// </summary>
    public string Path {
      get;
      private set;
    }

    /// <summary>
    /// The database <see cref="DatabaseOption">option</see> is used to specify the type of database used.
    /// </summary>
    public DatabaseOption DbOption {
      get;
      private set;
    }

    /// <summary>
    /// Gets/Sets the metadata entities.
    /// </summary>
    public DbSet<MD_Metadata_Type> MD_Metadata_Types {
      get; set;
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Called when the context is being configured.
    /// </summary>
    /// <param name="options">
    /// The <see cref="DbContextOptionsBuilder"/> used to configure the context.
    /// </param>
    protected override void OnConfiguring(DbContextOptionsBuilder options) {

      if (this.Path == null) {
        throw new NullReferenceException("No path was given for the creation of the database");
      }

      switch (DbOption) {
        case DatabaseOption.Sqlite:
          options.UseSqlite($"Data Source={Path}");
          break;
        case DatabaseOption.PgSqlDev:
          options.UseNpgsql($"{Path}");
          break;
        case DatabaseOption.PgSqlStaging:
          options.UseNpgsql($"{Path}");
          break;
        default:
          throw new NotImplementedException("No such DatabaseOption, not yet.");
      }

    }

    /// <summary>
    /// Called when a model is being created.
    /// </summary>
    /// <param name="modelBuilder">
    /// The <see cref="ModelBuilder"/> used when creating the model.
    /// </param>
    protected override void OnModelCreating(ModelBuilder modelBuilder) {

      //modelBuilder.Entity<MD_Metadata_Type>(entity => {
      //  entity.ToTable("MD_Metadata_Types");
      //  entity.Property(e => e.Id).HasColumnName("id");
      //  entity.Property(e => e.Uuid).HasColumnName("uuid");
      //  entity.Property(e => e.FileIdentifier).HasColumnName("fileIdentifier");
      //});

      //modelBuilder.HasDefaultSchema("v2003");

      //modelBuilder.Entity<MD_Metadata_Type>(entity => {
      //  entity.ToTable("Metadata");
      //});

      //modelBuilder.Entity<MD_Metadata_Type>(entity => {
      //  entity.ToTable("Metadata", "Metatest");
      //});

      //modelBuilder.Entity<TitleComparison>()
      //    .HasOne<MetadataEntity>()
      //    .WithMany()
      //    .HasForeignKey(p => p.Uid);

      //modelBuilder.Entity<LevenshteinTitleStatistics>()
      //            .HasKey(c => new { c.RecordId });

    }

    #endregion

  }

}
