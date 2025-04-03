using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Identification;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Identification {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_AggregateInformation_Type" />.
  /// </summary>
  public sealed class MdAggregateInformationConfiguration : IEntityTypeConfiguration<MD_AggregateInformation_Type> {
    private const string TableName = "MD_AggregateInformation";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_AggregateInformation_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.AggregateDataSetName)
        .WithMany()
        .HasForeignKey("AggregateDataSetName_CI_CitationDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.AggregateDataSetIdentifier)
        .WithMany()
        .HasForeignKey("AggregateDataSetIdentifier_MD_IdentifierDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.AssociationType)
        .WithMany()
        .HasForeignKey("AssociationType_CodeListDbId");

      builder.HasOne(entity => entity.InitiativeType)
        .WithMany()
        .HasForeignKey("InitiativeType_CodeListDbId");
    }
  }
}
