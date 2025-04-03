using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Constraint;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Constraint {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_LegalConstraints_Type" />.
  /// </summary>
  public sealed class MdLegalConstraintsConfiguration : IEntityTypeConfiguration<MD_LegalConstraints_Type> {
    private const string TableName = "MD_LegalConstraints";
    private const string UseConstraintsTableName = "MD_LegalConstraints_UseConstraints";
    private const string AccessConstraintsTableName = "MD_LegalConstraints_AccessConstraints";
    private const string OtherConstrainsTableName = "MD_LegalConstraints_OtherConstraints";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_LegalConstraints_Type> builder) {
      builder.HasMany(entity => entity.AccessConstraints)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(AccessConstraintsTableName));

      builder.HasMany(entity => entity.UseConstraints)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(UseConstraintsTableName));

      builder.HasMany(entity => entity.OtherConstraints)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(OtherConstrainsTableName));
    }
  }
}
