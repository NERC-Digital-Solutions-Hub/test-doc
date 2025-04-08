using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NDSH.Geospatial.Metadata.Service.Metadata;

namespace NDSH.Geospatial.MetadataDB.Relational.Configurations.Service.Metadata {
  /// <summary>
  ///   The <see cref="IEntityTypeConfiguration{TEntity}" /> for the <see cref="SV_CoupledResource_Type" />.
  /// </summary>
  public sealed class SvCoupledResourceConfiguration : IEntityTypeConfiguration<SV_CoupledResource_Type> {
    private const string TableName = "SV_CoupledResource";

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<SV_CoupledResource_Type> builder) {
      builder.ToTable(TableName);
      builder.ApplyBaseConfiguration();

      builder.HasOne(entity => entity.OperationName)
        .WithMany()
        .HasForeignKey("OperationName_CharacterStringDbId")
        .IsRequired(false);

      builder.HasOne(entity => entity.Identifier)
        .WithMany()
        .HasForeignKey("Identifier_CharacterStringDbId")
        .IsRequired(false);
    }
  }
}
