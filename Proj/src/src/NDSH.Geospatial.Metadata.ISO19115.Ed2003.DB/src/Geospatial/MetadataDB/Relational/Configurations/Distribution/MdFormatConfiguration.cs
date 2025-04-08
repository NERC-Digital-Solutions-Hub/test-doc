using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Distribution;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Distribution {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_Format_Type" />.
  /// </summary>
  public sealed class MdFormatConfiguration : IEntityTypeConfiguration<MD_Format_Type> {
    private const string TableName = "MD_Format";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_Format_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.Name)
        .WithMany()
        .HasForeignKey("Name_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Version)
        .WithMany()
        .HasForeignKey("Version_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.AmendmentNumber)
        .WithMany()
        .HasForeignKey("AmendmentNumber_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Specification)
        .WithMany()
        .HasForeignKey("Specification_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.FileDecompressionTechnique)
        .WithMany()
        .HasForeignKey("FileDecompressionTechnique_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
