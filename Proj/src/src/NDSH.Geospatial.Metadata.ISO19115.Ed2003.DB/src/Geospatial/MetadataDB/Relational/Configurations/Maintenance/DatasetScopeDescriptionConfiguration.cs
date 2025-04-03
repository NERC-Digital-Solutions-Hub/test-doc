using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Maintenance;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Maintenance {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="DatasetScopeDescription" />.
  /// </summary>
  public sealed class DatasetScopeDescriptionConfiguration : IEntityTypeConfiguration<DatasetScopeDescription> {
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<DatasetScopeDescription> builder) {
      builder.HasOne(entity => entity.Dataset)
        .WithMany()
        .HasForeignKey("Dataset_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
