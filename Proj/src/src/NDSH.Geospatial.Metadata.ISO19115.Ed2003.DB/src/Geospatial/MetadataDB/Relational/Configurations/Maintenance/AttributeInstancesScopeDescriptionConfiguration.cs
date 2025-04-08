using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Maintenance;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Maintenance {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="AttributeInstancesScopeDescription" />.
  /// </summary>
  public sealed class AttributeInstancesScopeDescriptionConfiguration : IEntityTypeConfiguration<AttributeInstancesScopeDescription> {
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<AttributeInstancesScopeDescription> builder) => builder.Ignore(entity => entity.AttributeInstances);
  }
}
