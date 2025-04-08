using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Extent;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Common.Extent {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="EX_Extent_Type" />.
  /// </summary>
  public sealed class ExExtentConfiguration : IEntityTypeConfiguration<EX_Extent_Type> {
    private const string TableName = "EX_Extent";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<EX_Extent_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      // TEMP
      builder.Ignore(entity => entity.TemporalElement);
      builder.Ignore(entity => entity.VerticalElement);

      builder.HasOne(entity => entity.Description)
        .WithMany()
        .HasForeignKey("Description_CharacterStringDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.GeographicElement)
        .WithMany()
        .UsingEntity(entity => entity.ToTable("EX_Extent_GeographicElement"));
    }
  }
}
