using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Implementation.Names;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.ConceptualSchema.Implementation.Names {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="LocalName" />.
  /// </summary>
  public sealed class LocalNameConfiguration : IEntityTypeConfiguration<LocalName> {
    private const string TableName = "LocalName";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<LocalName> builder) => builder.ToTable(TableName);
  }
}
