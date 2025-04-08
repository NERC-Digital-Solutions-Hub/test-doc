using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Identification;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Identification {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_TopicCategoryCodeDbEntity" />.
  /// </summary>
  public sealed class MdTopicCategoryCodeDbEntityConfiguration : IEntityTypeConfiguration<MD_TopicCategoryCodeDbEntity> {
    private const string TableName = "MD_TopicCategoryCode";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_TopicCategoryCodeDbEntity> builder) {
      builder.ToTable(TableName);
      builder.ApplyDbIdConfiguration();

      builder.Property(entity => entity.Value)
        .HasConversion(
          code => code.ToString(),
          value => Enum.Parse<MD_TopicCategoryCodes>(value ?? string.Empty, true))
        .IsRequired(false);
    }
  }
}
