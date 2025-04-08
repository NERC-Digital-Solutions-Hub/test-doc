using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Common.BasicTypes.Primitive.Text;
using NDSH.Geospatial.Metadata.Identification;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Identification {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="AbstractMD_Identification_Type" />.
  /// </summary>
  public sealed class AbstractMdIdentificationConfiguration : IEntityTypeConfiguration<AbstractMD_Identification_Type> {
    private const string TableName = "AbstractMD_Identification";
    private const string StatusTableName = "AbstractMD_Identification_Status";
    private const string ResourceSpecificUsageTableName = "AbstractMD_Identification_ResourceSpecificUsage";
    private const string AggregationInfoTableName = "AbstractMD_Identification_AggregationInfo";
    private const string CreditTableName = "AbstractMD_Identification_Credit";
    private const string ResourceMaintenanceTableName = "AbstractMD_Identification_ResourceMaintenance";
    private const string ResourceFormatTableName = "AbstractMD_Identification_ResourceFormat";
    private const string ResourceConstraintsTableName = "AbstractMD_Identification_ResourceConstraints";
    private const string PointOfContactTableName = "AbstractMD_Identification_PointOfContact";
    private const string GraphicOverviewTableName = "AbstractMD_Identification_GraphicOverview";
    private const string DescriptiveKeywordsTableName = "AbstractMD_Identification_DescriptiveKeywords";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<AbstractMD_Identification_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.Property(entity => entity.Abstract)
        .HasConversion(
          @abstract => @abstract.Value,
          value => new CharacterString(value))
        .IsRequired(false);

      builder.HasOne(entity => entity.Citation) // TODO: Consider making this owned. This will remove the need for a join.
                                                // AbstractMD_Identification_Type does not appear to share citations.
        .WithMany()
        .HasForeignKey("Citation_CI_CitationDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Purpose)
        .WithMany()
        .HasForeignKey("Purpose_CharacterStringDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.Status)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(StatusTableName));

      builder.HasMany(entity => entity.ResourceSpecificUsage)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ResourceSpecificUsageTableName));

      builder.HasMany(entity => entity.AggregationInfo)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(AggregationInfoTableName));

      builder.HasMany(entity => entity.Credit)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(CreditTableName));

      builder.HasMany(entity => entity.ResourceMaintenance)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ResourceMaintenanceTableName));

      builder.HasMany(entity => entity.ResourceFormat)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ResourceFormatTableName));

      builder.HasMany(entity => entity.ResourceConstraints)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(ResourceConstraintsTableName));

      builder.HasMany(entity => entity.PointOfContact)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(PointOfContactTableName));

      builder.HasMany(entity => entity.GraphicOverview)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(GraphicOverviewTableName));

      builder.HasMany(entity => entity.DescriptiveKeywords)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DescriptiveKeywordsTableName));
    }
  }
}
