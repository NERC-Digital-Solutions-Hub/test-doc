using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.ReferenceSystem;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.ReferenceSystem {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_Identifier_Type" />.
  /// </summary>
  public sealed class MdIdentifierConfiguration : IEntityTypeConfiguration<MD_Identifier_Type> {
    private const string TableName = "MD_Identifier";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_Identifier_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.Authority)
        .WithMany()
        .HasForeignKey("Authority_MD_IdentifierDbId")
        .IsRequired(false);

      builder.Property(entity => entity.Code)
        .HasColumnName("Code")
        .HasConversion(
          characterString => characterString.Value,
          value => new CharacterString(value))
        .IsRequired(false);
    }
  }
}
