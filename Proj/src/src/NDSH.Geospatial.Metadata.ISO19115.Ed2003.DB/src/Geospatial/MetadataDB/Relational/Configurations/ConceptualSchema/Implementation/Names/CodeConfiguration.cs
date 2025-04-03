using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Gml.BasicTypes;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.ConceptualSchema.Implementation.Names {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="CodeType" />.
  /// </summary>
  public sealed class CodeConfiguration : IEntityTypeConfiguration<CodeType> {
    private const string TableName = "Code";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CodeType> builder) {
      builder.ToTable(TableName);
      builder.ApplyDbIdConfiguration();

      builder.Property(entity => entity.Value)
        .IsRequired(false);

      builder.Property(entity => entity.CodeSpace)
        .IsRequired(false);
    }
  }
}
