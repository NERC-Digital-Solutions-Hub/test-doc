using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.ReferenceSystem;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.ReferenceSystem {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="RS_Identifier_Type" />.
  /// </summary>
  public sealed class RsIdentifierConfiguration : IEntityTypeConfiguration<RS_Identifier_Type> {
    private const string TableName = "RS_Identifier";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RS_Identifier_Type> builder) {
      builder.ToTable(TableName);

      builder.HasOne(entity => entity.CodeSpace)
        .WithMany()
        .HasForeignKey("CodeSpace_CharacterStringDbId")
        .IsRequired(false);

      builder.Property(entity => entity.Version)
        .HasColumnName("Version")
        .HasConversion(
          characterString => characterString.Value,
          value => new CharacterString(value))
        .IsRequired(false);
    }
  }
}
