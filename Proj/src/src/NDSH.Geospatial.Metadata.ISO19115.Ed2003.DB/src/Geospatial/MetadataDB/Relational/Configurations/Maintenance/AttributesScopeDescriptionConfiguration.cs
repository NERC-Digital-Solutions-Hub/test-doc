using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Maintenance;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Maintenance {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="AttributesScopeDescription" />.
  /// </summary>
  public sealed class AttributesScopeDescriptionConfiguration : IEntityTypeConfiguration<AttributesScopeDescription> {
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<AttributesScopeDescription> builder) => builder.Ignore(entity => entity.Attributes);
  }
}
