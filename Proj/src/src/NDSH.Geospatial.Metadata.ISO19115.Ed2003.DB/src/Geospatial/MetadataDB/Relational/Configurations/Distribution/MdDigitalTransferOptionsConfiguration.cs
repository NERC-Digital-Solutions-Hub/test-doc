using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Distribution;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Distribution {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="MD_DigitalTransferOptions_Type" />.
  /// </summary>
  public sealed class MdDigitalTransferOptionsConfiguration : IEntityTypeConfiguration<MD_DigitalTransferOptions_Type> {
    private const string TableName = "MD_DigitalTransferOptions";
    private const string OnLineTableName = "MD_DigitalTransferOptions_OnLine";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MD_DigitalTransferOptions_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.UnitsOfDistribution)
        .WithMany()
        .HasForeignKey("UnitsOfDistribution_CharacterStringDbId")
        .IsRequired(false);

      builder.HasMany(entity => entity.OnLine)
        .WithMany()
        .UsingEntity(entity => entity.ToTable(OnLineTableName));

      builder.Ignore(entity => entity.OffLine); // TODO: TEMP
    }
  }
}
