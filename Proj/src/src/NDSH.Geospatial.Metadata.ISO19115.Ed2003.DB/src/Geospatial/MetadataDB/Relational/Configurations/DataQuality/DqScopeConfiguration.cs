using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.DataQuality;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.DataQuality {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="DQ_Scope_Type" />.
  /// </summary>
  public sealed class DqScopeConfiguration : IEntityTypeConfiguration<DQ_Scope_Type> {
    private const string TableName = "DQ_Scope";
    private const string LevelDescriptionTableName = "DQ_Scope_LevelDescription";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<DQ_Scope_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasMany(entity => entity.LevelDescription)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(LevelDescriptionTableName));

      builder.HasOne(entity => entity.Level)
        .WithMany()
        .HasForeignKey("Level_CodeListDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Extent)
        .WithMany()
        .HasForeignKey("Extent_ExtentDbId")
        .IsRequired(false);
    }
  }
}
