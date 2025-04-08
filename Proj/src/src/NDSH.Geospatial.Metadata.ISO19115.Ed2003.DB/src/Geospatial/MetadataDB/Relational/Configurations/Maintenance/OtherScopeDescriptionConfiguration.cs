using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Maintenance;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Maintenance {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="OtherScopeDescription" />.
  /// </summary>
  public sealed class OtherScopeDescriptionConfiguration : IEntityTypeConfiguration<OtherScopeDescription> {
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<OtherScopeDescription> builder) {
      builder.HasOne(entity => entity.Other)
        .WithMany()
        .HasForeignKey("Other_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
