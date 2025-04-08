using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.DataQuality;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.DataQuality {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="DQ_ConformanceResult_Type" />.
  /// </summary>
  public sealed class DqConformanceResultConfiguration : IEntityTypeConfiguration<DQ_ConformanceResult_Type> {
    private const string TableName = "DQ_ConformanceResult";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<DQ_ConformanceResult_Type> builder) {
      builder.ToTable(TableName);

      builder.HasOne(entity => entity.Specification)
        .WithMany()
        .HasForeignKey("Specification_CitationDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Explanation)
        .WithMany()
        .HasForeignKey("Explanation_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
