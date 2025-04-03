using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Maintenance;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Maintenance {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="FeatureInstancesScopeDescription" />.
  /// </summary>
  public sealed class FeatureInstancesScopeDescriptionConfiguration : IEntityTypeConfiguration<FeatureInstancesScopeDescription> {
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<FeatureInstancesScopeDescription> builder) => builder.Ignore(entity => entity.FeatureInstances);
  }
}
