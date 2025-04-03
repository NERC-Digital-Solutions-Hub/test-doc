
#region Imported Namespaces

using Microsoft.EntityFrameworkCore;
using NDSH.Geospatial.Metadata.Utilities.Models;

#endregion

namespace NDSH.Geospatial.Metadata.Utilities.DatabaseContext {

  /// <summary>
  /// The SQLite Context.
  /// </summary>
  public class MetadataContextGraphApi : DbContext {

    #region Constructors - Destructors
    /// <summary>
    /// for asp.net graphApi purpose, emtpy as intented.
    /// </summary>
    /// <param name="options"></param>
    public MetadataContextGraphApi(DbContextOptions options): base(options) {

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
    public DbSet<MetadataEntity> MetadataEntities {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the BGS layer.
    /// </summary>
    public DbSet<BgsLayer> BgsLayers {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<BgsArcGisLayerJson> BgsArcGisLayerJsons {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<BgsArcGisMapServerJson> BgsArcGisMapServerJsons {
      get; set;
    }

    /// <summary>
    /// Gets/Sets the metadata title comparisons.
    /// </summary>
    public DbSet<TitleComparison> TitleComparisons {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<LevenshteinTitleComparison> LevenshteinTitleComparisons {
      get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<LevenshteinTitleStatistics> LevenshteinTitleStatistics {
      get; set;
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Called when a model is being created.
    /// </summary>
    /// <param name="modelBuilder">
    /// The <see cref="ModelBuilder"/> used when creating the model.
    /// </param>
    protected override void OnModelCreating(ModelBuilder modelBuilder) {

      //modelBuilder.Entity<TitleComparison>()
      //    .HasOne<MetadataEntity>()
      //    .WithMany()
      //    .HasForeignKey(p => p.Uid);

      //modelBuilder.Entity<LevenshteinTitleStatistics>()
      //            .HasKey(c => new { c.RecordId });

      //modelBuilder.Entity<BgsArcGisLayerJson>().ToTable("BgsArcGisLayerJsons", "public");
      //modelBuilder.Entity<BgsArcGisMapServerJson>().ToTable("BgsArcGisMapServerJsons", "public");
      //modelBuilder.Entity<BgsLayer>().ToTable("BgsLayers", "public");
      //modelBuilder.Entity<LevenshteinTitleComparison>().ToTable("LevenshteinTitleComparisons", "public");
      //modelBuilder.Entity<LevenshteinTitleStatistics>().ToTable("LevenshteinTitleStatistics", "public");
      //modelBuilder.Entity<MetadataEntity>().ToTable("MetadataEntities", "public");
      //modelBuilder.Entity<NgdcDataset>().ToTable("NgdcDataset", "public");

      modelBuilder.Entity<BgsArcGisLayerJson>().ToTable("BgsArcGisLayerJsons", "Metatest");
      modelBuilder.Entity<BgsArcGisMapServerJson>().ToTable("BgsArcGisMapServerJsons", "Metatest");
      modelBuilder.Entity<BgsLayer>().ToTable("BgsLayers", "Metatest");
      modelBuilder.Entity<LevenshteinTitleComparison>().ToTable("LevenshteinTitleComparisons", "Metatest");
      modelBuilder.Entity<LevenshteinTitleStatistics>().ToTable("LevenshteinTitleStatistics", "Metatest");
      modelBuilder.Entity<MetadataEntity>().ToTable("MetadataEntities", "Metatest");
      //modelBuilder.Entity<NgdcDataset>().ToTable("NgdcDataset", "Metatest");

    }

    #endregion

  }

}
