using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Distribution;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Distribution {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_Distributor_Type" />.
  /// </summary>
  public sealed class MdDistributorConfiguration : IEntityTypeConfiguration<MD_Distributor_Type> {
    private const string TableName = "MD_Distributor";
    private const string DistributionOrderProcessTableName = "MD_Distributor_DistributionOrderProcess";
    private const string DistributorFormatTableName = "MD_Distributor_DistributorFormat";
    private const string DistributorTransferOptionsTableName = "MD_Distributor_DistributorTransferOptions";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_Distributor_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.DistributorContact)
        .WithMany()
        .HasForeignKey("DistributorContact_CI_ResponsiblePartyDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.DistributionOrderProcess)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DistributionOrderProcessTableName));

      builder.HasMany(entity => entity.DistributorFormat)
        .WithMany(format => format.FormatDistributor)
        .UsingEntity(entity => entity.ToTable(DistributorFormatTableName));

      builder.HasMany(entity => entity.DistributorTransferOptions)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DistributorTransferOptionsTableName));
    }
  }
}
