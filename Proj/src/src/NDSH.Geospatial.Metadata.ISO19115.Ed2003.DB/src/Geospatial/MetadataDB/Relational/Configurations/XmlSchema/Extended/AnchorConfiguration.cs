using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.XmlSchema.Extended;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.XmlSchema.Extended {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="Anchor_Type" />.
  /// </summary>
  public sealed class AnchorConfiguration : IEntityTypeConfiguration<Anchor_Type> {
    private const string TableName = "Anchor";
    private const string AdditionalInfoTableName = "Anchor_AdditionalInfo";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<Anchor_Type> builder) {
      builder.ToTable(TableName);

      builder.Property(entity => entity.Value)
        .IsRequired(false);

      builder.Property(entity => entity.Type)
        .IsRequired(false);

      builder.Property(entity => entity.Actuate)
        .IsRequired(false);

      builder.Property(entity => entity.ArcRole)
        .IsRequired(false);

      builder.Property(entity => entity.Href)
        .IsRequired(false);

      builder.Property(entity => entity.Role)
        .IsRequired(false);

      builder.Property(entity => entity.Show)
        .IsRequired(false);

      builder.Property(entity => entity.Title)
        .IsRequired(false);
    }
  }
}
