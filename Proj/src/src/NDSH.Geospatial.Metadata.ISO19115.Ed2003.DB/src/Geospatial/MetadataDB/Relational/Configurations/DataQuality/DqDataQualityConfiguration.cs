using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.DataQuality;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.DataQuality {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="DQ_DataQuality_Type" />.
  /// </summary>
  public sealed class DqDataQualityConfiguration : IEntityTypeConfiguration<DQ_DataQuality_Type> {
    private const string TableName = "DQ_DataQuality";
    private const string ReportTableName = "DQ_DataQuality_Report";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<DQ_DataQuality_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.Scope)
        .WithMany()
        .HasForeignKey("Scope_DQ_ScopeDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Lineage)
        .WithMany()
        .HasForeignKey("Lineage_LI_LineageDbId")
        .IsRequired(false);

      builder.Ignore(entity => entity.Report); // TODO: TEMP
      //builder.HasMany(entity => entity.Report)
      //    .WithMany()
      //    .UsingEntity(entity => entity.ToTable(ReportTableName));
    }
  }
}
