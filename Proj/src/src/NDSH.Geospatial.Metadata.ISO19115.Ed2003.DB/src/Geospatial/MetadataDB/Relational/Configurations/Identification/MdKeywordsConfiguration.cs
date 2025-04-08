using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Identification;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Identification {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_Keywords_Type" />.
  /// </summary>
  public sealed class MdKeywordsConfiguration : IEntityTypeConfiguration<MD_Keywords_Type> {
    private const string TableName = "MD_Keywords";
    private const string KeywordsTableName = "MD_Keywords_Keywords";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_Keywords_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasMany(entity => entity.Keyword)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(KeywordsTableName));

      builder.HasOne(entity => entity.Type)
        .WithMany()
        .HasForeignKey("Type_CodeListValueDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.ThesaurusName)
        .WithMany()
        .HasForeignKey("Thesaurus_CI_CitationDbId")
        .IsRequired(false);
    }
  }
}
