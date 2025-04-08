using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Maintenance;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Maintenance {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="FeaturesScopeDescription" />.
  /// </summary>
  public sealed class FeaturesScopeDescriptionConfiguration : IEntityTypeConfiguration<FeaturesScopeDescription> {
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<FeaturesScopeDescription> builder) => builder.Ignore(entity => entity.Features);
  }
}
