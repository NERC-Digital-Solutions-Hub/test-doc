using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Identification;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Identification {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_BrowseGraphic_Type" />.
  /// </summary>
  public sealed class MdBrowseGraphicConfiguration : IEntityTypeConfiguration<MD_BrowseGraphic_Type> {
    private const string TableName = "MD_BrowseGraphic";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_BrowseGraphic_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.Property(entity => entity.FileName)
        .HasConversion(
          fileName => fileName.Value,
          value => new CharacterString(value))
        .IsRequired();

      builder.Property(entity => entity.FileDescription)
        .HasConversion(
          fileDescription => fileDescription.Value,
          value => new CharacterString(value))
        .IsRequired(false);

      builder.HasOne(entity => entity.FileType)
        .WithMany()
        .HasForeignKey("FileType_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
