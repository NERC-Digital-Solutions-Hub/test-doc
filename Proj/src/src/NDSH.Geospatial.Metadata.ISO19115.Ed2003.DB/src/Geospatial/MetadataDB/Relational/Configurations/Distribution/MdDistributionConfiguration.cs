using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Distribution;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Distribution {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_Distribution_Type" />.
  /// </summary>
  public sealed class MdDistributionConfiguration : IEntityTypeConfiguration<MD_Distribution_Type> {
    private const string TableName = "MD_Distribution";
    private const string DistributionFormatTableName = "MD_Distribution_DistributionFormat";
    private const string DistributorTableName = "MD_Distribution_Distributor";
    private const string TransferOptionsTableName = "MD_Distribution_TransferOptions";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_Distribution_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();


      builder.HasMany(entity => entity.DistributionFormat)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DistributionFormatTableName));

      builder.HasMany(entity => entity.Distributor)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(DistributorTableName));

      builder.HasMany(entity => entity.TransferOptions)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(TransferOptionsTableName));
    }
  }
}
